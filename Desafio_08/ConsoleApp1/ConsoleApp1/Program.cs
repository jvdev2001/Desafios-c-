namespace MyAplication {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Leia usuário e senha e valide o acesso.");

            string user = "userTest";
            int passaworld = 0011;

            string validaUser;
            int validaPassaword;

            Console.WriteLine("Digite o usuario para realiar o login:");
            validaUser = Console.ReadLine();

            Console.WriteLine("Digite a senha para realizar o login:");
            validaPassaword = int.Parse(Console.ReadLine());

            if (user == validaUser && passaworld == validaPassaword)
            {
                Console.WriteLine("ACESSO LIBERADO");
            }
            else {
                Console.WriteLine("ACESSO NEGADO");
            }

            Console.ReadLine();
        }

    }
}