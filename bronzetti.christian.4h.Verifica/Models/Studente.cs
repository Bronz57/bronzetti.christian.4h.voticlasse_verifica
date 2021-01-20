using System;
using System.Collections.Generic;
using System.Text;

namespace bronzetti.christian._4h.Verifica.Models
{
    class Studente
    {
        private string _cognome;
        private int _numeroAssenze =0;
        private int[] _voti = new int [100];

        public double Media;
        public int NumeroAssenze 
        { 
            get
            {
                return _numeroAssenze;
            }
            
            set
            {
                _numeroAssenze = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }

            set
            {
                _cognome = value;
            }
        }
        
        public Studente(string c, int nA)
        {
            _cognome = c;
            _numeroAssenze = nA;
        }

        public int InserisciAssenza()
        {
            NumeroAssenze++;
            return NumeroAssenze;
        }

        public void InserisciVoto(int v, int i)
        {
       
            if (v > 0 && v < 31)
                _voti[i]= v;
        
        }

        public double CalcolaMedia ()
        {
           Media = 0;
           int i = 0;
            int j = 0;
            for (i=0; i < _voti.Length; i++)
            {
                if (_voti[i] > 0)
                    j++;

                   Media += _voti[i];
            }
                

            Media /= j;

            return Media;
        }
        // public override string ToString() =>$"Studente: {_cognome} \t Assenze: {_numeroAssenze}";

        public override string ToString() => $"Studente: {_cognome} \t Media: {Media}";

    }
}
