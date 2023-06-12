<template>
  <div class="min-h-screen w-screen sm: pb-19 ">
    <div class="relative  isolate px-6  mt-10 mb-20 pb-11 lg:px-8">
      <!-- <div -->
        <!-- class="absolute inset-x-0 -top-30 -z-10 transform-gpu overflow-hidden blur-3xl sm:-top-80" -->
        <!-- aria-hidden="true" -->
      <!-- > -->
        <!-- </div>   -->
      <div class="mx-auto max-w-2xl py-32 sm:py-48 lg:py-56">
        <div class="hidden sm:mb-8 sm:flex sm:justify-center"></div>
        <div class="text-center">

          <!-- Heading -->
          <h1
            class="text-4xl font-bold tracking-tight text-gray-200 sm:text-6xl"
          >
            Find the perfect book to match your mood!
          </h1>

          <!-- Description -->
          <p class="mt-6 text-lg leading-8 text-gray-400">
            <span className="text-blue-300 text-bold"
              >From Classics to Hidden Treasures, </span
            >Unleash Your Reading Potential with Tailored Book Suggestions
            Powered by OpenAI .
          </p>
          
          <!-- CTA Buttons -->
          <div class="mt-10 flex items-center justify-center gap-x-6">
            <a
              href="/home"
              class="rounded-md bg-indigo-600 px-3.5 py-2.5 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
              >Get Recommendations</a
            >
            <!-- <a href="#" class="text-sm font-semibold leading-6 text-gray-900">Learn more <span aria-hidden="true">→</span></a> -->
          </div>
        </div>
      </div>
    </div>

    <!-- About Section -->
    <div id="about">
      <Features />
    </div>

    <!-- Call to Action Section -->
    <CTA />

    <!-- Newsletter Section -->
    <Newsletter />

    <!-- Footer Section -->
    <FooterPage />
  </div>
</template>

<script setup>
import Features from "./FeaturePage.vue";
import CTA from "./CtaPage.vue";
import Newsletter from "./NewsLetter.vue";
import FooterPage from "./FooterPage.vue";
</script>
