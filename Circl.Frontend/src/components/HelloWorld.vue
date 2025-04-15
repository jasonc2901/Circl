<template>
  <h1>{{ msg }}</h1>

  <div class="card">
    <button type="button" @click="callApiTest">
      <span v-if="apiResponse === ''">Call API</span>
      <span v-else>{{apiResponse}}</span>
    </button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>
</template>

<style scoped>
.read-the-docs {
  color: #888;
}
</style>

<script setup lang="ts">

import { ref } from 'vue'

// vue 3 way of doing props in ts
defineProps<{ msg: string }>()
    
// we no longer use the data section and instead define variables using ref (similar to react)
const apiResponse = ref('')

// methods are simply just created like so instead of the older (nicer) vue 2 method
const callApiTest = async () => {
  const res = await fetch('http://localhost:5037/api/ping');
  const text = await res.text();
  apiResponse.value = text;
  
  setTimeout(() => {
    apiResponse.value = '';
  }, 1000);
}

</script>
