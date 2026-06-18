
namespace MyApplication
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia N e mostre sua tabuada.\r\n");

            int n , soma = 0;

            Console.Write("Digite um numero para mostra a tabuada  :");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=10; i++) {
                soma = n + i;
                Console.WriteLine($"{n} + {i} = {soma}");
            }

            Console.ReadLine();
        }
    }
}