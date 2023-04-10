namespace Teste_4
{
   public class Program
   {
        static void Main(string[] args)
        {

            decimal faturamentoSP = 67836.43m;
            decimal faturamentoRJ = 36678.66m;
            decimal faturamentoMG = 29229.88m;
            decimal faturamentoES = 27165.48m;
            decimal faturamentoOutros = 19849.53m;


            decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;


            decimal percentualSP = faturamentoSP / faturamentoTotal * 100m;
            decimal percentualRJ = faturamentoRJ / faturamentoTotal * 100m;
            decimal percentualMG = faturamentoMG / faturamentoTotal * 100m;
            decimal percentualES = faturamentoES / faturamentoTotal * 100m;
            decimal percentualOutros = faturamentoOutros / faturamentoTotal * 100m;


            Console.WriteLine($"Percentual de representação de SP: {percentualSP:f2}%");
            Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:f2}%");
            Console.WriteLine($"Percentual de representação de MG: {percentualMG:f2}%");
            Console.WriteLine($"Percentual de representação de ES: {percentualES:f2}%");
            Console.WriteLine($"Percentual de representação de outros estados: {percentualOutros:f2}%");
        }
   }
}
