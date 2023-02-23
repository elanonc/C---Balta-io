namespace Calculator 
{
    class Program 
    {
  
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("\nLista de operações: \n1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão \n5 - Sair \n\nEscolha uma operação: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float variavel1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float variavel2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = variavel1 + variavel2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float variavel1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float variavel2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = variavel1 - variavel2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float variavel1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float variavel2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = variavel1 * variavel2;
            Console.WriteLine("O resultado da multiplicação é " + (variavel1 * variavel2));
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float variavel1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float variavel2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = variavel1 / variavel2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}