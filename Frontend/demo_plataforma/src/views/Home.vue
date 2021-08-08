<template>
<h1>
  Pagaina de prestecion 
</h1>
<p v-if="userLogged">User loggued: {{userLogged}}</p>
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
