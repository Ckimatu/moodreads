<template>
  <div class="bg-gray-100 min-h-screen py-10">
    <h1 class="text-3xl font-bold mb-8 text-center text-gray-800">Your recommendations</h1>
    <ul class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
      <li v-for="book in books" :key="book.title" class="bg-white rounded-lg shadow-md p-8 mx-2 my-4 hover:shadow-lg transition-shadow flex">
        <div class="flex-shrink-0 flex justify-center">
          <img :src="book.thumbnail" alt="Book Cover" class="w-32 h-48 object-contain rounded-md shadow-md" />
        </div>
        <div class="flex-grow mt-4 ml-4">
          <h2 class="text-lg font-semibold text-gray-800">{{ book.title }}</h2>
          <p class="mt-2 text-sm text-gray-600">{{ book.authors?.join(", ") }}</p>
          <div class="mt-4 text-sm text-gray-600 flex flex-wrap">
            <div class="flex items-center mr-4">
              <span class="font-semibold">Pages:</span>
              <span class="ml-1">{{ book.pageCount }}</span>
            </div>
            <div class="flex items-center mr-4">
              <span class="font-semibold">Published:</span>
              <span class="ml-1">{{ book.publishedDate }}</span>
            </div>
            <div class="flex items-center">
              <span class="font-semibold">Publisher:</span>
              <span class="ml-1">{{ book.publisher }}</span>
            </div>
            <!-- Add more details as needed using the same pattern -->
          </div>
          <div class="mt-4 text-center">
            <a :href="book.previewLink" target="_blank" class="inline-block px-6 py-3 text-white bg-blue-500 rounded-md hover:bg-blue-600 transition-all ease-in-out">
              Preview Book
            </a>
          </div>
        </div>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "ResultsPage",
  data() {
    return {
      books: [],
    };
  },
  created() {
    const data = localStorage.getItem("data");
    if (data) {
      const parsedData = JSON.parse(data);
      this.books = parsedData.data;

      // Sort books by averageRating in descending order
      this.books.sort((a, b) => b.averageRating - a.averageRating);
    }
  },
};
</script>

<style>
/* Add any custom styles here */
</style>
