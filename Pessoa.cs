using System;
public abstract class Pessoa {
   public string nome{ get; set;}
   
   public int idade{get; set;}

   public string sexo{get; set;}

public void fazerAniversario(){
        this.idade ++;
    }

public string toString() => "Dados {" + "nome = " + nome + ", idade = " + idade + ", sexo = " + sexo + " }";
}

