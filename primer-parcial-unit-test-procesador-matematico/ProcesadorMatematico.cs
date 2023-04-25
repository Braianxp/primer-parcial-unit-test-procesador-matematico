using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_unit_test_procesador_matematico
{
    public class ProcesadorMatematico
    {
        private int _resultado;

        public int Sumar(int primerNumero, int segundoNumero)
        {
            this._resultado = primerNumero + segundoNumero;

            if (this.EsNegativo())
            {
                return this._resultado = 0;
            }
            else
            {
                return this._resultado;
            }
        }

        public int Dividir(int dividendo, int divisor)
        {
            try
            {
                this._resultado = dividendo / divisor;
                if (this.EsNegativo())
                {
                    return this._resultado = 0;
                }
                else
                {
                    return this._resultado;
                }

            }
            catch(Exception ex)
            {
                return -1;
            }
            
        }
        private bool EsNegativo()
        {
            return (this._resultado < 0);
        }

        public int CalcularMayor(int primerNumero, int segundoNumero)
        {
            if (primerNumero > segundoNumero)
            {
                return this._resultado = primerNumero;
            }
            else if (primerNumero < segundoNumero)
            {
                return this._resultado = segundoNumero;
            }
            else
            {
                return this._resultado = segundoNumero;
            }
        }
    }
}
