<template>
    <headerComponent/>
    <router-view @getnewpost="getInfomation" @Deletepostonclick="Deletepost" :getresult="getresult"/>
</template>

<script>
import axios from "axios"
import headerComponent from "@/components/header.vue"


export default {
  name: 'App',
  components: {headerComponent},
  

data(){
  return{
    titlepost:'',
    bodypost:'',
    userid:'',
    getresult: Array,
  }
},

methods: {
  getInfomation(titlepost,bodypost,userid){
    this.titlepost = titlepost;
    this.bodypost = bodypost;
    this.userid = userid;
    this.getresult.unshift({
      'title':this.titlepost,
      'id': Math.max(...this.getresult.map(o => o.id)) + 1,
      'body': this.bodypost,
      'userid': this.userid
    });
  },
  Deletepost(id){
    console.log(id);
    this.getresult = this.getresult.filter((p) => p.id != id);
    console.log(this.getresult.find((p) => p.id == id))
    console.log(this.getresult);
  }
},



async mounted(){
        try {
            const response = await axios.get('https://jsonplaceholder.typicode.com/posts');
            this.getresult=response.data;
        }
            catch (error) {
            console.error("Axios error: ", error);
        }  
    },
}
</script>

<style>

</style>
