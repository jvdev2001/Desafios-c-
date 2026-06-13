namespace Myaplication {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia um número e informe se ele está entre 10 e 50.");

            int number;

            Console.Write("Digite um numero :");
            number = int.Parse(Console.ReadLine());

            if (number > 10 && number < 50)
            {
                Console.WriteLine($"numero Digitado {number} , esta entre 10   e 50");
            }
            else {
                Console.WriteLine($"numero Digitado {number} , não esta entre 10 e 50");
            }

            Console.ReadLine();
        }
    }
}