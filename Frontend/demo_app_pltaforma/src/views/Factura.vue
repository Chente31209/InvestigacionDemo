<template>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col">
                <div class="container">
                        <div class="row">
                            <div class="col">
                                <div><!--Componete -->
                                    <label for="">Folio</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">A-123</option>
                                        
                                    </select>
                                </div>
                            </div>
                            <div class="col">
                                <div><!--Componete -->
                                    <label for="">Forma de Paago</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">One</option>
                                        <option value="2">Two</option>
                                        <option value="3">Three</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col">
                                <div><!--Componete -->
                                    <label for="">Fecha</label>
                                    <input type="datetime" class="form-control" >

                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                            <div><!--Componete -->
                                    <label for="">Tipo de Comprobante</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">One</option>
                                        <option value="2">Two</option>
                                        <option value="3">Three</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col">
                           <div><!--Componete -->
                                    <label for="">CFDI</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">One</option>
                                        <option value="2">Two</option>
                                        <option value="3">Three</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col">
                            <div><!--Componete -->
                                    <label for="">Moneda</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">One</option>
                                        <option value="2">Two</option>
                                        <option value="3">Three</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                            <div><!--Componete -->
                                    <label for="">Metodo de pago</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">One</option>
                                        <option value="2">Two</option>
                                        <option value="3">Three</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col">
                            <div><!--Componete -->
                                    <label for="">Cliente</label>
                                    <input type="text" class="form-control" >
                                </div>
                            </div>
                            <div class="col">
                            <div><!--Componete -->
                                    <label for="">Domicilo Fiscal</label>
                                    <input type="text" class="form-control" >
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                            <div><!--Componete -->
                                    <label for="">Condicioes de Pago</label>
                                    <select class="form-select" >
                                        <option selected>Open this select menu</option>
                                        <option value="1">One</option>
                                        <option value="2">Two</option>
                                        <option value="3">Three</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="col">
                <div class="row justify-content-center">
                    <div class="col">
                        <div class="input-group mb-3">
                            <input type="text" class="form-control" placeholder="Produtos" aria-label="Recipient's username" aria-describedby="button-addon2">
                            <button class="btn btn-outline-secondary" type="button" id="button-addon2">Button</button>
                        </div>
                    </div>
                </div>
                <div class="row justify-content-center">
                    <div class="col">
                        <table class="table">
                            <thead>
                                <tr>
                                <th scope="col">Nobre</th>
                                <th scope="col">Unidad de Mdeida</th>
                                <th scope="col">Unidades</th>
                                <th scope="col">Precios</th>
                                <th scope="col">Total</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                <th >Frijol Negro</th>
                                <td>Toneladas</td>
                                <td>4</td>
                                <td>15000.00</td>
                                <td>60000.00</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        
    </div>

</template>
<script>
import Catalogos from '../logic/CatalogosFactura'

export default {
    setup() {
        Catalogos.getCfdi()
    },
}
</script>
