using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            SalarioFuncionario x = new SalarioFuncionario();

            Console.WriteLine("Digite o nome do funcionario: ");
            x.nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Digite o salário bruto: ");
            x.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de imposto: ");
            x.imposto = double.Parse(Console.ReadLine());

            double salarioLiquidoX = x.CalcularSalarioLiquido();


            Console.WriteLine();
            Console.WriteLine($"Nome do funcionario: {x.nomeFuncionario}\nSalário líquido: R${x.salarioLiquido:F2}");
            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem de aumento do salario bruto: ");
            x.aumento = double.Parse(Console.ReadLine());

            x.AumentarSalario();
            salarioLiquidoX = x.CalcularSalarioLiquido();

            Console.WriteLine();
            Console.WriteLine($"Nome do funcionario : {x.nomeFuncionario}\nSalário Liquido: R${x.salarioLiquido:F2}");


        }
    }
}
