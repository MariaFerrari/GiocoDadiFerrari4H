using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDadiFerrari4H
{
    public partial class Form1 : Form
    {
        public int turni;
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //ciclo fino ai turni
                //verifica chi gioca: se giusto ok se no ritorno
                //gioco (lancio + salvo)
                //se sono l'ultimo:
                    //aggiornare la  classifica
                    //aggiornare la parte visuale
                    //azzerare la giocata
                    //aggiornare i giocatori
                    //aumentare il contatore dei turni
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lancio: continuo a generare e stampare numeri e lascio solo l'ultimo
            //fine turno: aggiorno le textbox
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void AggiornaGiocatori() { }
    }
    class Risorsa
    {
        public List<char> vittorie;
        int nord, sud, ovest, est;
        public int[] lanci;
        public Risorsa()
        {
            vittorie = new List<char>();
            nord = 0; est = 1; sud = 2; ovest = 3;
        }
        public void ClassificaTotale() { }
        public void ClassificaTurno() { }
        public void SalvaLancio(int valore, int giocatore) { }
        
    }
}
