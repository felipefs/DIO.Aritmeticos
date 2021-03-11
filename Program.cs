using System;

namespace DIO.Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Desafio DIO!");
                Console.WriteLine("Escolha as opções:");
                Console.WriteLine("1 - Opção Cálculo de Média.");
                Console.WriteLine("2 - Opção Cálculo de Crescimento Populacional.");
                Console.WriteLine("3 - Opção Cálculo Bazinga.");
                Console.WriteLine("4 - Opção Cálculo Tempo de um Evento.");
                Console.WriteLine("6 - Sair.");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Media.CalculaMedia();
                        break;
                    case 2:
                        CrescimentoPopulacional.CalculaCrescimentoPopulacional();
                        break;

                    case 3:
                        Bazinga.CalculoBazinga();
                        break;

                    case 4:
                        TempoEvento.CalculaTempoDeUmEvento();
                        break;

                    case 6:
                        Console.WriteLine("Até Mais!");
                        break;


                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }
    }
}
