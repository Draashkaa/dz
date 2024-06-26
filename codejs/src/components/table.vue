<template>
    <CellsComponent :inputnumber="number"/>
    <button @click="IncrementValuesPlus">Плюс один</button>
    <button @click="IncrementValuesMinus">Минус один</button>
    <div>
        <table>
            <tr>
                <th scope ="col">Умнажается и делится на</th>
                <th scope = "colgroup" v-for="element in numbers" :key="element">
                    {{ element }}
                </th>
            </tr>
            <tr>
                <th scope = "colgroup">Результат Умножения</th>
                <th scope = "colgroup" v-for="element in numbers" :key="element">
                    {{ inputnumber*element }}
                </th>
            </tr>
            <tr>
                <th scope = "colgroup">Результат Деления</th>
                <th scope = "colgroup" v-for="element in numbers" :key="element">
                    {{ (inputnumber/element).toFixed(3) }}
                </th>
            </tr>
        </table>
    </div>
</template>

<script>
import CellsComponent from "@/components/cells.vue"

export default {
    name: "TableComponent",
    components: {CellsComponent},
    data(){
        return{
            numbers: [1,2,3,4,5,6,7,8,9,10]
        }
    },

    props:{
        inputnumber: Number
    },

    methods: {
        IncrementValuesPlus(){
            for(let i = 0; i<10; i++){
            this.numbers[i]++;
            }
        },
        IncrementValuesMinus(){
            for(let i = 0; i<10; i++){
            this.numbers[i]--;
            }
        }
    }
}
</script>

<style scoped>
    th{
        width: 50px;
        height: 50px;
        border: 2px solid black;
    }
    td{
        width: 50px;
        height: 50px;
        border: 2px solid black;
    }
</style>