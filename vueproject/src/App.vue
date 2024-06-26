<template>
    <headerComponent/>
    <router-view @getnewpost="getInfomation" :titlepost="titlepost" :bodypost="bodypost" :userid="userid"/>
</template>

<script>
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
  }
},

methods: {
  getInfomation(titlepost,bodypost,userid){
    this.titlepost = titlepost;
    this.bodypost = bodypost;
    this.userid = userid;
    this.post.push({
      'title':this.titlepost,
      'id': 228,
      'body': this.bodypost,
      'userid': this.userid
    });
  }
},
}
</script>

<style>

</style>
