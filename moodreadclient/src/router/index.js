import { createRouter, createWebHistory } from "vue-router";
// import HomePage from "../components/pages/HomePage.vue";
import ResultsPage from "../components/pages/ResultsPage.vue";
import LandingPage from "../components/pages/LandingPage.vue";


const routes = [

    {
        path: "/",
        name: "LandingPage",
        component: LandingPage,
    },
    {
        path: "/home",
        name: "home",
        // component: HomePage,
    },
    {
        path: "/results",
        name: "ResultsPage",
        component: ResultsPage,
        props: (route) => ({ results: route.params.results }),
      },
];

const router = createRouter({
    history: createWebHistory(),
    routes
});


export default router;  // export the router instance
    