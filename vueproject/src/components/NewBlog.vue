<template>
    <div>
    <table>
        <th><b>Новый блог</b><br/>
        <a>Введите название поста: </a>
        <input type="text" v-model="titlepost"/><br/>
        <a>Введите текст поста: </a>
        <input type="text" v-model="bodypost"/><br/>
        <a>Введите свой id: </a>
        <input type="number" v-model="userid"/><br/>
        <router-link to="/home"><button @click="sendInfomation"><a>Создать пост</a></button></router-link></th>
    </table>
    </div>
</template>

<script>

export default {
    name: "NewBlog-component",
    data(){
        return{
            titlepost:'',
            bodypost:'',
            userid:'',
        };
    },
    
    
    methods:{
        sendInfomation() {
            this.$emit('getnewpost', this.titlepost, this.bodypost,  this.userid); 

        },
    },
};
</script>

<style>
th{
    text-align: center;
    text-overflow: ellipsis;
    border: 2px;
    border-color: black;
}
a{
    font-size: 30px;
    text-align: center;
}
</style>