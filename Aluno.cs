using System;

public class Aluno : Pessoa{
    public int matricula{get; set;}
    public string curso{get; set;}

    public virtual void pagarMensalidade(){
        Console.WriteLine("Pagando mensalidade do aluno " + this.nome);
        
    }
}