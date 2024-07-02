<template>
    <div>
        <b>Подробности блога</b><br/>
        <a>
            {{ "Название: " + this.idtitle}}<br/>
            {{ "Основной текст: " + this.idbody}}
        </a>
        <br/>
        <router-link to="/home"><button><a>Назад</a></button></router-link>
        <router-link to="/home"><button @click="Delete"><a>Удалить пост</a></button></router-link>
    </div>
</template>

<script>
export default {
    name: "BlogDetails-component",
    data(){
        return{
            idtitle: '',
            idbody: '',
            realid: 0,
        }
    },
    props:{
        getresult: Array,
    },
    computed:{
        id(){
            return this.$route.params.id;
        }
    },
    methods:{
        Delete(){
            console.log(this.id)
            this.$emit('Deletepostonclick',this.id)
    },
    },
    mounted(){ 
        this.idtitle = this.getresult.find((element) => element.id == this.id).title;
        this.idbody = this.getresult.find((element) => element.id == this.id).body;
    } 
}
</script>

<style>
a{
    font-size: 20px;
}
</style>