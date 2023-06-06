<template>
<div class="results">
  <h1>Book Recommendations</h1>
  <ul class="grid grid-cols-1 gap-4 sm:grid-cols-3 max-w-screen-lg mx-auto bg-white border border-gray-200 rounded-lg shadow dark:bg-gray-800 dark:border-gray-700">
    <li v-for="book in books" :key="book.title" class="book">
      <div class="flex items-center">
        <img :src="book.thumbnail" alt="Book cover" class="w-24 h-32 object-cover rounded-lg">
        <div class="ml-4">
          <h3 class="text-lg font-semibold">{{ book.title }}</h3>
          <p class="text-sm">By {{ book.authors.join(", ") }}</p>
          <p class="text-sm">{{ book.description }}</p>
          <a :href="book.previewLink" target="_blank" class="text-blue-500 underline">Preview</a>
        </div>
      </div>
    </li>
  </ul>
</div>

  </template>
  
  <script>
  export default {
    props: {
      results: {
        type: String,
        required: true,
      },
    },
    data() {
      return {
        books: [],
      };
    },
    created() {
      const resultsJson = this.results;
      this.books = JSON.parse(resultsJson);
    },
  };
  </script>
  
  <style scoped>
  .results {
    display: flex;
    flex-direction: column;
    align-items: center;
  }
  
  ul {
    list-style: none;
    padding: 0;
    margin: 0;
  }
  
  li {
    margin: 2rem 0;
    padding: 1rem;
    border: 1px solid gray;
    border-radius: 0.25rem;
    box-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
    width: 80%;
    max-width: 800px;
    display: flex;
  }
  
  img {
    width: 150px;
    height: 225px;
    margin-right: 1rem;
  }
  
  .book h3 {
    font-size: 1rem;
    margin-bottom: 0.5rem;
  }
  
  .book p {
    font-size: 0.8rem;
    margin-bottom: 0.5rem;
  }
  
  .book a {
    font-size: 0.8rem;
    text-decoration: none;
    color: blue;
  }
  </style>