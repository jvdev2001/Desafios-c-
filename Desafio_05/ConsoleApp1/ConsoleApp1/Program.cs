namespace Myaplication {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia a nota de um aluno e informe se ela é maior que 7.");

            double nota;

            Console.WriteLine("Informe a nota do aluno :");

            nota = double.Parse(Console.ReadLine());

            bool maior = nota > 7;

            Console.WriteLine(maior);

            Console.ReadLine();
        }
    }    
}