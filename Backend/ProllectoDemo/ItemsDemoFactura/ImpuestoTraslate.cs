using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsDemoFactura
{
    public static class ImpuestoTraslate
    {
        public static  TipoDeInpuesto Traslate(string Nombre_Inpuesto )
        {
            if (Nombre_Inpuesto.Contains("IVA") || Nombre_Inpuesto.Contains("iva"))
            {
                if (Nombre_Inpuesto.Contains("RE") || Nombre_Inpuesto.Contains("re") || Nombre_Inpuesto.Contains("Re"))
                {
                    return new TipoDeInpuesto
                    {
                        Impuesto = "IVA",
                        Retencion_O_Traslado= "Retencion"
                    };
                }
                else
                {
                    return new TipoDeInpuesto
                    {
                        Impuesto = "IVA",
                        Retencion_O_Traslado = "Traslado"
                    };
                }
                    
            }
            if (Nombre_Inpuesto.Contains("ISR") || Nombre_Inpuesto.Contains("isr"))
            {
                if (Nombre_Inpuesto.Contains("RE") || Nombre_Inpuesto.Contains("re") || Nombre_Inpuesto.Contains("Re"))
                {
                    return new TipoDeInpuesto
                    {
                        Impuesto = "ISR",
                        Retencion_O_Traslado = "Retencion"
                    };
                }
                else
                {
                    return new TipoDeInpuesto
                    {
                        Impuesto = "ISR",
                        Retencion_O_Traslado = "Traslado"
                    };
                }

            }
            if (Nombre_Inpuesto.Contains("ISH") || Nombre_Inpuesto.Contains("ish"))
            {
                if (Nombre_Inpuesto.Contains("RE") || Nombre_Inpuesto.Contains("re") || Nombre_Inpuesto.Contains("Re"))
                {
                    return new TipoDeInpuesto
                    {
                        Impuesto = "ISH",
                        Retencion_O_Traslado = "Retencion"
                    };
                }
                else
                {
                    return new TipoDeInpuesto
                    {
                        Impuesto = "ISH",
                        Retencion_O_Traslado = "Traslado"
                    };
                }

            }
            else
            {
                return new TipoDeInpuesto
                {
                    Impuesto = "IVA",
                    Retencion_O_Traslado = "Traslado"
                };
            }
        }
    }
}
