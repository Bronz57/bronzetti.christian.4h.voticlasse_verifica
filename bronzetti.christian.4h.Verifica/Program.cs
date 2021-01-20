using System;
using bronzetti.christian._4h.Verifica.Models;
using System.IO;

namespace bronzetti.christian._4h.Verifica
{
    class Program
    {
        static void Main(string[] args)
        { 

            StreamReader sr = new StreamReader(@"ElencoStudenti.txt");
            
            Studente[] vettS = new Studente[25];
            int i;
            string strC;

            for (i = 0; i < vettS.Length; i++)
            {
                    strC = sr.ReadLine();

                    vettS[i] = new Studente(strC, 0);
             }

            sr.Close();

            vettS[1].InserisciAssenza();
            vettS[2].InserisciAssenza();
            vettS[2].InserisciAssenza();

            vettS[0].InserisciVoto(30, 0);
            vettS[0].InserisciVoto(25, 1);

            Random n = new Random();
            for (i = 0; i < vettS.Length; i++)
                vettS[i].InserisciVoto(n.Next(1, 30), i);


            for (i = 0; i < vettS.Length; i++)
                vettS[i].CalcolaMedia();

            foreach(Studente s in vettS)
                Console.WriteLine(s);

        }
    }
}
