import { createRouter, createWebHistory } from "vue-router";
import HomePage from "../components/pages/HomePage.vue";
import ResultsPage from "../components/pages/ResultsPage.vue";

const routes = [

    {
        path: "/",
        name: "Home",
        component: HomePage
    },
    {
        path: "/results",
        name: "results",
        component: ResultsPage,
        props: (route) => ({ results: route.params.results }),
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});


export default router;  // export the router instance
    