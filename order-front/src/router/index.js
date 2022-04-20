import { createWebHistory, createRouter } from "vue-router";
import ListOrder from "../components/ListOrder.vue";
import AddOrder from "../components/AddOrder.vue";

const routes = [
    {
        path: "/",
        name: "AddOrder",
        component: AddOrder
    },
    {
        path: "/ListOrder",
        name: "ListOrder",
        component: ListOrder
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
});

export default router;