namespace MeuAplication {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" Leia um número e informe se ele é divisível por 2 e por 3");

            int num1;

            Console.WriteLine("Digite um numero inteiro:");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Numero e divisivel por 2");
            }
            else {
                Console.WriteLine("Numero e divisivel por 3");
            }

            Console.ReadLine();
        }
       
    }
}