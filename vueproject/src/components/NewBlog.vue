<template>
    <div>
        <b>Новый блог</b><br/>
        <a>Введите название поста: </a>
        <input type="text" v-model="titlepost"/><br/>
        <a>Введите текст поста: </a>
        <input type="text" v-model="bodypost"/><br/>
        <a>Введите свой id: </a>
        <input type="number" v-model="userid"/><br/>
        <button @click="sendInfomation">Создать пост</button>
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
a{
    text-align: 20px;
}
</style>