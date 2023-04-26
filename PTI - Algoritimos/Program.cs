internal class Program
{
    private static void Main(string[] args)
    {
        bool resposta = true;
        while (resposta)
        {
            Console.Write("Qual é o valor da gasolina?");
            double gasolina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual é o valor do álcool?");
            double alcool = Convert.ToDouble(Console.ReadLine());

            double parametro = 0.7;
            double resultado = alcool/gasolina;

            if (resultado > parametro) {
                Console.WriteLine("Gasolina é mais vantajoso");
            }
            else if (resultado < parametro) {
                Console.WriteLine("Alcool é mais vantajoso");
            }
            else {
                Console.WriteLine("Abasteça com qualquer uma das opções");
            }
            Console.WriteLine("Deseja calcular novamente?");
            string x = Console.ReadLine();
            if (x.ToUpper() != "S") {
                resposta = false;
            }
        }
    }
}