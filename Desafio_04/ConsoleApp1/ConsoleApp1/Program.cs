namespace Myaplication {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Leia um número e informe se ele é positivo, negativo ou zero.");

            int x;
            Console.WriteLine("Digite um numero :");
            x = int.Parse(Console.ReadLine());

            if (x <=0)
            {
                Console.WriteLine($"Numero Digitado e negativo {x}");
            }
            else {
                Console.WriteLine($"Numero Digitado e Positivo {x}");
            }

            Console.ReadLine();
        }
    }   
}
