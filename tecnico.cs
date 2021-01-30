using System;

public class Tecnico : Aluno{
    private int registroPessoal{get; set;}
    
    public void praticar(){
        Console.WriteLine(this.nome + " está praticando os conceitos teóricos aprendidos em "+ this.curso);
    }
}