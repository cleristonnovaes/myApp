using System;

public class Professor : Pessoa{
    protected string especialidade{get; set;}
    protected float salario{get; set;}

    public void receberAumento(int aum){
        this.salario += aum;
    }
}