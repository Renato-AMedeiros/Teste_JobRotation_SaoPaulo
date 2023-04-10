﻿namespace Teste_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dados de entrada fornecido pela empresa
            var faturamentoDiario = new List<(int dia, double valor)>
            {
                 (1, 22174.1664),
                 (2, 24537.6698),
                 (3, 26139.6134),
                 (4, 0.0),
                 (5, 0.0),
                 (6, 26742.6612),
                 (7, 0.0),
                 (8, 42889.2258),
                 (9, 46251.174),
                 (10, 11191.4722),
                 (11, 0.0),
                 (12, 0.0),
                 (13, 3847.4823),
                 (14, 373.7838),
                 (15, 2659.7563),
                 (16, 48924.2448),
                 (17, 18419.2614),
                 (18, 0.0),
                 (19, 0.0),
                 (20, 35240.1826),
                 (21, 43829.1667),
                 (22, 18235.6852),
                 (23, 4355.0662),
                 (24, 13327.1025),
                 (25, 0.0),
                 (26, 0.0),
                 (27, 25681.8318),
                 (28, 1718.1221),
                 (29, 13220.495),
                 (30, 8414.61)
            };


            double menorValor = faturamentoDiario.Min(x => x.valor);


            double maiorValor = faturamentoDiario.Max(x => x.valor);


            double mediaMensal = faturamentoDiario.Average(x => x.valor);


            int diasAcimaMedia = faturamentoDiario.Count(x => x.valor > mediaMensal);


            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
            Console.WriteLine($"Dias com valor acima da média: {diasAcimaMedia}");
        }
    }
}