<template>
    <div class="">
        
        <!-- Search Section -->
        <div class="relative  isolate px-6  mt-10 mb-20 pb-11 lg:px-8 ">
            <div class="mx-auto max-w-2xl py-5 sm:py-20 lg:py-36">
                <div class="hidden sm:mb-8 sm:flex sm:justify-center">
                </div>
                <div class="text-center">
                
                <!-- Heading -->
                <h1 class="text-4xl font-bold tracking-tight text-br sm:text-6xl mt-14">Find the perfect book to match your mood!
                </h1>

                <!-- Description -->
                <p class="mt-6 text-lg leading-8 text-gray-300">What are you in the mood for? <br> Don't be afraid to get
                    creative
                    with your descriptions - the more details you provide, the better we can match you with a book you'll
                    love.</p>
                
                <!-- Search Form -->
                <div class="mt-10 items-center justify-center">
                    <form @submit.prevent="submitForm">
                        <label for="default-search"
                            class="mb-2 text-sm font-medium text-gray-900 sr-only dark:text-white">Search</label>
                        <div class="relative">
                            <div class="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                                <svg aria-hidden="true" class="w-5 h-5 text-gray-500 dark:text-gray-400" fill="none"
                                    stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
                                        d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"></path>
                                </svg>
                            </div>
                            <input type="search" id="default-search"
                                class="block w-full p-4 pl-10 text-sm text-black border border-gray-300 rounded-lg bg-gray-50 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-900 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                                placeholder="a whimsical book filled with charming characters" required
                                v-model="recommendation" />
                            <button type="submit"
                                class="text-white absolute right-2.5 bottom-2.5 bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-4 py-2 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
                                Search
                            </button>
                        </div>
                    </form>

                    <!-- Overlay -->
                    <div v-if="showResults">
              <p class="mt-4 text-gray-500">Getting your book recommendations...</p>
            </div>

                </div>
                </div>

            </div>

        </div>

    <!-- Overlay -->
    <div v-if="showPopup" class="fixed inset-0 flex items-center justify-center bg-black bg-opacity-50 z-50">
      <!-- PopUp component -->
      <PopUp />
    </div>

    </div>
</template>


<script>
import PopUp from './PopUp.vue';

export default {
    data() {
        return {
            recommendation: '',
            showResults: false,
            results: [],
            showPopup: false,
        };
    },
    methods: {
        async submitForm() {
            const apiUrl = 'https://moodbook.azurewebsites.net/api/BookRecommendations';

            try {
                // Set showPopup to true to display the PopUp component
          this.showPopup = true;
                
                const response = await fetch(apiUrl, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(this.recommendation),
                });

                if (response.ok) {
                    const responseData = await response.json();

                    // Extract the book details from the response data
                    const books = [];
                    for (const item of responseData) {
                        if (Array.isArray(item.items) || typeof item.items === 'object') {
                            for (const book of item.items) {
                                const bookObj = {
                                    title: book.volumeInfo.title,
                                    authors: book.volumeInfo.authors || [],
                                    description: book.volumeInfo.description,
                                    snippet: book.searchInfo?.textSnippet || '',
                                    thumbnail: book.volumeInfo.imageLinks?.thumbnail || 'https://via.placeholder.com/150',
                                    previewLink: book.volumeInfo.previewLink,
                                };
                                books.push(bookObj);
                                
                                
                            }
                        }
                    }

                    // Assign the parsed books array to results
                    this.results = books;
                    const resultsJson = JSON.stringify(this.results);

                    



                    // console.log("here is results " + resultsJson);
                    // Navigate to the /results route with the results data as a parameter
                    this.$router.push({ name: 'results', params: { results: resultsJson } });

                } else {
                    throw new Error(`Request failed with status ${response.status}`);
                }

            } catch (error) {
                console.error(error);
            } finally {
                this.showResults = false;
            }
        }
    },
    components: {
        PopUp,
    },

};
</script>
