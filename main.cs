/*1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.*/

using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Digite o primeiro numero");
    int Primeironum = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o segundo numero");
    int Segundonum = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a operação");
    int Resultado;
    string simbolo;  
    simbolo = Console.ReadLine();
    switch (simbolo)
    {
      case "+":
        {
          Resultado = (Primeironum + Segundonum);
          Console.WriteLine(Resultado);
          break;
        }
      case "-":
        {
          Resultado = (Primeironum - Segundonum);
          Console.WriteLine(Resultado);
          break;
        }
      case "*":
        {
          Resultado = (Primeironum * Segundonum);
          Console.WriteLine(Resultado);
          break;
      }
      case "/":
      {
          Resultado = (Primeironum / Segundonum);
          Console.WriteLine(Resultado);
          break;
      }
      default:
    {
      break;
    }
    }
    }
}