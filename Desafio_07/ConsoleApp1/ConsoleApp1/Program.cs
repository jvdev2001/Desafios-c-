namespace Myaplication {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia uma idade e informe se a pessoa pode tirar carteira de motorista.");

            int ager;

            int verificaIdadeCarteira = 18;

            Console.WriteLine("Digite idade para a verificacao:");
            ager = int.Parse(Console.ReadLine());

            if (ager >= verificaIdadeCarteira)
            {
                Console.WriteLine($"Cliente esta entre os requisitos para retirar a carteira de motorista : , sua idade e {ager}");
            }
            else {
                Console.WriteLine($"Cliente nao esta entre os requisitos para retirar a carteira de motorista : , sua idade e {ager}");
            }

                Console.ReadLine();
        }
    }
}