import axios from "axios";
import Cookies from "js-cookie";
const ENDPOINT_PATH = "http://localhost:27585/api/";

export default {
  setUserLogged(userLogged) {
    Cookies.set("userLogged", userLogged);
  },
  getUserLogged() {
    return Cookies.get("userLogged");
  },

  LogUp(nombre,primerApellido,segundoApellido,nombreDeUsuario,e_Mail,pasword) {
    const user = {
      nombre,
      primerApellido,
      segundoApellido,
      nombreDeUsuario,
      e_Mail,
      pasword
    };
    return axios.post(ENDPOINT_PATH + "logup", user);
  },

  login(nombreDeUsuario, password) {
    const user = { nombreDeUsuario, password };
    return axios.post(ENDPOINT_PATH + "login", user);
  },
  
  deleteUserLogged() {
    Cookies.remove('userLogged');
  }
};