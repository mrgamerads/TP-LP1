/*
internal class Program
{
    private static void Main(string[] args)
    {
        double diag1, diag2, diag3, diag4;
        double diagTot;

        Console.WriteLine("Digite o valor da Diagonal");
        diag1 = Convert.ToDouble(Console.ReadLine());

        diag2 = diag1;
        diag3 = diag2;
        diag4 = diag3;

        diagTot = diag1 + diag2 + diag3 +diag4;

        Console.WriteLine("O valor total do quadrado é de: " + diagTot);


    }

internal class Ex06
    {
        private static void Main(string[] args)
        {
            int p1, p2, media, mediaFinal;

            Console.WriteLine("Digite a nota da P1: ");
            p1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota da P2: ");
            p2 = Convert.ToInt32(Console.ReadLine());

            media = p1 + p2 * 2;

            mediaFinal = media / 3;

            Console.WriteLine("A média total do Aluno é: " + mediaFinal);
            
            if (mediaFinal >= 7) {
            Console.WriteLine("Aluno Aprovado!");
            }
            else
            {
            Console.WriteLine("Aluno Reprovado");
            }
        

        }
    }
*/

internal class Ex07
{
    private static void Main(string[] args)
    {
        int medGeo;

        Console.WriteLine("Digite um valor: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro valor: ");
        int b = int.Parse(Console.ReadLine());

        medGeo = (int)Math.Sqrt(a * a + b * b);

        Console.WriteLine("A media geografica dos valores é de: " + medGeo);

    }

}