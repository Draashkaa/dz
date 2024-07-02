<template>
    <div>
        <b>Главная</b>
        <table>
            <tr v-for="element in getresult" :key="element">
            <RouterLink :to="{path:`/post/${element.id}`}">
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
    },


};

</script>

<style>
b{
    font-size: 30px;
    text-align: center;
    font-family:DejaVu Sans Mono, monospace;
}
table{
    height: 100%;
    width: 100%;
    text-align: center;
    text-overflow: ellipsis;
}
th{
    color:rgb(41, 40, 40);
    height: 30px;
    width: 10000px;
    text-align: center;
    text-overflow: ellipsis;
}
a{
    font-size: 20px;
}

</style>