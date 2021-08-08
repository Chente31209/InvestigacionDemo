<template>
<div>
    <bar_nav/>
</div>

  <router-view/>
</template>

<script>
import bar_nav from '../src/components/bar_nav.vue'
export default {
  components:{
    bar_nav
  }
}
</script>



