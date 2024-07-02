<template>
    <div>
        <h1><router-link to="/home"><button><a>Главная</a></button></router-link>
        <router-link to="/NewBlog"><button><a>Новый блог</a></button></router-link></h1>
    </div>
</template>
<script>
export default {
    name: "headerComponent",
}
</script>
<style>
button{
    background-color:rgba(123, 230, 206, 0.637);
    border-radius: 10px;
}
    a {
    font-family:DejaVu Sans Mono, monospace;
    color:rgb(41, 40, 40);
    height: 30px;
    width: 200px;
    text-align: center;
    text-overflow: ellipsis;
    font-size: 22px;
    text-decoration: none;
}
</style>