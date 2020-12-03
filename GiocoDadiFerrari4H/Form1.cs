using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GiocoDadiFerrari4H
{
    public partial class Form1 : Form
    {
        Risorsa r;
        public int ultimo_turno;
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            r = new Risorsa();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            int turno = 1, dado = 0;
            bool ok;
            while (turno <= ultimo_turno)
            {
                lock (r)
                {
                    if (r.Giocatore == r.Nord && bgw == bgw_nord)
                        ok = true;
                    else
                        if (r.Giocatore == r.Est && bgw == bgw_est)
                        ok = true;
                    else
                        if (r.Giocatore == r.Sud && bgw == bgw_sud)
                        ok = true;
                    else
                        if (r.Giocatore == r.Ovest && bgw == bgw_ovest)
                        ok = true;
                    else
                        ok = false;

                    if (ok)
                    {
                        int d1, d2;
                        d1 = rnd.Next(1, 7);
                        d2 = rnd.Next(1, 7);
                        dado = d1 + d2;
                        bgw.ReportProgress(r.Giocatore, (d1, d2));
                        r.SalvaLancio(dado, r.Giocatore);
                    }
                    else
                        return;
                    if (r.Giocatore == 3)
                    {
                        
                    }
                    //se sono l'ultimo:
                    //aggiornare la  classifica
                    //aggiornare la parte visuale
                    //azzerare la giocata
                    //aggiornare i giocatori
                    //aumentare il contatore dei turni
                    // se no ritorno

                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lancio: continuo a generare e stampare numeri e lascio solo l'ultimo
            //fine turno: aggiorno le textbox
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
    class Risorsa
    {
        public List<char> vittorie;
        public string[] classifica;
        public int[] punti;
        public int Nord { get; }
        public int Sud { get; }
        public int Ovest { get; }
        public int Est { get; }
        public int[] lanci;
        int giocatore_attuale;
        public Risorsa()
        {
            vittorie = new List<char>();
            Nord = 0; Est = 1; Sud = 2; Ovest = 3;
            giocatore_attuale = 0;
        }
        public int Giocatore
        {
            get { return giocatore_attuale; }
            set { giocatore_attuale = value; }
        }
        void AggiungiVittoria()
        {
            int m = 0, max = -1;
            for (int i = 0; i < lanci.Length; i++)
                if(lanci[i]>max)
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
        public void AggiornaClassificaTotale() 
        {
            AggiungiVittoria();

        }
        public string[] ClassificaTurno() 
        {
            string[] nomi = new string[4];
            nomi[Nord] = "Nord"; nomi[Sud] = "Sud"; nomi[Est] = "Est"; nomi[Ovest] = "Ovest";
            for (int i=0; i<4; i++)
            {
                for(int j=1; j<4; j++)
                    if(lanci[j-1]<lanci[j])
                    {
                        int x = lanci[j - 1];
                        lanci[j - 1] = lanci[j];
                        lanci[j] = x;
                        string s = nomi[j - 1];
                        nomi[j - 1] = nomi[j];
                        nomi[j] = s;
                    }
            }
            return nomi;
        }
        public void SalvaLancio(int valore, int giocatore) 
        {
            lanci[giocatore] = valore;
        }
        public void AggiornaGiocatori() { }

    }
}
