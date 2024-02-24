using System;

class Program
{

  static void Main(string[] args)
   { 

    Console.WriteLine("Digite a quantidade de moedas de 1 centavo: ");
    int quantidadeDeMoedas = int.Parse(Console.ReadLine());

    int conversaoDasMoedasRecebidas = quantidadeDeMoedas / 100; 
    int sobraDasMoedas = quantidadeDeMoedas % 100;

    Console.WriteLine("A quantidade total em dinheiro é: " + conversaoDasMoedasRecebidas +  " real(is)" + " e "  + sobraDasMoedas + " centavo(s).");
 
     }

}


