using System.Security.Cryptography;

namespace Desafio03 {

    class MyAplication {

        static void Main(string[] args) {

            Console.WriteLine(". Leia a idade de uma pessoa e informe se ela é maior ou menor de idade");

            int ager;

            Console.WriteLine("Digite sua idade :");
            ager = int.Parse(Console.ReadLine());

            if (ager >= 18)
            {
                Console.WriteLine($"Maior de idade , idade informada {ager}  anos ");
            }
            else {
                Console.WriteLine($"Menor de idade , idade informada {ager} anos ");
            }

            Console.ReadLine();
        }
    }
}
