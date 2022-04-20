<template>
  <h2>Sipariş Oluştur</h2>
  <form id="add-order" class="grid">
    <div class="col-5">
      <div class="grid">
        <div class="col-12 p-fluid">
          <label>Sipariş Numarası</label>
          <InputNumber
            id="order-number"
            mode="decimal"
            :useGrouping="false"
            type="text"
            v-model="form.orderNumber"
          />
        </div>

        <div class="col-6 p-fluid">
          <label>Ülke</label>
          <Dropdown
            v-model="form.countryId"
            :options="countryList"
            optionLabel="countryName"
            optionValue="countryId"
          ></Dropdown>
        </div>

        <div class="col-6 p-fluid">
          <label for="icon">Termin</label>
          <Calendar id="icon" v-model="form.termin" :showIcon="true" />
        </div>

        <div class="col-6 p-fluid">
          <label>Model</label>
          <Dropdown
            v-model="form.productId"
            :options="productList"
            optionLabel="productName"
            optionValue="productId"
          ></Dropdown>
        </div>
        <div class="col-6 p-fluid">
          <label>Desen</label>
          <Dropdown
            v-model="form.patternId"
            :options="patternList"
            optionLabel="patternName"
            optionValue="patternId"
          ></Dropdown>
        </div>
        <div class="col-6 p-fluid">
          <label>Sezon</label>
          <Dropdown
            v-model="form.seasonId"
            :options="seasonList"
            optionLabel="seasonName"
            optionValue="seasonId"
          ></Dropdown>
        </div>
        <div class="col-6 p-fluid">
          <label>Renk</label>
          <Dropdown
            v-model="form.colorId"
            :options="colorList"
            optionLabel="colorName"
            optionValue="colorId"
          ></Dropdown>
        </div>
      </div>
    </div>

    <div class="col-7">
      <div class="grid">
        <div class="col-12 p-fluid">
          <label>Beden Setleri</label>
          <Dropdown
            @change="onChange"
            v-model="form.sizeSetId"
            :options="sizeSetList"
            optionLabel="sizeSetName"
            optionValue="sizeSetId"
          ></Dropdown>
        </div>
      </div>
      <div class="grid" style="margin-top: 12px">
        <div class="col-3 p-fluid">
          <span style="font-weight: none">Beden</span>
        </div>
        <div class="col-9 p-fluid">
          <span style="font-weight: none">Adet</span>
        </div>
        <div class="col-12 p-fluid">
          <hr style="border-top: 1px dotted gray" />
        </div>
        <!-- <div class="col-3">
          <span style="font-weight: bold">XS</span>
        </div>
        <div class="col-9">
          <InputNumber
            id="vertical"
            v-model="value19"
            mode="decimal"
            showButtons
            buttonLayout="horizontal"
            style="width: 2rem; height: 2rem"
            decrementButtonClass="p-button-secondary"
            incrementButtonClass="p-button-secondary"
            incrementButtonIcon="pi pi-plus"
            decrementButtonIcon="pi pi-minus"/>
        </div> -->
        <ul>
          <li class="col-12" v-for="(size, index) in selectedSizes" :key="size.sizeId">
            <label class="col-3">{{ size.sizeName }}</label>
              <InputNumber
                class="col-9 col-offset-4"
                id="horizontal"
                v-model="this.form.quantities[index]"
                mode="decimal"
                showButtons
                buttonLayout="horizontal"
                style="width: 2rem; height: 3rem"
                decrementButtonClass="p-button-secondary"
                incrementButtonClass="p-button-secondary"
                incrementButtonIcon="pi pi-plus"
                decrementButtonIcon="pi pi-minus"
              />
          </li>
        </ul>
      </div>
      <!-- <div class="grid">
        <div class="col-3 p-fluid"> asdsad<div>
        <div class="col-9 p-fluid"> asdsad<div>
      </div> -->

      <Button label="Sipariş Oluştur" @click="submit" />
    </div>
  </form>
</template>

<script>
import axios from "axios";
import Dropdown from "primevue/dropdown";
import Calendar from "primevue/calendar";
import InputNumber from "primevue/inputnumber";
import Button from "primevue/button";
// import Message from "primevue/message"

export default {
  name: "AddOrder",
  components: {
    Dropdown,
    Calendar,
    InputNumber,
    Button,
  },
  data() {
    return {
      value1: 0,
      colorList: [],
      countryList: [],
      patternList: [],
      productList: [],
      sizeSetList: [],
      seasonList: [],
      sizeList: [],
      sizeSetSizeList: [],
      filterSizeSetSizes: [],
      filterSizes: [],
      selectedSizes: [],
      form: {
        orderNumber: null,
        countryId: 1,
        termin: null,
        productId: 1,
        patternId: 1,
        seasonId: 1,
        colorId: 1,
        sizeSetId: 1,
        sizes: [],
        quantities: []
      },
      //message: null
    };
    // sizes create
  },
  // computed: {
  //   filterSizeSetOk: function(){
  //     return this.filterSizeSetSize()
  //   }
  // },

  methods: {
    submit(){
      console.log(this.form.orderNumber);
      console.log(this.form.countryId);
      console.log(this.form.termin);
      console.log(this.form.productId);
      console.log(this.form.patternId);
      console.log(this.form.seasonId);
      console.log(this.form.colorId);
      console.log(this.form.sizeSetId);
      console.log(this.form.sizes);
      console.log(this.form.quantities);

      axios.post('https://localhost:5001/Order/AddOrder', this.form )
      .then(res => {
         // response
         res.json;
      });

      this.getDatas();
      //this.message = {severity: 'info', content: 'Sipariş başarıyla oluşturuldu.', id: "okey"};

    },
    onChange() {
      this.form.quantities = [];
      this.filterSizeSetSizes = this.filterSizeSetSize();
      this.filterSizes = this.filterSize();
      this.form.sizes = this.filterSize();
      for(var i = 0; i < this.form.sizes.length; i++){
        this.form.quantities.push(0);
      }
      console.log(this.form.quantities)
    },
    getDatas() {
      axios
        .get("https://localhost:5001/Order/ColorList")
        .then((response) => {
          this.colorList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/CountryList")
        .then((response) => {
          this.countryList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/PatternList")
        .then((response) => {
          this.patternList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/productList")
        .then((response) => {
          this.productList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/SizeSetList")
        .then((response) => {
          this.sizeSetList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/SeasonList")
        .then((response) => {
          this.seasonList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/SizeList")
        .then((response) => {
          this.sizeList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
      axios
        .get("https://localhost:5001/Order/SizeSetSizeList")
        .then((response) => {
          this.sizeSetSizeList = response.data;
        })
        .catch(function (error) {
          alert(error);
        });
    },
    filterSizeSetSize: function (values) {
      values = this.sizeSetSizeList;
      return values.filter(
        (sizeSetSize) => sizeSetSize.sizeSetId == this.form.sizeSetId
      );
    },

    filterSize: function (values) {
      values = this.sizeList;
      this.selectedSizes = [];
      for (var i = 0; i < this.filterSizeSetSizes.length; i++) {
        for (var j = 0; j < this.sizeList.length; j++) {
          if (values[j].sizeId == this.filterSizeSetSizes[i].sizeId) {
            this.selectedSizes.push(values[j]);
          }
        }
      }
      return this.selectedSizes;
    },
  },
  mounted() {
    this.getDatas();
  },
};
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
#add-order {
  margin-top: 20px;
}
h2 {
  font-weight: bold;
}
label {
  font-weight: bold;
}
Button {
  position: absolute;
  right: 100px;
}
</style>
