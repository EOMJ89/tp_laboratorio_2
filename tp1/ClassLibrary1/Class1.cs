using System;
using System.Collections.Generic;
using System.Linq;
using(resource)
	{

	} System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculadora
    {
        public double Operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;

            return retorno;
        }

        private string ValidarOperador(string operador)
        {
            string retorno = "";
            return retorno;
        }
    }

    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero1)
        {
            this.numero = numero1;
        }

        public Numero(string strNumero)
        {
            this.numero = Numero.ValidarNumero(strNumero);
        }

        public void SetNumero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero);
        }

        private static double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);
            return retorno;
        }

        public static double BinarioDecimal(string binario)
        {
            double auxDouble = 0;

            for (int i = binario.Length; i > 0; i--)
            {
                if (binario[i - 1] == 49)
                {
                    auxDouble += Math.Pow(2, binario.Length - i);
                }
            }
            return auxDouble;
        }

        public static string DecimalBinario(double aConvertir)
        {
            string auxString = "";

            while (aConvertir >= 1)
            {
                if (aConvertir % 2 == 0)
                {
                    auxString = "0" + auxString;
                }
                else
                {
                    auxString = "1" + auxString;
                }

                aConvertir = (int)aConvertir / 2;

            }

            return auxString;
        }

        public static string DecimalBinario(string aConvertir)
        {
            string auxString = "";
            double auxReturn = Numero.ValidarNumero(aConvertir);

            auxString = Numero.DecimalBinario(auxReturn);
            return auxString;
        }
    }
}
