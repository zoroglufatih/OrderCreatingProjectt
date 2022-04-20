<template>
<div>
  <div class="p-fluid grid formgrid">
      <div class="field col-12 md:col-4">
                <label for="icon">Icon</label>
                <CalendaR id="icon" v-model="date3" :showIcon="true" />
      </div>
      <div class="field col-12 md:col-4">
                <label>Icon</label>
                  <InputText type="text" v-model="value" />

      </div>
  </div>
</div>
  <h2>Add Order</h2>
  <!-- <select v-model="sec">
       <option v-for="product in datas.productModels" :value="product.productId" :key="product.productId"> {{ product.productName }}</option> 
  </select>
  <select v-model="sec">
       <option v-for="color in datas.colors" :value="color.colorId" :key="color.colorId"> {{ color.colorName }}</option> 
  </select> -->
  <br/>
  <br/>
  <DropDown v-model="sec" :options="datas.countries" optionLabel="countryName" optionValue="countryId"></DropDown>
  <CalendeR></CalendeR>
  <DropDown v-model="sec" :options="datas.colors" optionLabel="colorName" optionValue="colorId"></DropDown>
  <!-- <select v-model="sec">
       <option v-for="color in datas.colors" :value="color.colorId" :key="color.colorId"> {{ color.colorName }}</option> 
  </select> -->
</template>

<script>
    import axios from 'axios'
export default {
  name: 'AddOrder',
        data() {
            return {
              sec: 1,
              datas: []

            }
        },
        methods: {
            getAddOrders() {
                axios.get("https://localhost:44390/Order/AddOrderFill")
                    .then((response) => {
                        //this.datas = response.data;
                        this.datas = [];
                        this.datas = response.data;
                        console.log(response.data.productModels);
                        console.log(this.datas.colors);
                    })
                    .catch(function (error) {
                        alert(error);
                    });
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
