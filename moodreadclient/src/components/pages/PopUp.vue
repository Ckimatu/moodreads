<template>
    <div class="popup-overlay ">
      <div class="popup bg-gray-500">
        <div class="popup-content">
          <h5 class="text-2xl font-bold tracking-tight text-gray-00  mb-4">Hello Buddy</h5>
          <p class="text-gray-700 dark:text-gray-300">We understand that anticipation is high, and we want to ensure that your reading experience is exceptional. So sit back, relax, and let us do the hard work for you.</p>
          
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: "PopUp",
    methods: {
      closePopup() {
        this.$emit("close");
      },
    },
  };
  </script>
  
  <style scoped>
  .popup-overlay {
    position: fixed;
    inset: 0;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: rgba(0, 0, 0, 0.5);
    z-index: 9999;
  }
  
  .popup {
    max-width: 400px;
    padding: 2rem;
    background-color: rgba(65, 53, 31, 0.943);
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    text-align: center;
  }
  </style>
  