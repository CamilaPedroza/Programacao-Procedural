using System;

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("\nDigite o nome da criança: \n");
        string nomeDaCrianca = (Console.ReadLine());
        
        if (nomeDaCrianca == "Filomena")
        {
            Console.WriteLine("\nRotina da Filomena:\n \n 1. Escola das 07h as 12h\n 2. Almoço das 12h as 13\n 3. Futebol das 14h as 16h\n 4. Dever de casa das 16h as 18h\n");
        }
        else if (nomeDaCrianca == "Joselito")
        {
            Console.WriteLine("\nRotina do Joselito:\n \n 1. Escola das 07h as 12:30\n 2. Almoço das 13h as 14h \n 3. Natação das 14h as 16h\n 4. Reforço escolar das 16h as 19h\n");
        }
        else 
        {
            Console.WriteLine("Ainda nao temos um Cronograma para o(a) " + nomeDaCrianca + ".");
        }
    }
}
