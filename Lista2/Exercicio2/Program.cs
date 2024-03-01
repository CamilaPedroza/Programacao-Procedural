using System;

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());
       
        Console.WriteLine("Digite a nota 4: ");
        double nota4 = double.Parse(Console.ReadLine());

        double mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4.0;

        if (mediaFinal >= 5.0)
        {
            Console.WriteLine("Aluno aprovado!: " + "a Media Final eh: " + Math.Round(mediaFinal, 3) + ".");
        }   
        else if (mediaFinal < 5.0 && mediaFinal >= 3.0)
        {
            Console.WriteLine("Aluno em recuperacao." + "a Media Final eh:" + Math.Round(mediaFinal, 3) + ".");
        }    
        else
        {
            Console.WriteLine("\nAluno reprovado!." + "A Media Final eh:" + Math.Round(mediaFinal, 3) + ".\n");
        }        
    }
}




