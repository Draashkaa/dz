<template>
    <div>
        <b>Подробности блога</b><br/>
        <a>
            {{ "Название: " + this.idtitle }}<br/>
            {{ "Основной текст: " + this.idbody }}
        </a>
    </div>
</template>

<script>
export default {
    name: "BlogDetails-component",
    data(){
        return{
            idtitle: '.',
            idbody: '',
            element: 0,

        }
    },
    props:{
        getresult: Array,
        post: Array,
    },
    mounted(){
        if (this.$route.params.id>100){
            for (this.element in this.post)
                if (this.element == this.$route.params.id - 1)
                    console.log(this.post[this.element].title,this.idtitle);
                    this.idbody = this.post[this.element].body;
                    console.log(this.post);
                    this.idtitle = this.post[this.element].title;
                } else {
                    for (this.element in this.getresult)
                        if (this.element == this.$route.params.id - 1)
                            this.idtitle = this.getresult[this.element].title;
                            console.log(this.element);
                            this.idbody = this.getresult[this.element].body;
                }
    }
}
</script>

<style>
a{
    font-size: 20px;
}
</style>