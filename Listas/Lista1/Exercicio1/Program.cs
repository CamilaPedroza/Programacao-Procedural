using System;

class Program
{
     static void Main(string[] args)
     {  
       Console.WriteLine("Olá! Digite seu nome: ");
       string nome = Console.ReadLine();
        
        // No meu caso, a entrada dos n°s decimais funcionaram corretamente com virgula.
        Console.WriteLine("Digite a nota do ° Bimestre: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do 2° Bimestre: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do 3° Bimestre: ");
        double nota3 = double.Parse(Console.ReadLine());
       
        Console.WriteLine("Digite a nota do 4° Bimestre: ");
        double nota4 = double.Parse(Console.ReadLine());

        double mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4.0;

        Console.WriteLine(nome + ", sua Média Final é: " + Math.Round(mediaFinal, 3) + ".");

     }
} 



