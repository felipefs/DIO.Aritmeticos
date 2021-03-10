using System;

/*
A primeira linha da entrada contém um único inteiro T, 
indicando o número de casos de teste (1 ≤ T ≤ 3000). 

Cada caso de teste contém 4 números: 

dois inteiros PA e PB (100 ≤ PA < 1000000, PA < PB ≤ 1000000) 
indicando respectivamente a população de A e B, 

e dois valores G1 e G2 (0.1 ≤ G1 ≤ 10.0, 0.0 ≤ G2 ≤ 10.0, G2 < G1) com um digito após o ponto decimal cada, 
indicando respectivamente o crescimento populacional de A e B (em percentual).

6
100 150 1.0 0           -> 51 anos.
90000 120000 5.5 3.5    -> 16 anos.
56700 72000 5.2 3.0     -> 12 anos.
123 2000 3.0 2.0        -> Mais de 1 seculo.
100000 110000 1.5 0.5   -> 10 anos.
62422 484317 3.1 1.0    -> 100 anos.

*/

namespace DIO.Aritmeticos
{
    public class CrescimentoPopulacional
    {
        public static void CalculaCrescimentoPopulacional()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            // (1 ≤ T ≤ 3000)
            if  (t < 1 || t > 3000
            ){
                Console.Write("Você deve digitar um numero entre 1 até 3000");
                return;
            }

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);
                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]); ;


                // (100 ≤ PA < 1000000,          PA < PB ≤ 1000000)
                if (pa < 100 || pa >= 1000000 || pa >= pb || pb > 1000000)
                {
                    //Console.WriteLine("Parâmetro população incorreto.");
                    //break;
                }

                //  (0.1 ≤ G1 ≤ 10.0,        0.0 ≤ G2 ≤ 10.0, G2 < G1)
                if (cpa < 0.1 || cpa > 10.0 || cpb < 0.0 || cpb > 10.0 || cpb >= cpa)
                {
                    //Console.WriteLine("Parâmetro crescimento da população incorreto.");
                    //break;
                }

                while (pa <= pb)
                {

                    //complete o while
                    anos++;
                    pa += Convert.ToInt32(Math.Floor(pa * (cpa/100))); 
                    pb += Convert.ToInt32(Math.Floor(pb * (cpb/100))); 


                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine("{0} anos.", anos);
                }

            }
        }

    }
}