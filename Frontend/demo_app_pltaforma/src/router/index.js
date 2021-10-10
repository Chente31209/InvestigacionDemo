import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Login from '../views/Login.vue'
import Factura from '../views/Factura.vue'
import LogUp from '../views/LogUp'


const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    component: function () {
      return import('../views/About.vue')
    }
  },
  {
    path: '/perfil',
    name: 'Perfil',
    component: function () {
      return import('../views/perfil.vue')
    }
  },
  {
    path: '/login',
    name: 'login',
    component: Login
  },
  {
    path: '/Factuta',
    name: 'factura',
    component: Factura
  },
  {
    path: '/logup',
    name: 'logup',
    component: LogUp
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
