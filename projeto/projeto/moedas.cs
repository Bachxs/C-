using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class Converter
    {
        public int dolar, euro, libra, real;
        public string nome, endereço;

        public Converter()
        {
            dolar = 0;
            euro = 0;
            libra = 0;
            real = 0;
            nome = "";
            endereço = "";
        }
        public string converterD()
        {
            Int32 convD = dolar * 5;
            string dados;
            dados = "/nAdquiriu $" + convD + " Dolares ";
            return dados;
        }
        public string converterL()
        {
            Int32 convL = libra * 6;
            string dados2;
            dados2 = "/nAdquiriu £" + convL + " Libras ";
            return dados2;
        }
        public string converterE()
        {
            Int32 convE = euro * 6;
            string dados3;
            dados3 = "/nAdquiriu €" + convE + " Euro ";
            return dados3;
        }
        
    }
}
