<template>
    <Header />

    <router-view />
    
    <Footer />
    
</template>

<script>
import Footer from './pages/FooterPage.vue'
import Header from './pages/HeaderPage.vue'

export default {
    components: {
        Footer,
        Header
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
    background-color: black;
    background-image: url("../assets/bg.jpg");
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    opacity: 0.9;
  }
}
</style>