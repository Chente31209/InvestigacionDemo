using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsDemoFactura
{
    public static  class Calculos
    {
        public static  decimal PrecioConIVA(double SubTotal, int Porsentaje )
        {
            double  IVA = Calculos.IVA(SubTotal, Porsentaje);
            decimal Result= Convert.ToDecimal(SubTotal + IVA) ;
            return Result;
        }
        public static double IVA(double SubTotal, int Porsentaje)
        {
            double Por_Inpu = Porsentaje / 100;
              return  SubTotal * Por_Inpu;
            
        }
        public static double PrecioConISH(double SubTotal, int Porsentaje)
        {
            double ISH = Calculos.ISH(SubTotal, Porsentaje);
            double Result = SubTotal + ISH;
            return Result;
        }
        public static double ISH(double SubTotal, int Porsentaje)
        {
            double Por_Inpu = Porsentaje / 100;
            return SubTotal * Por_Inpu;

        }
        public static double PrecioConISHyIVA(double SubTotal, int PorsentajeIVA, int PorsentajeISH)
        {
            double ISH = Calculos.ISH(SubTotal, PorsentajeISH);
            double IVA = Calculos.IVA(SubTotal, PorsentajeIVA);
            double Result = SubTotal + IVA + ISH;
            return Result;
        }
        public static double Importe(int preio,int catidad,int decuento)
        {
            int Parcial = preio * catidad;
            double Decuento =  decuento/ 100;
            double decuentototal = Parcial * Decuento;

            if (decuento == 0)
                return Parcial;
            else
                return Parcial - decuentototal; 
        }
       
       
    }
}
