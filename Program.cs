using System;

namespace CalculoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            double nota3 = double.Parse(Console.ReadLine());

            double peso1 = 0.3;
            double peso2 = 0.35;
            double peso3 = 0.35;

            double NotaFinal = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
            string linhas = new string('=', 50);

            Console.WriteLine(linhas);

            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"Média Final: {NotaFinal}");

            Console.WriteLine(linhas);

            if (NotaFinal <= 60)
            {
                double falta = 60 - NotaFinal;
                Console.WriteLine($"Você está Reprovado. Faltam {falta} pontos para ser Aprovado.");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
