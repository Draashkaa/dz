import {createRouter, createWebHistory} from 'vue-router'
import home from "@/components/home.vue"
import NewBlog from "@/components/NewBlog.vue"
import BlogDetails from "@/components/BlogDetails.vue"

const routes =[
    {
        path: "/home",
        component: home,
    },
    {
        path: "/NewBlog",
        component: NewBlog,
    },
    {
        path: "/BlogDetails",
        component: BlogDetails,
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

export default router;