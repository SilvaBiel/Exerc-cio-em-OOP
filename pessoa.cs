using System;

class Pessoa {
  //METODO DE ACESSO - PUBLIC PRIVATE e PROTECTED
  int Peso; 
  int Idade;
  string Nome;
  double Altura=0.5;
  int Acesso=987654321;
  //SET
  public void MudaAltura(int a){
    //RN RESTRITIVA - ACESSO
    if (a > 0) {
       Altura = a;
    }  
    else{
      Console.WriteLine("VALOR INVALIDO");
    }
  }
  public void MudaIdade(int y){
    //RN RESTRITIVA - ACESSO
    if (y > 0) {
       Idade = y;
    }  
    else{
      Console.WriteLine("VALOR INVALIDO");
    }
    if(Idade < 22){
      Altura=Altura+(y*0.05);
    }
    }
  public void MudaNome(string n, int senha){
    //RN RESTRITIVA - ACESSO
    if (senha == Acesso) {
       Nome = n;
    }  
    else{
      Console.WriteLine("Acesso Negado");
    }
  }
  public void MudaPeso(int p){
    //RN RESTRITIVA - ACESSO
    if (p > 0) {
       Peso = p;
    }  
    else{
      Console.WriteLine("Valor Invalido");
    }
  }
        
  //GET
  public string RetornaNome(){
       return Nome;
  }
  public int RetornaPeso(){
       return Peso;
  }
  public int RetornaIdade(){
       return Idade;
  }
  public double RetornaAltura(){
    return Altura;
  }
}
