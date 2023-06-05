<template>
  <div>
    <div class="results-container" @results="handleResults">

      <form @submit.prevent="submitForm">
        <label for="default-search" class="mb-2 text-sm font-medium text-gray-900 sr-only dark:text-white">Search</label>
        <div class="relative">
          <div class="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
            <svg aria-hidden="true" class="w-5 h-5 text-gray-500 dark:text-gray-400" fill="none" stroke="currentColor"
              viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
                d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"></path>
            </svg>
          </div>
          <input type="search" id="default-search"
            class="block w-full p-4 pl-10 text-sm text-black border border-gray-300 rounded-lg bg-gray-50 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-900 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
            placeholder="a whimsical book filled with charming characters" required v-model="recommendation" />
          <button type="submit"
            class="text-white absolute right-2.5 bottom-2.5 bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-4 py-2 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
            Search
          </button>
        </div>
      </form>
    </div>

    <!-- Display the result data -->
    <div class="results-container"></div>
    <div class="results" v-if="showResults">
      <h2>Results</h2>
      <ul>
        <li v-for="(book, index) in results.slice(0, 3)" :key="index">
          <div class="book-thumbnail">
            <img :src="book.thumbnail" alt="Book thumbnail" />
          </div>
          <div class="book-details">
            <h3>{{ book.title }}</h3>
            <p v-if="book.authors">By {{ book.authors.join(', ') }}</p>
            <!-- <p v-if="book.description">{{ book.description }}</p> -->
            <a :href="book.previewLink" target="_blank">Preview</a>
          </div>
        </li>
      </ul>
    </div>
  </div>
  <!-- End of result section -->
</template>

<script>
export default {
  data() {
    return {
      recommendation: '',
      showResults: false,
      results: [],
    };
  },
  methods: {
    async submitForm() {
      const apiUrl = 'http://127.0.0.1:5221/api/BookRecommendations';

      try {
        const response = await fetch(apiUrl, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(this.recommendation),
        });

        if (response.ok) {
          const responseData = await response.json();
          console.log(responseData) // Handle the response data as needed
          // Extract the book details from the response data
          const books = [];
          for (const item of responseData) {
            for (const book of item.items) {
              const bookObj = {
                title: book.volumeInfo.title,
                authors: book.volumeInfo.authors,
                description: book.volumeInfo.description,
                thumbnail: book.volumeInfo.imageLinks?.thumbnail,
                previewLink: book.volumeInfo.previewLink,
              };
              books.push(bookObj);
              console.log("here is book " + bookObj);
            }
          }


          this.results = books; // Assign the parsed books array to results
          this.showResults = true; // Show the result section
          //  passing the results to HeroVue.vue
          this.$emit('results', this.results);
          
        } else {
          throw new Error(`Request failed with status ${response.status}`);
        }

      } catch (error) {
        console.error(error);
      }

    },
    handleResults(results) {
      // Do something with the results in the parent component
      console.log(results);
    }

  },

};
</script>