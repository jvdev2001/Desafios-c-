namespace MyApplication {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Some números até que seja digitado 0.");

            int num , soma;

            soma = 0;
            
            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());

            while (num > 0) {

                soma = num + soma;
                Console.WriteLine("Digite um numero:");
                num = int.Parse(Console.ReadLine());



            }

           

            Console.Write($"soma dos numeros e {soma}");
            Console.ReadLine();


        }
    }
}