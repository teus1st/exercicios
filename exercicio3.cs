using System;

class Program
{
    public static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("digite o valor de a");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o valor de b");
        b = double.Parse(Console.ReadLine());
      // primeira condição//
        if (a != 0)
        {// variavel do valor de x e sua conta//
            double x = (-b / a);
            Console.WriteLine("o a raiz é" + x);
        }
      // segunda condição//
        else
        {  // condiçao de B//
            if (b == 0)
            {
                Console.WriteLine("a raiz é uma identidade, todo valor é uma soluçao");
            }
          // terceira condição//
            else
            {
                Console.WriteLine(" a equaçao nao tem solução");
            }

        }
    }
}