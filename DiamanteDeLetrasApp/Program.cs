using System.Globalization;

namespace DiamanteDeLetrasApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            int letraA = 'A';
            int quantidadeEspacoInterior = -1;

            //Primeira parte

            Console.WriteLine("Coloque a letra central do nosso diamante: ");
            int letraInput = Console.ReadLine()[0];

            int quantidadeEspacosExterior = letraInput - letraA;

            for (char i = 'A'; i < letraInput; i++)
            {
                for (int j = 0; j < quantidadeEspacosExterior; j++)
                {
                    Console.Write(" ");
                }

                char letraAtual = Convert.ToChar(i);

                Console.Write(letraAtual);

                for (int k = 0; k < quantidadeEspacoInterior; k++)
                {
                    Console.Write(" ");
                }

                if (i != letraA) {
                Console.Write(letraAtual);
                }

                quantidadeEspacoInterior += 2;
                quantidadeEspacosExterior--;
                Console.WriteLine();
            }

            //Segunda parte

            for (int i = letraInput; i >= 'A'; i--)
            {
                for (int j = 0; j < quantidadeEspacosExterior; j++)
                {
                    Console.Write(" ");
                }

                char letraAtual = Convert.ToChar(i);

                Console.Write(letraAtual);

                for (int k = 0; k < quantidadeEspacoInterior; k++)
                {
                    Console.Write(" ");
                }

                if (i != letraA)
                {
                    Console.Write(letraAtual);
                }

                quantidadeEspacoInterior -= 2;
                quantidadeEspacosExterior++;
                Console.WriteLine();
                }

            Console.ReadLine();
        }

    } 
}
