import { createApp } from 'vue'
import App from './App.vue'
import router from './router'

import PrimeVue from 'primevue/config'

import "primeflex/primeflex.css"
// import Dropdown from 'primevue/dropdown';
// import InputText from 'primevue/inputtext';
// import Calendar from 'primevue/calendar';

import 'primevue/resources/themes/saga-blue/theme.css'       //theme
import 'primevue/resources/primevue.min.css'                 //core css
import 'primeicons/primeicons.css'                           //icons

const app = createApp(App);
app.use(PrimeVue)
app.use(router)
// app.component('DropDown', Dropdown)
// app.component('InputText', InputText)
// app.component('CalendaR', Calendar)


app.mount('#app')
