using System;

    namespace Aplicacao {
        class Programa {
            static void Main (string[] args) {
                Console.WriteLine("Digite dois numeros");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.WriteLine());
                int s = (x + y);
                Console.WriteLine("O valor é: " + s);
            }
        }
    }