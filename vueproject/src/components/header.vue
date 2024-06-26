<template>
    <div>
        <router-link to="/home"><button><a>Главная</a></button></router-link>
        <router-link to="/NewBlog"><button><a>Новый блог</a></button></router-link>
    </div>
</template>
<script>
export default {
    name: "headerComponent",
}
</script>
<style>
    a {
    font-size: 22px;
    text-align: center;
    text-decoration: none;
}
</style>