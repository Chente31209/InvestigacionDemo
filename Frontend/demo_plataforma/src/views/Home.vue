<template>
  <div v-if="userLogged">
    <p>User loggued: {{userLogged}}</p>
  </div>
  <div class="grid grid-rows-2">
    <div>
      
    </div>
    <div class="grid grid-rows-3">
      <div>Micion </div>
      <div>Vicion</div>
      <div>Valores</div>
      
    </div>
  </div>

</template>

<script>
import auth from "../logic/ahout";
export default {
  name: "Home",
  components:{
    
  },
  computed: {
    userLogged() {
      return auth.getUserLogged();
    }
  },
};
</script>
