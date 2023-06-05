using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenAI_API;
using OpenAI_API.Completions;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using DotnetBackend.Models;

namespace YourWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookRecommendationsController : ControllerBase
    {
        // string openAiApiKey = Configuration["OpenAiApiKey"];
        // string googleBooksApiKey = Configuration["GoogleBooksApiKey"]z;
        private readonly string openAiApiKey = "";

        // "AIzaSyB8sgvGq03w40VlGD0rX4RxyEdCXGazgvI"
        private readonly string googleBooksApiKey = "AIzaSyB8sgvGq03w40VlGD0rX4RxyEdCXGazgvI";

        private readonly OpenAIAPI openAiApi;
        private readonly HttpClient httpClient;

        public BookRecommendationsController()
        {
            openAiApi = new OpenAIAPI(openAiApiKey);
            httpClient = new HttpClient();
        }

        [HttpPost]
        
        public async Task<IActionResult> PostBookRecommendation([FromBody] string recommendationText)
        {
            // console recommendation from frontend
            System.Console.WriteLine(recommendationText);
            try
            {
                // Send prompt to OpenAI API for feedback
                CompletionRequest completionRequest = new CompletionRequest();
                completionRequest.Prompt = "Book recommendations: " + recommendationText + "\n";
                completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
                completionRequest.MaxTokens = 1024;

                var completions = await openAiApi.Completions.CreateCompletionAsync(completionRequest);
                string feedback = completions.Completions[0].Text;
                System.Console.WriteLine(feedback);

                // Split feedback into individual book recommendations
                string[] recommendations = feedback.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                // Call Google Books API to get book details for each recommendation
                List<object> books = new List<object>();
                foreach (string recommendation in recommendations)
                {
                    string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q={Uri.EscapeDataString(recommendation)}&maxResults=1&langRestrict=en&key={googleBooksApiKey}";

                    using (var response = await httpClient.GetAsync(apiUrl))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            return BadRequest($"Failed to get book details from Google Books API. Status code: {response.StatusCode}");
                        }

                        string content = await response.Content.ReadAsStringAsync();
                        var book = JsonConvert.DeserializeObject(content);
                        books.Add(book);
                        System.Console.WriteLine(book);
                    }
                }

                // Return books as a JSON response
                return Ok(JsonConvert.SerializeObject(books));
                System.Console.WriteLine(JsonConvert.SerializeObject(books));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



    }
}
