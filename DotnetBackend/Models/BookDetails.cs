using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetBackend.Models
{
   public class BookDetails
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string PublishedDate { get; set; }
    public string Description { get; set; }
    public int PageCount { get; set; }
    public string ThumbnailUrl { get; set; }
    public string PreviewUrl { get; set; }
    public string InfoUrl { get; set; }
}
}