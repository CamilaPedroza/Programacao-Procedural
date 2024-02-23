using System;

class Program
{
  
  public static void Main (string[] args)
  {
  
  Console.WriteLine("Digite a base do Triangulo: ");
  double baseTriangulo = double.Parse(Console.ReadLine());

  Console.WriteLine("Digite a altura do Triangulo: ");
  double alturaTriangulo = double.Parse(Console.ReadLine());

  double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
  bool ehMaiorQ20 = areaTriangulo > 20;

  Console.WriteLine("A área do Triangulo é maior que 20? " + ehMaiorQ20 + "! A área do Triangulo é: " + areaTriangulo + ".");

  }
}
