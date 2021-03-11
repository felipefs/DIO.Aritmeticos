using System;

namespace DIO.Aritmeticos
{
    public class ComunicacaoPiralandia
    {
        public static void Traduz()
        {

            string n = Console.ReadLine();
            string _tmp = "";

            for (int x = n.Length; x >= 1; x--)
            {
                _tmp += n.Substring(x - 1, 1);
            }

            Console.WriteLine(_tmp);

        }
    }
}