<!--
  This requires some changes to your config:
  
  ```
  // tailwind.config.js
  module.exports = {
    // ...
    plugins: [
      // ...
      require('@tailwindcss/forms'),
    ],
  }
  ```
-->
<template>
    <div class="relative isolate overflow-hidden bg-gray-900 py-16 sm:py-24 lg:py-32">
      <div class="mx-auto max-w-7xl px-6 lg:px-8">
        <div class="mx-auto grid max-w-2xl grid-cols-1 gap-x-8 gap-y-16 lg:max-w-none lg:grid-cols-2">
          <div class="max-w-xl lg:max-w-lg">

            <!-- Newsletter Heading -->
            <h2 class="text-3xl font-bold tracking-tight text-white sm:text-4xl">Subscribe to our newsletter.</h2>

            <!-- Newsletter Description -->
            <p class="mt-4 text-lg leading-8 text-gray-300">Subscribe to our newsletter and stay up-to-date with the latest book recommendations, literary news, and exclusive offers from MoodReads!</p>
            
            <!-- Email Subscription Form -->
            <div class="mt-6 flex max-w-md gap-x-4">
              <label for="email-address" class="sr-only">Email address</label>
              <input id="email-address" name="email" type="email" autocomplete="email" required="" class="min-w-0 flex-auto rounded-md border-0 bg-white/5 px-3.5 py-2 text-white shadow-sm ring-1 ring-inset ring-white/10 focus:ring-2 focus:ring-inset focus:ring-indigo-500 sm:text-sm sm:leading-6" placeholder="Enter your email" />
              <button type="submit" class="flex-none rounded-md bg-indigo-500 px-3.5 py-2.5 text-sm font-semibold text-white shadow-sm hover:bg-indigo-400 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-500">Subscribe</button>
            </div>
          </div>

          <!-- Newsletter Benefits -->
          <dl class="grid grid-cols-1 gap-x-8 gap-y-10 sm:grid-cols-2 lg:pt-2">
            <div class="flex flex-col items-start">
              <div class="rounded-md bg-white/5 p-2 ring-1 ring-white/10">
                <CalendarDaysIcon class="h-6 w-6 text-white" aria-hidden="true" />
              </div>
              <dt class="mt-4 font-semibold text-white">Weekly articles</dt>
              <dd class="mt-2 leading-7 text-gray-400"> We are committed to delivering a newsletter that is informative, engaging, and respectful of your time and personal space.</dd>
            </div>
            <div class="flex flex-col items-start">
              <div class="rounded-md bg-white/5 p-2 ring-1 ring-white/10">
                <HandRaisedIcon class="h-6 w-6 text-white" aria-hidden="true" />
              </div>
              <dt class="mt-4 font-semibold text-white">No spam</dt>
              <dd class="mt-2 leading-7 text-gray-400">We value your privacy and understand the importance of maintaining a clutter-free inbox.</dd>
            </div>
          </dl>
        </div>
      </div>
    </div>
  </template>
  
  <script setup>
  import { CalendarDaysIcon, HandRaisedIcon } from '@heroicons/vue/24/outline'
  </script>
