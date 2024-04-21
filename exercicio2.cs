using System;

class Program {
  public static void Main (string[] args) {
    // declaraçao de variaveis
    int num1, num2, soma;
    Console.WriteLine("digite o primeiro numero: ");
    // entrada de dados
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o segundo numero: ");
    // entrada de dados 2
    num2 = int.Parse(Console.ReadLine());
    soma= num1+num2; 
    // primeira condiconal
    if(soma>=10){
      soma+=5;
      Console.WriteLine(" a soma do numero +5 é: "+soma);
    }
    // segunda condicional
    else{
    soma+=7;
      Console.WriteLine("a soma do numero +7 é: "+soma);
    }
  }
}