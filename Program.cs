using System;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. A Classe para esta atividade deve conter os atributos Nome, SalarioBruto e Imposto e os Métodos CalcularSalarioLiquido() : double e AumentarSalario(): void
            //salario bruto = sem os descontos
            //salario liquido = depois dos descontos

            Console.WriteLine("Digite o nome do funcionario: ");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Digite o salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de imposto: ");
            double imposto = double.Parse(Console.ReadLine());

            double salarioLiquido = salarioBruto - (salarioBruto * (imposto / 100));

            Console.WriteLine();
            Console.WriteLine($"Nome do funcionario: {nomeFuncionario}\nSalário líquido: R${salarioLiquido:F2}");
            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem de aumento do salario bruto: ");
            double aumento = double.Parse(Console.ReadLine());

            double novoSalBruto = salarioBruto + (salarioBruto * (aumento / 100));

            salarioLiquido = novoSalBruto - (novoSalBruto * (imposto / 100));

            Console.WriteLine();
            Console.WriteLine($"Nome do funcionario : {nomeFuncionario}\nSalário Liquido: R${salarioLiquido:F2}");


        }
    }
}
