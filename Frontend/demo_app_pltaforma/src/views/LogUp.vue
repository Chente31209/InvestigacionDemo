<template>
<div class="container">
    <form @submit.prevent="LogUp">
        <div class="row">
            <div class="col">
                <label >Nombre(s)</label>
                <input type="text" name="Nombre" id="Nombre"  class="form-control" v-model="nombre">
            </div>
            <div class="col">
                <label >Primer Apellido</label>
                <input type="text" name="1APellido" id="" class="form-control" v-model="primerApellido">
            </div>
            <div class="col">
                <label >Segundo Pallido</label>
                <input type="text" name="2Apellido" id="" class="form-control" v-model="segundoApellido">
            </div>
        </div>
        <div class="row">
            <div>
                <label >Nombre De Usario</label>
                <input type="text" name="IdUsario" id="" class="form-control" v-model="nombreDeUsuario">
            </div>
        </div>
        <div class="row">
            <div>
                <label >Correo Electonico</label>
                <input type="email" name="email" class="form-control" v-model="e_Mail">
            </div>
        </div>
        <div class="row">
            <div class="col">
                <label >Paswird</label>
                <input type="password" name="Pasword" id="" class="form-control" v-model="pasword">
            </div>
            <div class="col">
                <label >Confima Paswird</label>
                <input type="password" name="Pasword" id="" class="form-control" v-model="paswordCofirma">
            </div>
        </div>
        <div class="row">
            <div class="col">
                <button type="submit" class="btn btn-primary">Reguistrse</button>
            </div>
        </div>
    </form>
</div>
</template>
<script>
import ahout from "../logic/ahout";
export default {
    data:()=>({
    nombre : "",
    primerApellido : "",
      segundoApellido : "",
      nombreDeUsuario : "",
      e_Mail : "",
      pasword : "",
      paswordCofirma : ""
    }),
    methods:{
        async LogUp(){
            try {
                if(this.pasword == this.paswordCofirma){
                    const New =ahout.LogUp(this.nombre,this.primerApellido,this.segundoApellido,this.nombreDeUsuario,this.e_Mail,this.pasword);
                    console.log(New);
                    this.$router.push("/login");
                }
                
                else{
                    alert("Las Contraseñas No Considen ");
                }
            } catch (error) {
                console.log(error);
                this.error = true;
             }   
        }
    }
}
</script>