using System;
using Exercicio002;

namespace Exercicio002
{
    class Metodos
    {
        static void Main(string[] args)
        {
            Funcionarios fun1, fun2, fun3;

            fun1 = new Funcionarios();
            fun2 = new Funcionarios();
            fun3 = new Funcionarios();

            Console.WriteLine("Digite o primeiro nome do funcionário: ");
            fun1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a função: ");
            fun1.Funcao = Console.ReadLine();
            Console.WriteLine("Digite o setor do funcionário: ");
            fun1.Setor = Console.ReadLine();

            Console.WriteLine("Nome: " + fun1.Nome + "\n" + "Função: " + fun1.Funcao + "\n" + "Setor: " + fun1.Setor);

        }
    }
}