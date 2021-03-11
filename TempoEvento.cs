using System;

namespace DIO.Aritmeticos
{
    public class TempoEvento
    {
        public static void CalculaTempoDeUmEvento()
        {

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            // DENTRO DE ABRIL
            int Mes = 05;
            int Ano = 2011;

            // DIA 15
            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            // hh : mm : ss
            string[] dadosMomentoInicio = Console.ReadLine().Split(" : ");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);

            // DIA 31
            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            // hh : mm : ss
            string[] dadosMomentoTermino = Console.ReadLine().Split(" : ");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);

            //  W dia(s)
            //  X hora(s)
            //  Y minuto(s)
            //  Z segundo(s)

            DateTime _dataini = new DateTime(Ano, Mes, diaInicio, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio);
            DateTime _datafin = new DateTime(Ano, Mes, diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio);
            TimeSpan _dif = _datafin.Subtract(_dataini);

            int W = _dif.Days; 
            int X = _dif.Hours;
            int Y = _dif.Minutes;
            int Z = _dif.Seconds;

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);
        }
    }
}