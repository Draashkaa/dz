<template>
    <div>
        <b>Главная</b>
        <table>
            <tr v-for="element in this.post" :key="element">
                <RouterLink :to="{path:`/post/${element.id}`, query: {id: element.id}}">
                <button>
                <th>
                    <a>{{ element.title}}</a><br/>
                    {{ element.body.slice(0,20) + " ... "}}
                </th>
                </button>
                </RouterLink>
            </tr>
            <tr v-for="element in this.getresult" :key="element">
            <RouterLink :to="{path:`/post/${element.id}`, query: {id: element.id}}">
                <button>
                    <th>
                    <a>{{ element.title }}</a><br/>
                    {{ element.body.slice(0,20) + " ... "}}
                </th>
                </button>
            </RouterLink>
            </tr>
        </table>
    </div>
</template>

<script>



export default {
    name: "Home-component",
    props:{
        getresult: Array,
        post: Array,
    }


};

</script>

<style>
table{
    height: 100%;
    width: 100%;
    text-align: center;
    border: 2px solid black;
    text-overflow: ellipsis;
}
th{
    height: 30px;
    width: 10000px;
    text-align: center;
    border: 2px solid black;
    text-overflow: ellipsis;
}
a{
    font-size: 20px;
}

</style>