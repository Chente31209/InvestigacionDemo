<template>
    <nav class="flex justify-between items-center text-gray-900 px-4 shadow-md sm:py-4 sm:justify-around">
            <div class="sm:hidden text-2xl">&equiv;</div>
            <ul class="hidden sm:flex justify-between w-64">
                <li>
                    <router-link  to="/Login" >Login</router-link>
                </li>
                <li>
                     <router-link to="/" >Home</router-link>
                </li>
                <li>
                    <a href="#">Acerca de mi</a>
                </li>
                <li v-if="userLogged">
                    <button @click="logout"
                    class="
                bg-blue-500
                hover:bg-blue-dark
                text-white
                font-bold
                py-2
                px-4
                rounded
              "
              >Salir</button>
                </li>
            </ul>
    </nav>
</template>
<script>
import auth from "../logic/ahout";
export default {
  computed: {
    userLogged() {
      return auth.getUserLogged();
    }
  },
  methods:{
      logout(){
          auth.deleteUserLogged();
          location.reload();
      }
  }
};
</script>
