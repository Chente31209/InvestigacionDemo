<template>
  <div id="nav">
    <BarraDeInviado></BarraDeInviado>
  </div>
  <router-view/>
</template>
<script>
import BarraDeInviado from '../src/components/BarraDeInviado.vue'
export default {
  components : {
    BarraDeInviado
  },
}
</script>
