
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Por favor ingrese el numero:");
    string numeroComoString = Console.ReadLine();    
    // string a int
    int numero = Int32.Parse(numeroComoString);
    int suma =0;
    // verificar q el numero sea positivo y se hace la suma
    while(numero >= 0)
    {
      suma= suma + numero;    
      Console.WriteLine ("Por favor ingrese otro numero:");
      string numeroComoString2 = Console.ReadLine();
      // string a int
      numero = Int32.Parse(numeroComoString2);
    }
    Console.WriteLine ("El valor de la suma de numeros positivos es:" +suma);
    
  }
}