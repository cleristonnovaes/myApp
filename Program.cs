using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Visitante();
            
            v1.nome = "João";
            v1.idade = 22;
            v1.sexo = "M";

            //Console.WriteLine(v1.toString());

            var a1 = new Aluno();

            a1.nome = "Pedro";
            a1.idade = 16;
            a1.sexo = "M";
            a1.matricula = 1111;
            a1.curso = "Informatica";
            a1.pagarMensalidade();

            //Console.WriteLine(a1.toString());

            var b1 = new Bolsista();

            b1.nome = "Juvenal";
            b1.idade = 27;
            b1.sexo = "M";
            b1.curso = "Matematica";
            b1.pagarMensalidade();

            //Console.WriteLine(b1.toString());

            var t1 = new Tecnico();
            t1.nome = "Maria";
            t1.idade = 18;
            t1.sexo = "F";
            t1.curso = "Mecanica";
            t1.praticar();

            Console.WriteLine(t1.toString());

            

        }
    }
}
