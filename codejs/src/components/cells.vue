<template>
    <div>
        <table>
            <tr>
                <th>Квадрат числа</th>
                <td>
                    {{ inputnumber*inputnumber }}
                </td>
            </tr>
            <tr>
                <th>Корень из числа</th>
                <td>
                    {{ Math.sqrt(inputnumber).toFixed(3) }}
                </td>
            </tr>
        </table>    
    </div>
</template>

<script>


export default {
    name: "CellsComponent",
    data (){
    },
    props:{
        inputnumber: Number
    }
}
</script>

<style>
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