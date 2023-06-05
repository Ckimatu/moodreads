<template>
  <div>
    <HeaderVue />
    <HeroVue />

    <!-- Display the result data -->
    <div class="results-container" v-if="showResults">
      <h2>Results</h2>
      <ul>
        <li v-for="(book, index) in results.slice(0, 5)" :key="index">
          <div class="book-thumbnail">
            <img :src="book.thumbnail" alt="Book thumbnail" />
          </div>
          <div class="book-details">
            <h3>{{ book.title }}</h3>
            <p v-if="book.authors">By {{ book.authors.join(", ") }}</p>
            <!-- <p v-if="book.description">{{ book.description }}</p> -->
            <a :href="book.previewLink" target="_blank">Preview</a>
          </div>
        </li>
      </ul>
    </div>
    <!-- End of result section -->
  </div>
</template>


<script>
import HeaderVue from "./components/HeaderVue.vue";
import HeroVue from "./components/HeroVue.vue";

export default {
  name: "App",
  components: {
    HeaderVue,
    HeroVue
  },
  methods: {
    handleResults(results) {
      // Access and handle the results received from the child component
      console.log(results);
    },
  },
};
</script>

<style>
@tailwind base;
@tailwind components;
@tailwind utilities;

@layer base {
  body {
    @apply text-white;
    background-image: url("../src/assets/bg.jpg");
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    opacity: 0.9;
  }
}
</style>
