<template>

    <router-view />
    
</template>

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