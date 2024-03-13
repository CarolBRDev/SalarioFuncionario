using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioFuncionario
{
    public class SalarioFuncionario
    {
        public string nomeFuncionario;
        public double salarioBruto;
        public double imposto;
        public double salarioLiquido;
        public double aumento;
        public double valorAumento;

        public double CalcularSalarioLiquido()
        {
            salarioLiquido = salarioBruto - (salarioBruto * (imposto / 100));
            return salarioBruto;
        }

        public void AumentarSalario()
        {
            valorAumento = salarioBruto * (aumento / 100);
            salarioBruto += valorAumento;
        }
    }
}
