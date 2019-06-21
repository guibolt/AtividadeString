using System;

namespace Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upper
            Console.WriteLine("Digite o primeiro nome");
           string nome = Console.ReadLine();

          Console.WriteLine("Digite o segundo nome");
            string nome2 = Console.ReadLine();

            string nomemaior = nome.ToUpper();
           string nomeaior2 = nome2.ToUpper();

            Console.WriteLine($"Esse é o nome: {nomemaior}");
           Console.WriteLine($"Esse é o segundo nome: {nomeaior2}");
            //Lower 
            Console.WriteLine("Agora Convertendo para minusculo");
            nomemaior = nomemaior.ToLower();
            nomeaior2 = nomeaior2.ToLower();

            Console.WriteLine(nomemaior);
            Console.WriteLine(nomeaior2);
            
            //exemplo Trim

            string extrim = "  Deixando a string bem espaçada  ";

            Console.WriteLine("-"+extrim+"-");
            Console.WriteLine("Agora com o trim");
            Console.WriteLine("-"+extrim.Trim()+"-");

            // Exemplo Indexof
            Console.WriteLine("digite duas letras da frase acima para eu lhe dizer o indice");
            string letras = Console.ReadLine();

           int localiza = extrim.LastIndexOf(letras);

            Console.WriteLine(localiza);

            // Exemplo Substring

            Console.WriteLine("Digite uma frase de sua escolha:" );
            string frase = Console.ReadLine();

            Console.WriteLine("Agora diga quantos caracteres quer cortar da frase");
              int car = int.Parse(Console.ReadLine());
           string novafrase =  frase.Substring(car);

            Console.WriteLine($"Essa é a frase com o corte: {novafrase}");

            Console.WriteLine("Agora vou dizer quantas letras tem a frase digitado com o corte");
           
            
            // lenght

            int frasec = novafrase.Length;
            Console.WriteLine($"Sua frase agora tem {frasec} caracteres");

            // replace

            Console.WriteLine("Digite as letras que quer substuir da frase acima Ex/ trocar A por X");
            string [] vet = Console.ReadLine().Split(' ');
            
            string frasub = frase.Replace(vet[0],vet[1]);

            Console.WriteLine($"Essa é a frase com as letras substituidas: {frasub}");


            // contains 

            Console.WriteLine( "digite uma letra para procurar na frase");
            char pes = char.Parse(Console.ReadLine());
            bool result = frasub.Contains(pes);

            Console.WriteLine($"E o resultado é: {result}");
        }
    }
}
