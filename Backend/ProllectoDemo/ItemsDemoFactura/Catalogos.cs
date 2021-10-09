using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsDemoFactura
{
    public class Catalogos
    {
        public static List<FormaDePagoCatalogo> GetCfdis()
        {
            return new List<FormaDePagoCatalogo>
            {
                new FormaDePagoCatalogo{ Clave = "01",Descripcion="Efectivo"},
                new FormaDePagoCatalogo{ Clave = "02",Descripcion="Cheque Nominativo"},
                new FormaDePagoCatalogo{ Clave = "03",Descripcion="Transferencia Electrónica de Fondos SPEI"},
                new FormaDePagoCatalogo{ Clave = "04",Descripcion="Tarjeta de Crédito"},
                new FormaDePagoCatalogo{ Clave = "05",Descripcion="Monedero Electrónico"},
                new FormaDePagoCatalogo{ Clave = "06",Descripcion="Dinero Electrónico"},
                new FormaDePagoCatalogo{ Clave = "08",Descripcion="Vales de Despensa"},
                new FormaDePagoCatalogo{ Clave = "12",Descripcion="Dación en Pago"},
                new FormaDePagoCatalogo{ Clave = "13",Descripcion="Pago por Subrogación"},
                new FormaDePagoCatalogo{ Clave = "14",Descripcion="Pago por Consignación"},
                new FormaDePagoCatalogo{ Clave = "15",Descripcion="Condonación"},
                new FormaDePagoCatalogo{ Clave = "17",Descripcion="Compensación"},
                new FormaDePagoCatalogo{ Clave = "23",Descripcion="Novación"},
                new FormaDePagoCatalogo{ Clave = "24",Descripcion="Confusión"},
                new FormaDePagoCatalogo{ Clave = "25",Descripcion="Remisión de Deuda"},
                new FormaDePagoCatalogo{ Clave = "26",Descripcion="Prescripción o Caducidad"},
                new FormaDePagoCatalogo{ Clave = "27",Descripcion="A Satisfacción del Acreedor"},
                new FormaDePagoCatalogo{ Clave = "28",Descripcion="Tarjeta de Débito"},
                new FormaDePagoCatalogo{ Clave = "29",Descripcion="Tarjeta de Servicios"},
                new FormaDePagoCatalogo{ Clave = "30",Descripcion="Aplicación de Anticipos"},
                new FormaDePagoCatalogo{ Clave = "31",Descripcion="Intermediario Pagos"},
                new FormaDePagoCatalogo{ Clave = "99",Descripcion="Por Definir"}

            };
        }
        public static List<CFDICatalogo> GetFormasDePagos()
        {
            return new List<CFDICatalogo>
            {
                 new CFDICatalogo{Clave="G01",Decripcion="Adquisición de mercancias",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="G02",Decripcion="Devoluciones, descuentos o bonificaciones",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="G03",Decripcion="Gastos en general",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I01",Decripcion="Construcciones",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I02",Decripcion="Mobilario y equipo de oficina por inversiones",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I03",Decripcion="Equipo de transporte",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I04",Decripcion="Equipo de computo y accesorios",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I05",Decripcion="Dados, troqueles, moldes, matrices y herramental",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I06",Decripcion="Comunicaciones telefónicas",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I07",Decripcion="Comunicaciones satelitales",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="I08",Decripcion="Otra maquinaria y equipo",PersonaFicica=true,PersonaMoral=true},
                 new CFDICatalogo{Clave="D01",Decripcion="Honorarios médicos, dentales y gastos hospitalarios.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D02",Decripcion="Gastos médicos por incapacidad o discapacidad",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D03",Decripcion="Gastos funerales.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D04",Decripcion="Donativos.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D05",Decripcion="Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D06",Decripcion="Aportaciones voluntarias al SAR.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D07",Decripcion="Primas por seguros de gastos médicos.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D08",Decripcion="Gastos de transportación escolar obligatoria.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D09",Decripcion="Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="D10",Decripcion="Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.",PersonaFicica=true,PersonaMoral=false},
                 new CFDICatalogo{Clave="P01",Decripcion="Por Definir ",PersonaFicica=true,PersonaMoral=true}
            };
        }

        public static List<ClaveUnidadCatalogo> GetClavesUnidades()
        {
            return new List<ClaveUnidadCatalogo>
            {
                new ClaveUnidadCatalogo{ClaveUnidaes="SM3", Unidad="m3"},
                new ClaveUnidadCatalogo{ClaveUnidaes="SM3", Unidad="M3"}
            };
        }
        public static List<MetodoDePago> GetMetosoDePagos()
        {
            return new List<MetodoDePago>
            {
                new MetodoDePago{Clave="PUE", Descripcion="Pago en Una Exhibición"},
                new MetodoDePago{Clave="PIP", Descripcion="Pago Inicial y Parcialidades"},
                new MetodoDePago{Clave="PPD", Descripcion="Pago en Parcialidades o Diferido"}
                
            };

        }
        public static List<string> GetCondicionesDePago()
        {
            return new List<string>
            {
                "Al Contado",
                "Anticipado",
                "Aplazado"
            };
        }

    }
}
