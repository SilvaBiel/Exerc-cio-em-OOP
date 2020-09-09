using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa Individuo = new Pessoa();
    Individuo.MudaIdade(15);
    Individuo.MudaPeso(30);
    Console.WriteLine(Individuo.RetornaIdade());
    Console.WriteLine(Individuo.RetornaPeso());
    Console.WriteLine(Individuo.RetornaAltura());
  }
}