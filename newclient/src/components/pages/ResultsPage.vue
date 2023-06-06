<template>
  <div class=" bg-white border border-gray-200 rounded-lg shadow dark:bg-gray-800 dark:border-gray-700">
    <h1 class="text-xl font-bold text-gray-900 dark:text-white">Book Recommendations</h1>
    <ul class="grid grid-cols-1 gap-3 sm:grid-cols-2 md:grid-cols-4 space-y-6">
      <li v-for="book in books" :key="book.title">
        <a :href="book.previewLink">
          <img class="rounded-t-lg" :src="book.thumbnail" alt="" />
        </a>
        <div class="p-5">
          <a :href="book.previewLink">
            <h5 class="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white">
              {{ book.title }}
            </h5>
          </a>
          <p class="mb-3 text-gray-700 dark:text-gray-400">{{ book.description }}</p>
          <a
            :href="book.previewLink"
            class="inline-flex items-center px-3 py-2 text-sm font-medium text-center text-white bg-blue-700 rounded-lg hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"
          >
            Preview
            <svg
              aria-hidden="true"
              class="w-4 h-4 ml-2 -mr-1"
              fill="currentColor"
              viewBox="0 0 20 20"
              xmlns="http://www.w3.org/2000/svg"
            >
              <path
                fill-rule="evenodd"
                d="M10.293 3.293a1 1 0 011.414 0l6 6a1 1 0 010 1.414l-6 6a1 1 0 01-1.414-1.414L14.586 11H3a1 1 0 110-2h11.586l-4.293-4.293a1 1 0 010-1.414z"
                clip-rule="evenodd"
              ></path>
            </svg>
          </a>
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
