using System.Globalization;

namespace MyApplication{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" Calcule e classifique o IMC.");

            double peso, altura, imc;

            Console.Write("informe seu peso:");
            peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("informe sua altura :");
            altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            
            imc = peso /(altura * altura);

            if (imc < 18)
            {
                Console.WriteLine($"Magreza , seu imc deu : {imc.ToString("F1")}");
            }
            else if (imc >= 18 && imc <= 24)
            {
                Console.WriteLine($"Normal, seu imc deu : {imc.ToString("F1")}");
            }
            else if(imc>=25 && imc<=29) {
                Console.WriteLine( $"Sobrepeso , seu imc deu :{imc.ToString("F1")}");
            }


                Console.ReadLine();
         
        }
    }
}