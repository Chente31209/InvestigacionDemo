<template>
  <div class="grid grid-cols-3">
    <div></div>
    <div class="grid grid-rows-3">
      <div></div>
      <div>
        <form @submit.prevent="login">
          <div>
            <div>
              <label
                class="block text-grey-darker text-sm font-bold mb-2"
                for=""
                >Nombre de Usuario</label
              >
              <input
                class="
                  shadow
                  appearance-none
                  border
                  rounded
                  w-full
                  py-2
                  px-3
                  text-grey-darker
                "
                type="text"
                required
                placeholder="Nombre de Usuario"
                v-model="nombreDeUsarioOEmail"
              />
            </div>
            <div class="py-3">
              <label
                class="block text-grey-darker text-sm font-bold mb-2"
                for=""
                >Password</label
              >
              <input
                class="
                  shadow
                  appearance-none
                  border
                  rounded
                  w-full
                  py-2
                  px-3
                  text-grey-darker
                "
                type="password"
                required
                placeholder="Password"
                v-model="password"
              />
            </div>
          </div>
          <p v-if="error" class="error">
            Has introducido mal el email o la contraseña.
          </p>
          <div class="py-3">
            <button
              type="submit"
              value="Login"
              class="
                bg-blue-500
                hover:bg-blue-dark
                text-white
                font-bold
                py-2
                px-4
                rounded
              "
            >
              Entrar
            </button>
          </div>
        </form>
      </div>
      <div></div>
    </div>
    <div></div>
  </div>
</template>

<script>
import ahout from "../logic/ahout";
export default {
  data: () => ({
    nombreDeUsarioOEmail: "",
    password: "",
    error: false,
  }),
  methods: {
    async login() {
  try {
    await ahout.login(this.nombreDeUsarioOEmail, this.password);
    const user = {
      nombreDeUsarioOEmail: this.nombreDeUsarioOEmail
    };
    ahout.setUserLogged(user);
    this.$router.push("/");
  } catch (error) {
    console.log(error);
    this.error = true;
  }
}
  },
};
</script>

