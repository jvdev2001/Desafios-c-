using System.Numerics;

namespace MyAplication {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("1. Leia dois números inteiros e informe qual deles é o maior.");

            int x, y , n;

            Console.WriteLine("Digite primeiro numero inteiro : ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero :");
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($" primeiro numero e maior do que o segundo numero {x}");
            }
            else if (y > x)
            {
                Console.WriteLine($"Segundo numero e maior do que o primeiro numero {y}");
            }
            else {
                Console.WriteLine($"Numeros {x} e {y} são iguais");
            }
           

        }
    }
}
