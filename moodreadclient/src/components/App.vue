<template>
  <Header />
  <router-view />
  <Footer />
</template>

<script>

import Header from '../components/pages/NavBar.vue'
import Footer from '../components/pages/footerPage.vue'

export default {
  components: {

    Header,
    Footer
  }
} 
</script>


<style>
@tailwind base;
@tailwind components;
@tailwind utilities;

@layer base {
  body {
    @apply text-white;
    /* background-color: black; */
    background-image: url("../assets/bg.jpg");
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    opacity: 1;
  }
}
</style>