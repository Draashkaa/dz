<template>
    <div>
        <b>Главная</b>
        <table>
            <tr v-for="element in this.getresult" :key="element">
                <th>
                    <a>{{ element.title }}</a><br/>
                    {{ element.body.slice(0,20) + " ... "}}
                </th>
            </tr>
        </table>
    </div>
</template>

<script>
import axios from "axios"


export default {
    name: "Home-component",
    data(){
        return{
            getresult: Array,
        };
    },

    props:{
        post: Array,
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

};

</script>

<style>
th{
    height: 30px;
    width: 100%;
    text-align: center;
    border: 2px solid black;
    text-overflow: ellipsis;
}
a{
    font-size: 20px;
}

</style>