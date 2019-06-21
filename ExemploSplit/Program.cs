using System;
using System.Globalization;
namespace ExemploSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            double porhora=0.0;
            char tecla = 's';
          do
            {
                try
                {

                    Console.WriteLine("Digite seu nome, seu salario e a quantidades de horas trabalhadas por mês ( na mesma linha )");
                    string[] vet = Console.ReadLine().Split(' ');


                    string nome = vet[0];
                    double salario = double.Parse(vet[1], CultureInfo.InvariantCulture);
                    double horas = double.Parse(vet[2], CultureInfo.InvariantCulture);

                    porhora = salario / horas;

                    Console.WriteLine($"{nome} você recebe: R${porhora.ToString("F2", CultureInfo.InvariantCulture)} por hora trabalhada");
                }
                catch (Exception)
                {

                    Console.WriteLine("Erro, tente novamente");
                }
                finally
                {
                    Console.WriteLine("Deseja tentar novamente? s para sim e n para não");  
                }

                try
                {
                    tecla = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Erro, tente novamente");
                }
                finally
                {
                    Console.WriteLine("Deseja tentar novamente? s para sim e n para não");

                }

            } while (tecla == 's');
          


         
        }
    }

}