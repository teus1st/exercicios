using System;

class Program {
  public static void Main (string[] args) {
    // declaraçao de variaveis
    double num1, num2;
    Console.WriteLine("digite o primeiro nuemro: ");
    // entrada de dados
    num1= double.Parse(Console.ReadLine());
    Console.WriteLine("digite o segundo numero: ");
    // entrada de dados
    num2= double.Parse(Console.ReadLine());
    // primeira condicao
    if (num1>num2)
    {
      Console.WriteLine(" o maior numero é:" +num1);
      }
    // segunda condicao
    else
    { 
      Console.WriteLine("o maior numero é :" +num2);
      }
    Console.ReadKey();
    }
  }
