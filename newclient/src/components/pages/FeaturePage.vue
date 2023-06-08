<template>
  <div
    class="relative isolate overflow-hidden bg-white px-6 py-24 sm:py-2 lg:overflow-visible lg:px-0"
  >
    <div class="absolute inset-0 -z-10 overflow-hidden">
   
    </div>
    <div
      class="mx-auto grid max-w-2xl grid-cols-1 gap-x-8 gap-y-16 lg:mx-0 lg:max-w-none lg:grid-cols-2 lg:items-start lg:gap-y-10"
    >
      <div
        class="lg:col-span-2 lg:col-start-1 lg:row-start-1 lg:mx-auto lg:grid lg:w-full lg:max-w-7xl lg:grid-cols-2 lg:gap-x-8 lg:px-8"
      >
        <div class="lg:pr-4">
          <div class="lg:max-w-lg">
            <p class="text-base font-semibold leading-7 text-indigo-600">
              Unleash Your Reading Potential:
            </p>
            <h1
              class="mt-2 text-xl font-bold tracking-tight text-gray-900 sm:text-4xl"
            >
              Welcome to MoodReads,
            </h1>
            <p class="mt-6 text-lg leading-8 text-gray-700">
              your ultimate destination for finding the perfect book to match
              your mood!
              <br>
              As avid readers ourselves, we understand the struggle of
              finding the ideal book that matches our current mood or desired
              emotional journey. That's why we developed MoodReads - to assist you
              in uncovering the literary gems that resonate with your emotions.
            </p>
          </div>
        </div>
      </div>
      <div
        class="-ml-12 -mt-12 p-12 lg:sticky lg:top-4 lg:col-start-2 lg:row-span-2 lg:row-start-1 lg:overflow-hidden"
      >
        <img
          class="w-full max-w-[30rem] h-auto rounded-xl bg-gray-900 shadow-xl ring-1 ring-gray-400/10 sm:max-w-[57rem]"
          src="https://images.unsplash.com/photo-1573592371950-348a8f1d9f38?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=449&q=80"
          alt=""
        />
      </div>
      <div
        class="lg:col-span-2 lg:col-start-1 lg:row-start-2 lg:mx-auto lg:grid lg:w-full lg:max-w-7xl lg:grid-cols-2 lg:gap-x-8 lg:px-8"
      >
        <div class="lg:pr-4">
          <div class="max-w-xl text-base leading-7 text-gray-700 lg:max-w-lg">
            <p>
               
              With our innovative book recommendation system powered by OpenAI,
              you'll dive into a curated collection of hidden gems, timeless classics,
              and captivating stories that truly speak to your state of mind.
              Experience the joy of personalized book recommendations like never before
              as you explore new literary horizons.
            </p>
            <ul role="list" class="mt-8 space-y-8 text-gray-600">
              <li class="flex gap-x-3">
                <CloudArrowUpIcon
                  class="mt-1 h-5 w-5 flex-none text-indigo-600"
                  aria-hidden="true"
                />
                <span
                  ><strong class="font-semibold text-gray-900"
                    >Tailored Recommendations:</strong
                  >
                  Whether you're seeking a thought-provoking novel or an
                  adrenaline-pumping page-turner, we'll help you discover your
                  next literary obsession.
                </span>
              </li>
              <li class="flex gap-x-3">
                <LockClosedIcon
                  class="mt-1 h-5 w-5 flex-none text-indigo-600"
                  aria-hidden="true"
                />
                <span
                  ><strong class="font-semibold text-gray-900"
                    >Mood-Based Filtering.</strong
                  >
                  Sometimes, it's not just about the genre, but the mood you're in. With MoodReads, you can easily filter books based on specific emotions, such as uplifting, mysterious, nostalgic, or thought-provoking.</span
                >
              </li>
              <li class="flex gap-x-3">
                <ServerIcon
                  class="mt-1 h-5 w-5 flex-none text-indigo-600"
                  aria-hidden="true"
                />
                <span
                  ><strong class="font-semibold text-gray-900"
                    >Book Details and Descriptions.</strong
                  >
                  Get a glimpse into the storyline, themes, and writing style to ensure the book aligns with your interests. </span
                >
              </li>
            </ul>
            <p class="mt-8">
              Say goodbye to the frustration of endlessly searching for the right book and say hello to MoodReads, your personalized gateway to a world of tailored reading experiences.
            </p>
            <!--  -->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import {
  CloudArrowUpIcon,
  LockClosedIcon,
  ServerIcon,
} from "@heroicons/vue/20/solid";
</script>
