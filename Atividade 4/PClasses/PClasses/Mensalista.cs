using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista: Empregado
    {
        //"prop" e tab duas vezes:
        public double SalarioMensal { get; set; }

        public static String Empresa = "Beemau";

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

        //sobrecarga do construtor
        public Mensalista(int matx, string nomex, DateTime datax, double salx)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salx;
        }
        public Mensalista()
        {

        }
    }
}
