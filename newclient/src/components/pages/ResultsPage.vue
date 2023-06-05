<template>
    <div class="results">
      <h1>Book Recommendations</h1>
      <ul>
        <li v-for="book in books" :key="book.title" class="book">
          <img :src="book.thumbnail" alt="Book cover" />
          <div>
            <h3>{{ book.title }}</h3>
            <p>By {{ book.authors.join(", ") }}</p>
            <p>{{ book.description }}</p>
            <a :href="book.previewLink" target="_blank">Preview</a>
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