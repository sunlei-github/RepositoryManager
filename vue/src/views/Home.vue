<template>
  <div class="home">
    <el-button type="primary">主要按钮</el-button>
    <img alt="Vue logo" src="../assets/logo.png" />
    <HelloWorld msg="Welcome to Your Vue.js App" />
  </div>
</template>

<script>
import HelloWorld from "@/components/HelloWorld.vue";

export default {
  name: "Home",
  components: {
    HelloWorld
  },
  mounted() {
    console.log(this);
    console.log(this.$axios);
  },
};
</script>
