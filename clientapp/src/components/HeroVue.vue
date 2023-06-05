<template>
  <div>
    <div class="flex justify-center items-center h-screen">
      <div class="bg-black rounded-lg p-10  ">
        <h3>{{ state.message }}</h3>
        <h1 class="text-4xl font-bold tracking-tight text-br sm:text-4xl">Find the perfect book to match your mood</h1>
        <p class="mt-6 text-lg leading-8 text-gray-300">What are you in the mood for? <br> Don't be afraid to get creative
          with your descriptions - the more details you provide, the better we can match you with a book you'll love.</p>
        <div class="mt-10">
          <SearchBar />
        </div>

      </div>

    </div>

  </div>
</template>

<script>
import SearchBar from './SearchBar.vue';

// i need to acces results from searchbar.vue

export default {
  components: {
    SearchBar,
  },
  data() {
    return {
      state: {
        message: 'Welcome to BookWorm!',
      },
    };
  },

 
};

</script>