using System;

public class Bolsista : Aluno{
    protected float bolsa{get; set;}
    public void renovarBolsa(){
        Console.WriteLine("Renovando bolsa de " + this.nome);
    }
    public override void pagarMensalidade(){
        Console.WriteLine(this.nome + " é bolsista e tem pagamento especial");
    }
}