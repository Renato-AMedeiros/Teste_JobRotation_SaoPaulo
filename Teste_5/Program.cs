namespace Teste_5
{
    public class Program
    {
        static void Main(string[] args)
        {

            string minhaString = "Exemplo de string para ser invertida.";


            char[] chars = minhaString.ToCharArray();


            int i = 0;
            int j = chars.Length - 1;
            while (i < j)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                i++;
                j--;
            }


            string stringInvertida = new string(chars);


            Console.WriteLine(stringInvertida);
        }
    }
}