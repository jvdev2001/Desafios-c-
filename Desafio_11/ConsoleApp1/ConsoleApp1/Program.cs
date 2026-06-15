namespace Myaplication {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" Leia um número de 1 a 7 e mostre o dia da semana");

            int num;

            Console.WriteLine("Digite um numero :");

            num = int.Parse(Console.ReadLine());

            if (num >=1 && num<=7)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Segunda feira");
                        break;
                    case 2:
                        Console.WriteLine("Terça feira");
                        break;
                    case 3:
                        Console.WriteLine("Quarta feira");
                        break;
                    case 4:
                        Console.WriteLine("Quinta feira");
                        break;
                    case 5:
                        Console.WriteLine("sexta feira");
                        break;
                    case 6:
                        Console.WriteLine("sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                }
            }
            else {
                Console.WriteLine("Numero tem que esta entre 1 a 7");
            }

            Console.ReadLine();
            
        }
    }
}