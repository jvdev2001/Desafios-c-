namespace Myaplication {
        
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine($"Leia três números e informe qual é o maior");

            int x, y, n;

            Console.Write("Digite primeiro numero:");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite segundo numero:");
            y = int.Parse(Console.ReadLine());

            Console.Write("Digite Terceiro numero:");
            n = int.Parse(Console.ReadLine());

            if (x > y && x>n)
            {
                Console.WriteLine($"Primeiro numero e o maior entre os 3 , {x}");
            }
            else if (y > x && y>n)
            {
                Console.WriteLine($"Segundo numero e maior entre os 3 , {y}");
            }
            else{
                Console.WriteLine($"Terceiro numero e o maior entre os 3 ,{n} ");

            }

                Console.ReadLine();

        }
    }
    }