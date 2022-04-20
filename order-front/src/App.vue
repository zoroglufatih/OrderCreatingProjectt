<template>
<div id="nav">
  <router-link to="/">Sipariş Oluştur</router-link>
  <br />
  <router-link to="/listorder">Sipariş Listele</router-link>
</div>
  <router-view/>
</template>

<script>


export default {
  name: 'App'
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 20px;
  margin-left:100px;
  margin-right:100px;
}
</style>
