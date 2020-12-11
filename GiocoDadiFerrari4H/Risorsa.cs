using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GiocoDadiFerrari4H
{
    class Risorsa
    {
        public List<char> vittorie;
        public string[] classifica;
        public int[] punti;
        public int Nord { get; private set; }
        public int Sud { get; private set; }
        public int Ovest { get; private set; }
        public int Est { get; private set; }
        public int[] lanci { get; private set; }
        int giocatore_attuale;
        public Risorsa()
        {
            vittorie = new List<char>();
            Nord = 0; Est = 1; Sud = 2; Ovest = 3;
            giocatore_attuale = 0;
            classifica = new string[] { "Nord", "Sud", "Est", "Ovest"};
            punti = new int[4];
            lanci = new int[4];
        }
        public int Turno
        {
            get { return giocatore_attuale; }
            set { giocatore_attuale = value; }
        }
        public string[] ClassificaTotale(string tema)
        {
            return AggiornaClassificaTotale(tema);
        }
        private void AggiungiVittoria(int turno)
        {
                int m = 0, max = -1;
                for (int i = 0; i < lanci.Length; i++)
                    if (lanci[i] > max)
                    {
                        m = i;
                        max = lanci[i];
                    }
                if (m == Nord)
                    vittorie.Add('N');
                else
                {
                    if (m == Sud)
                        vittorie.Add('S');
                    else
                    {
                        if (m == Est)
                            vittorie.Add('E');
                        else
                            vittorie.Add('O');
                    }
                }
            
        }
        private string[] OrdinaClassifica(string[] nomi, int[] valori, string tema)
        {
            string[] output = new string[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                    if (valori[j - 1] < valori[j])
                    {
                        int x = valori[j - 1];
                        valori[j - 1] = valori[j];
                        valori[j] = x;
                        string s = nomi[j - 1];
                        nomi[j - 1] = nomi[j];
                        nomi[j] = s;
                    }
            }
            for (int i = 0; i < 4; i++)
            {
                    switch (tema)
                    {
                        case "default":
                            if (nomi[i] == "Nord") nomi[i] = "Azzurro";
                            if (nomi[i] == "Sud") nomi[i] = "Grigio";
                            if (nomi[i] == "Est") nomi[i] = "Rosa";
                            if (nomi[i] == "Ovest") nomi[i] = "Viola";
                            break;
                        case "lotr":
                            if (nomi[i] == "Nord") nomi[i] = "Elrond";
                            if (nomi[i] == "Sud") nomi[i] = "Gandalf";
                            if (nomi[i] == "Est") nomi[i] = "Sauron";
                            if (nomi[i] == "Ovest") nomi[i] = "Galadriel";
                            break;
                        case "hp":
                            if (nomi[i] == "Nord") nomi[i] = "Serpeverde";
                            if (nomi[i] == "Sud") nomi[i] = "Tassorosso";
                            if (nomi[i] == "Est") nomi[i] = "Corvonero";
                            if (nomi[i] == "Ovest") nomi[i] = "Griffondoro";
                            break;
                        case "pirati":
                            if (nomi[i] == "Nord") nomi[i] = "Jack Sparrow";
                            if (nomi[i] == "Sud") nomi[i] = "Barbossa";
                            if (nomi[i] == "Est") nomi[i] = "Will Turner";
                            if (nomi[i] == "Ovest") nomi[i] = "Elisabeth Swan";
                            break;
                }
                output[i] = nomi[i] + " - " + valori[i];
            }
                
            return output;
        }
        private string[] AggiornaClassificaTotale(string tema)
        {
            string[] nomi = new string[4];
            nomi[Nord] = "Nord"; nomi[Sud] = "Sud"; nomi[Est] = "Est"; nomi[Ovest] = "Ovest";
            int cn = 0, ce = 0, cs = 0, co = 0;
            foreach (char c in vittorie)
                switch (c)
                {
                    case 'N': cn++; break;
                    case 'S': cs++; break;
                    case 'E': ce++; break;
                    case 'O': co++; break;
                }
            punti[Nord] = cn;
            punti[Sud] = cs;
            punti[Est] = ce;
            punti[Ovest] = co;
           return OrdinaClassifica(nomi, punti, tema);
        }
        public string[] ClassificaGiocata(string tema, int giocata)
        {
            if (giocata > vittorie.Count)
                AggiungiVittoria(giocata);
            string[] nomi = new string[4];
            nomi[Nord] = "Nord"; nomi[Sud] = "Sud"; nomi[Est] = "Est"; nomi[Ovest] = "Ovest";
            return OrdinaClassifica(nomi, lanci, tema);
            
        }
        public void SalvaLancio(int valore, int giocatore)
        {
            lanci[giocatore] = valore;
        }
        public void AggiornaGiocatori()
        {
            if (Nord < 3) Nord++; else Nord = 0;
            if (Est < 3) Est++; else Est = 0;
            if (Sud < 3) Sud++; else Sud = 0;
            if (Ovest < 3) Ovest++; else Ovest = 0;
        }
        public void AzzeraGiocata()
        {
            lanci = new int[4];
        }
    }
}
