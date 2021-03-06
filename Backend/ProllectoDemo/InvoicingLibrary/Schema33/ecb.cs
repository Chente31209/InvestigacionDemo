//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/ecb")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/ecb", IsNullable = false)]
public partial class EstadoDeCuentaBancario {
    
    private object[] movimientosField;
    
    private string versionField;
    
    private string numeroCuentaField;
    
    private string nombreClienteField;
    
    private string periodoField;
    
    private string sucursalField;
    
    public EstadoDeCuentaBancario() {
        this.versionField = "1.0";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MovimientoECB", typeof(EstadoDeCuentaBancarioMovimientoECB), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("MovimientoECBFiscal", typeof(EstadoDeCuentaBancarioMovimientoECBFiscal), IsNullable=false)]
    public object[] Movimientos {
        get {
            return this.movimientosField;
        }
        set {
            this.movimientosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string numeroCuenta {
        get {
            return this.numeroCuentaField;
        }
        set {
            this.numeroCuentaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nombreCliente {
        get {
            return this.nombreClienteField;
        }
        set {
            this.nombreClienteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string periodo {
        get {
            return this.periodoField;
        }
        set {
            this.periodoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sucursal {
        get {
            return this.sucursalField;
        }
        set {
            this.sucursalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/ecb")]
public partial class EstadoDeCuentaBancarioMovimientoECB {
    
    private System.DateTime fechaField;
    
    private string referenciaField;
    
    private string descripcionField;
    
    private decimal importeField;
    
    private string monedaField;
    
    private decimal saldoInicialField;
    
    private bool saldoInicialFieldSpecified;
    
    private decimal saldoAlCorteField;
    
    private bool saldoAlCorteFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime fecha {
        get {
            return this.fechaField;
        }
        set {
            this.fechaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string referencia {
        get {
            return this.referenciaField;
        }
        set {
            this.referenciaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string descripcion {
        get {
            return this.descripcionField;
        }
        set {
            this.descripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moneda {
        get {
            return this.monedaField;
        }
        set {
            this.monedaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal saldoInicial {
        get {
            return this.saldoInicialField;
        }
        set {
            this.saldoInicialField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool saldoInicialSpecified {
        get {
            return this.saldoInicialFieldSpecified;
        }
        set {
            this.saldoInicialFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal saldoAlCorte {
        get {
            return this.saldoAlCorteField;
        }
        set {
            this.saldoAlCorteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool saldoAlCorteSpecified {
        get {
            return this.saldoAlCorteFieldSpecified;
        }
        set {
            this.saldoAlCorteFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/ecb")]
public partial class EstadoDeCuentaBancarioMovimientoECBFiscal {
    
    private System.DateTime fechaField;
    
    private string referenciaField;
    
    private string descripcionField;
    
    private string rFCenajenanteField;
    
    private decimal importeField;
    
    private string monedaField;
    
    private decimal saldoInicialField;
    
    private bool saldoInicialFieldSpecified;
    
    private decimal saldoAlCorteField;
    
    private bool saldoAlCorteFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime fecha {
        get {
            return this.fechaField;
        }
        set {
            this.fechaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string referencia {
        get {
            return this.referenciaField;
        }
        set {
            this.referenciaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string descripcion {
        get {
            return this.descripcionField;
        }
        set {
            this.descripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RFCenajenante {
        get {
            return this.rFCenajenanteField;
        }
        set {
            this.rFCenajenanteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moneda {
        get {
            return this.monedaField;
        }
        set {
            this.monedaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal saldoInicial {
        get {
            return this.saldoInicialField;
        }
        set {
            this.saldoInicialField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool saldoInicialSpecified {
        get {
            return this.saldoInicialFieldSpecified;
        }
        set {
            this.saldoInicialFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal saldoAlCorte {
        get {
            return this.saldoAlCorteField;
        }
        set {
            this.saldoAlCorteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool saldoAlCorteSpecified {
        get {
            return this.saldoAlCorteFieldSpecified;
        }
        set {
            this.saldoAlCorteFieldSpecified = value;
        }
    }
}
