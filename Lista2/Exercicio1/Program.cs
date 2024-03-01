using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nDidite o nome do Usuario: \n");
        string nomeDeUsuario = (Console.ReadLine());

        Console.WriteLine("\nDigite sua senha: \n");
         string senha = (Console.ReadLine());
            
        if (nomeDeUsuario == "Camila" && senha == "Camila@123")
        {
            Console.WriteLine("\nLogin realizado com sucesso! \n");
        }
        else   
        {  
            Console.WriteLine("\nCredencias invalidas, tente novamente!\n ");  
        }
    }

}

