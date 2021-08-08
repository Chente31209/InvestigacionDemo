<template>
<h1>
  Pagaina de prestecion 
</h1>
  <div v-if="userLogged">
    <p >User loggued: {{userLogged}}</p>
  </div>

</template>

<script>
import auth from "../logic/ahout";
export default {
  name: "Home",
  computed: {
    userLogged() {
      return auth.getUserLogged();
    }
  }
};
</script>
