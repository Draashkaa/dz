<template>
    <input type="number" v-model="number"/>
    <TableComponent :inputnumber="number"/>
</template>

<script>
import TableComponent from "@/components/table.vue"

export default {
  name: 'App',
  components: {TableComponent},
  data(){
    return {
      number: 0,
    }
  }
}
</script>

<style>
</style>