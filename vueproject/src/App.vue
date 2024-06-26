<template>
    <headerComponent/>
    <router-view @getnewpost="getInfomation" :getresult="getresult" :post="post"/>
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
    post: [],
    getresult: Array,
    
  }
},

methods: {
  getInfomation(titlepost,bodypost,userid){
    this.titlepost = titlepost;
    this.bodypost = bodypost;
    this.userid = userid;
    this.post.splice(0,0,{
      'title':this.titlepost,
      'id': this.post.length + 101,
      'body': this.bodypost,
      'userid': this.userid
    });
  }
},

async mounted(){
        try {
            const response = await axios.get('https://jsonplaceholder.typicode.com/posts');
            this.getresult=response.data;
            if (this.post != null){
                this.getresult = this.post.concat(this.getresult);
            }
        }
            catch (error) {
            console.error("Axios error: ", error);
        }  
    }
}
</script>

<style>

</style>
