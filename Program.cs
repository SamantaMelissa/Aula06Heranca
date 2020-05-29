using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Samanta";
            System.Console.WriteLine(cpf.Saudar());

            
            cpf.cpf = "511.914.798-46";
            System.Console.WriteLine(cpf.ValidarCPF());
        }
    }
}
