<template>
  <div
    class="relative isolate overflow-hidden bg-white px-6 py-24 sm:py-32 lg:overflow-visible lg:px-0"
  >
    <div class="absolute inset-0 -z-10 overflow-hidden">
      <svg
        class="absolute left-[max(50%,25rem)] top-0 h-[64rem] w-[128rem] -translate-x-1/2 stroke-gray-200 [mask-image:radial-gradient(64rem_64rem_at_top,white,transparent)]"
        aria-hidden="true"
      >
        <defs>
          <pattern
            id="e813992c-7d03-4cc4-a2bd-151760b470a0"
            width="200"
            height="200"
            x="50%"
            y="-1"
            patternUnits="userSpaceOnUse"
          >
            <path d="M100 200V.5M.5 .5H200" fill="none" />
          </pattern>
        </defs>
        <svg x="50%" y="-1" class="overflow-visible fill-gray-50">
          <path
            d="M-100.5 0h201v201h-201Z M699.5 0h201v201h-201Z M499.5 400h201v201h-201Z M-300.5 600h201v201h-201Z"
            stroke-width="0"
          />
        </svg>
        <rect
          width="100%"
          height="100%"
          stroke-width="0"
          fill="url(#e813992c-7d03-4cc4-a2bd-151760b470a0)"
        />
      </svg>
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
              class="mt-2 text-3xl font-bold tracking-tight text-gray-900 sm:text-4xl"
            >
              Welcome to MoodReads,
            </h1>
            <p class="mt-6 text-xl leading-8 text-gray-700">
              your ultimate destination for finding the perfect book to match
              your mood! Dive into the world of literature and embark on
              unforgettable reading adventures tailored to your preferences.
            </p>
          </div>
        </div>
      </div>
      <div
        class="-ml-12 -mt-12 p-12 lg:sticky lg:top-4 lg:col-start-2 lg:row-span-2 lg:row-start-1 lg:overflow-hidden"
      >
        <img
          class="w-[30rem] max-w-none rounded-xl bg-gray-900 shadow-xl ring-1 ring-gray-400/10 sm:w-[57rem]"
          src="https://res.cloudinary.com/iphurts/image/upload/v1686048664/new_qb7dtu.png"
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
              you'll discover hidden gems, timeless classics, and captivating
              stories that resonate with your current state of mind.
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
                Get personalized book recommendations, explore diverse genres  and let your reading mood guide you to extraordinary books that will leave a lasting impact.
            </p>
            <!-- <h2 class="mt-16 text-2xl font-bold tracking-tight text-gray-900">
              No server? No problem.
            </h2>
            <p class="mt-6">
              Id orci tellus laoreet id ac. Dolor, aenean leo, ac etiam
              consequat in. Convallis arcu ipsum urna nibh. Pharetra, euismod
              vitae interdum mauris enim, consequat vulputate nibh. Maecenas
              pellentesque id sed tellus mauris, ultrices mauris. Tincidunt enim
              cursus ridiculus mi. Pellentesque nam sed nullam sed diam turpis
              ipsum eu a sed convallis diam.
            </p> -->
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
