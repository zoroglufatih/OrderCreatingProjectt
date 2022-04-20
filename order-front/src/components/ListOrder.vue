<template>

  <h2>List Order</h2>
  
</template>

<script>
    // import axios from 'axios'
export default {
  name: 'AddOrder',
        data() {
            return {

            }
        },
        methods: {
            getAddOrders() {
                // axios.get("https://localhost:44390/Order/AddOrderFill")
                //     .then((response) => {
                //         //this.datas = response.data;
                //         this.datas = [];
                //         this.datas = response.data;
                //         console.log(response.data.productModels);
                //         console.log(this.datas.colors);
                //     })
                //     .catch(function (error) {
                //         alert(error);
                //     });
            }
        },
        mounted() {
            this.getAddOrders();
        }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
