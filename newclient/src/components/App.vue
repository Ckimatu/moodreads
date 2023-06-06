<template>

    <router-view />
    <NewsLetter />
    <Footer />
    
</template>

<script>
import Footer from './pages/FooterPage.vue'
import NewsLetter from './pages/NewsLetter.vue';

export default {
    components: {
        Footer,
        NewsLetter
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
    background-image: url("../assets/bg.jpg");
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    opacity: 0.9;
  }
}
</style>