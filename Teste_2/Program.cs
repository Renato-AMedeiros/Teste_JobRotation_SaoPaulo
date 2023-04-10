namespace Teste_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int fib1 = 0;
            int fib2 = 1;
            bool encontrado = false;

            while (fib2 <= numero)
            {
                if (fib2 == numero)
                {
                    encontrado = true;
                    break;
                }
                int proximo = fib1 + fib2;
                fib1 = fib2;
                fib2 = proximo;
            }

            if (encontrado)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }
    }
}