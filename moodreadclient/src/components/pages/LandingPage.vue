<template>
  <div class="text-red">
    <!-- Search Section -->
    <div class="relative isolate px-6 mt-10 mb-20 pb-11 lg:px-8">
      <div class="mx-auto max-w-2xl py-5 sm:py-20 lg:py-36">
        <div class="hidden sm:mb-8 sm:flex sm:justify-center"></div>
        <div class="text-center">
          <!-- Heading -->
          <h1 class="text-4xl font-bold tracking-tight text-green sm:text-6xl mt-14">
            Find the perfect book to match your mood!
          </h1>

          <!-- Description -->
          <p class="mt-6 text-lg leading-8 text-gray-300">
            What are you in the mood for? <br />
            Don't be afraid to get creative with your descriptions - the more details you provide, the better we can match
            you with a book you'll love.
          </p>

          <!-- Search form -->
          <div class="mt-10 items-center justify-center">
            <form @submit.prevent="submitSearch">
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
                  placeholder="a whimsical book filled with charming characters" v-model="searchQuery" required />
                <button type="submit"
                  class="text-white absolute right-2.5 bottom-2.5 bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-4 py-2 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
                  Search
                </button>
              </div>
            </form>
            <!-- Conditionally display the PopUp component -->
            <Pop v-if="showPopUp" />
          </div>
        </div>
      </div>
    </div>
    <Feature />
    <CTA />
  </div>
</template>



<script>
import Feature from "./FeaturePage.vue";
import CTA from "./CtaPage.vue";
import Pop from "./PopUp.vue";

export default {
  name: "LandingPage",
  components: {
    Feature,
    CTA,
    Pop,
  },
  

data() {
    return {
      searchQuery: "",
      showPopUp: false, // Initialize the popup flag
    };
  },
    methods: {
    submitSearch() {
      fetch(`https://moodreadapi.azurewebsites.net/BookDetails/${this.searchQuery}`, {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
        },
      })
        .then(async (response) => await response.json())
        .then((data) => {
          // store the data in local storage
          localStorage.setItem("data", JSON.stringify(data));

          // Redirect to the results page
          this.$router.push("/results");
        })
        .catch((error) => {
          // Handle any errors
          console.error(error);
        });
        // Set showPopUp to true after submitting mood
      this.showPopUp = true;
    },
    
  },
  
};
</script>
