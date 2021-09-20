import axios from "axios";
import Cookies from "js-cookie";
const ENDPOINT_PATH = "http://localhost:42086/api/";

export default {
  setUserLogged(userLogged) {
    Cookies.set("userLogged", userLogged);
  },
  getUserLogged() {
    return Cookies.get("userLogged");
  },
  register(nombreDeUsarioOEmail, password) {
    const user = { nombreDeUsarioOEmail, password };
    return axios.post(ENDPOINT_PATH + "regiser", user);
  },
  login(nombreDeUsarioOEmail, password) {
    const user = { nombreDeUsarioOEmail, password };
    return axios.post(ENDPOINT_PATH + "login", user);
  },
  deleteUserLogged() {
    Cookies.remove('userLogged');
  }
};