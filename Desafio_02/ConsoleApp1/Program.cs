namespace Desafio02
{
    class aplication {

        static void Main(string[] args) {

            Console.WriteLine("Leia dois números e informe se eles são iguais ou diferentes");

            int number1, number2;

            Console.WriteLine("informe o  primeiro numero:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo numero:");
            number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"numeros {number1} , {number2} são iguais ");
            }
            else if (number1 != number2)
            {
                Console.WriteLine($"Numeros {number1} , {number2} são diferentes ");
            }
            else {
                Console.WriteLine("Não digitou numeros");
            }

                Console.ReadLine();
        }
    }
}
