using System;

class Programa
{
  static void Main(string[] args)
  {

    ContaCorrente contaGabriela = new ContaCorrente();
    contaGabriela.titular = "Gabriela";
    contaGabriela.agencia = 863;
    contaGabriela.numero = 863452;
    contaGabriela.saldo = 100;


    Console.WriteLine(contaGabriela.titular);
    Console.WriteLine(contaGabriela.agencia);
    Console.WriteLine(contaGabriela.numero);
    Console.WriteLine(contaGabriela.saldo);

    Console.ReadLine();
  }
}