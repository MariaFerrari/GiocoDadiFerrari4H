using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GiocoDadiFerrari4H
{
    public partial class FormNormale : Form
    {
        Risorsa r;
        public string[] Classifica
        {
            get 
            {
                //if (_default)
                //    return r.ClassificaTotale("default");
                //if (_hp)
                //    return r.ClassificaTotale("hp");
                //if (_lotr)
                //    return r.ClassificaTotale("lotr");
                //if(_pirates)
                //    return r.ClassificaTotale("pirati");
                //else
                //    return r.ClassificaTotale("default");
                return r.ClassificaTotale;
            }
        }
        int giocata;
        public Random rnd = new Random();
        bool _default, _lotr, _hp, _pirates;
        public FormNormale()
        {
            //ELIMINA FORM SECONDARIO, METTI PICTUREBOX
            InitializeComponent();
            r = new Risorsa();
            giocata = 1;
            pb_nord_turno.Hide();
            pb_est_turno.Hide();
            pb_sud_turno.Hide();
            pb_ovest_turno.Hide();
            NascondiDadi();
            btn_stop.Hide();
            bgw_nord.RunWorkerAsync();
            bgw_est.RunWorkerAsync();
            bgw_sud.RunWorkerAsync();
            bgw_ovest.RunWorkerAsync();
            _default = true; _hp = false; _lotr = false; _pirates = false;
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            if (bgw.CancellationPending) return;
            int d1, d2;
            do
            {
                lock (r)
                {
                    Giro(bgw);
                    if (bgw == bgw_nord && r.Turno == r.Nord)
                        Turno(bgw, out d1, out d2, r.Nord);
                    if (bgw == bgw_est && r.Turno == r.Est)
                        Turno(bgw, out d1, out d2, r.Est); 
                    if (bgw == bgw_sud && r.Turno == r.Sud)
                        Turno(bgw, out d1, out d2, r.Sud); 
                    if (bgw == bgw_ovest && r.Turno == r.Ovest)
                        Turno(bgw, out d1, out d2, r.Ovest);
                }
                Thread.Sleep(1000);
            }
            while (!bgw.CancellationPending);
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            var bgw = sender as BackgroundWorker;
            if(e.ProgressPercentage==-1)
            {
                if (bgw == bgw_nord) pb_nord_turno.Hide();
                if (bgw == bgw_est) pb_est_turno.Hide();
                if (bgw == bgw_sud) pb_sud_turno.Hide();
                if (bgw == bgw_ovest) pb_ovest_turno.Hide();
            }
            else
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage < 4)
            {
                int[] dadi = (int[])e.UserState;
                if (bgw == bgw_nord)
                {
                    pb_nord_turno.Show();
                    TurnoVisuale(dadi);
                }
                else if (bgw == bgw_sud)
                {
                    pb_sud_turno.Show();
                    TurnoVisuale(dadi);
                }
                else if (bgw == bgw_est)
                {
                    pb_est_turno.Show();
                    TurnoVisuale(dadi);
                }
                else if(bgw==bgw_ovest)
                {
                    pb_ovest_turno.Show();
                    TurnoVisuale(dadi);
                }
            }
            if (e.ProgressPercentage==4)
            {
                List<string[]> parametri = e.UserState as List<string[]>;
                string[] classifica_turno = parametri[0];
                string[] classifica_partita = parametri[1];
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                        tb_class_turno.Text = classifica_turno[i] + Environment.NewLine;
                    else
                        tb_class_turno.Text += classifica_turno[i] + Environment.NewLine;
                }
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                        tb_class_partita.Text = classifica_partita[i] + Environment.NewLine;
                    else
                        tb_class_partita.Text += classifica_partita[i] + Environment.NewLine;
                }
                if (giocata > 1)
                    btn_stop.Show();
                btn_default.Show();
                btn_lotr.Show();
                btn_hp.Show();
                btn_pirati.Show();
                groupBox1.Show();
            }
            if (e.ProgressPercentage == 5)
            {
                int[] parametri = (int[])e.UserState;
                int d1 = parametri[0];
                int d2 = parametri[1];
                int random1 = parametri[2];
                int random2 = parametri[3];
                if (parametri[4] == 0)
                    MostraDado(random1, random2, 700);
                else
                    MostraDado(d1, d2, 700);
            }
            if (e.ProgressPercentage == 6) NascondiDadi();
            if (e.ProgressPercentage == 7) 
            {
                string[] ordine = new string[4];
                //if (_default)
                //{
                    ordine[r.Nord] = "Azzurro";
                    ordine[r.Sud] = "Grigio";
                    ordine[r.Est] = "Rosa";
                    ordine[r.Ovest] = "Viola";
                //}
                //if (_lotr)
                //{
                //    ordine[r.Nord] = "Elrond";
                //    ordine[r.Sud] = "Gandalf";
                //    ordine[r.Est] = "Sauron";
                //    ordine[r.Ovest] = "Galadriel";
                //}
                //if (_hp)
                //{
                //    ordine[r.Nord] = "Slytherin";
                //    ordine[r.Sud] = "Hufflepuff";
                //    ordine[r.Est] = "Ravenclaw";
                //    ordine[r.Ovest] = "Gryffindor";
                //}
                //if (_pirates)
                //{
                //    ordine[r.Nord] = "Jack Sparrow";
                //    ordine[r.Sud] = "Barbossa";
                //    ordine[r.Est] = "Will Turner";
                //    ordine[r.Ovest] = "Elisabeth Swan";
                //}
                for (int i = 1; i <= 4; i++)
                    if (i > 1)
                        tb_giro.Text += string.Format("{0}) {1}" + Environment.NewLine, i, ordine[i - 1]);
                    else
                        tb_giro.Text = string.Format("{0}) {1}" + Environment.NewLine, i, ordine[i - 1]);
                
            }
            if (e.ProgressPercentage == 8)
            {
                btn_default.Hide();
                btn_lotr.Hide();
                btn_hp.Hide();
                btn_pirati.Hide();
                groupBox1.Hide();
                btn_stop.Hide();
            }
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            if ((bgw == bgw_nord && r.Nord == 3) || (bgw == bgw_sud && r.Sud == 3) || (bgw == bgw_est && r.Est == 3) || (bgw == bgw_ovest && r.Ovest == 3)) 
            {
                FormPodio fp = new FormPodio();
                fp.VisualizzaClassifica(Classifica);
                if (fp.ShowDialog() == DialogResult.OK)
                {
                    r = new Risorsa();
                    giocata = 1;
                    pb_nord_turno.Hide();
                    pb_est_turno.Hide();
                    pb_sud_turno.Hide();
                    pb_ovest_turno.Hide();
                    NascondiDadi();
                    btn_stop.Hide();
                    bgw_nord.RunWorkerAsync();
                    bgw_est.RunWorkerAsync();
                    bgw_sud.RunWorkerAsync();
                    bgw_ovest.RunWorkerAsync();
                }
                else if (fp.ShowDialog() == DialogResult.Cancel) this.Close();
            }
        }
        private void Turno(BackgroundWorker bgw, out int d1, out int d2, int giocatore)
        {
            bgw.ReportProgress(8);
            d1 = rnd.Next(1, 7);
            d2 = rnd.Next(1, 7);
            r.SalvaLancio(d1 + d2, giocatore);

            int[] dadi = { d1, d2, d1 + d2 };
            bgw.ReportProgress(r.Turno, dadi);
            Thread.Sleep(50);
            for (int i = 0; i <= 10; i++)
            {
                int boolean = 0;
                if (i == 10) boolean = 1;
                int[] dadi2 = { d1, d2, rnd.Next(1, 7), rnd.Next(1, 7), boolean };
                bgw.ReportProgress(5, dadi2);
                Thread.Sleep(50);
                if (boolean == 0)
                    bgw.ReportProgress(6);
            }
            Thread.Sleep(3000);
            bgw.ReportProgress(6);
            if (r.Turno == 3)
            {
                string tema;
                //if (_default) tema = "default";
                //else if (_lotr) tema = "lotr";
                //else if (_hp) tema = "hp";
                //else if (_pirates) tema = "pirati";
                //else tema = "default";
                string[] classifica_turno = r.ClassificaTurno;//(tema);
                string[] classifica_partita = r.ClassificaTotale;//(tema);
                List<string[]> parametri = new List<string[]>();
                parametri.Add(classifica_turno);
                parametri.Add(classifica_partita);
                bgw.ReportProgress(4, parametri);
                Thread.Sleep(10000);
                r.AggiornaGiocatori();
                r.AzzeraGiocata();
                giocata++;
                r.Turno = 0;
            }
            else r.Turno++;
            bgw.ReportProgress(-1);
        }
        private void TurnoVisuale(int[] dadi)
        {
            for (int i = 0; i < 5; i++)
            {
                MostraDado(rnd.Next(1, 7), rnd.Next(1, 7), 700);
            }
            MostraDado(dadi[0], dadi[1], 1000);
        }
        private void NascondiDadi()
        {
            pb_d1_1.Hide();
            pb_d1_2.Hide();
            pb_d1_3.Hide();
            pb_d1_4.Hide();
            pb_d1_5.Hide();
            pb_d1_6.Hide();
            pb_d2_1.Hide();
            pb_d2_2.Hide();
            pb_d2_3.Hide();
            pb_d2_4.Hide();
            pb_d2_5.Hide();
            pb_d2_6.Hide();
        }
        private void MostraDado(int dado1, int dado2, int tempo)
        {
            switch (dado1)
            {
                case 1:
                    pb_d1_1.Show();
                    break;
                case 2:
                    pb_d1_2.Show();
                    break;
                case 3:
                    pb_d1_3.Show();
                    break;
                case 4:
                    pb_d1_4.Show();
                    break;
                case 5:
                    pb_d1_5.Show();
                    break;
                case 6:
                    pb_d1_6.Show();
                    break;
            }
            switch (dado2)
            {
                case 1:
                    pb_d2_1.Show();
                    break;
                case 2:
                    pb_d2_2.Show();
                    break;
                case 3:
                    pb_d2_3.Show();
                    break;
                case 4:
                    pb_d2_4.Show();
                    break;
                case 5:
                    pb_d2_5.Show();
                    break;
                case 6:
                    pb_d2_6.Show();
                    break;
            }
            //tb_d1.Text = dado1.ToString();
            //tb_d2.Text = dado2.ToString();
        }
        private void Giro(BackgroundWorker bgw)
        {
            bool ok = false;
            if (bgw == bgw_nord && r.Turno == r.Nord && r.Turno == 0)
                ok = true;
            if (bgw == bgw_est && r.Turno == r.Est && r.Turno == 0)
                ok = true;
            if (bgw == bgw_sud && r.Turno == r.Sud && r.Turno == 0)
                ok = true;
            if (bgw == bgw_ovest && r.Turno == r.Ovest && r.Turno == 0)
                ok = true;
            if (ok)
                bgw.ReportProgress(7);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btn_lotr_Click(object sender, EventArgs e)
        {
            _default = false; _hp = false; _lotr = true; _pirates = false;
            btn_default.Hide();
            btn_lotr.Hide();
            btn_hp.Hide();
            btn_pirati.Hide();
            groupBox1.Hide();
            btn_stop.Hide();
        }

        private void btn_hp_Click(object sender, EventArgs e)
        {
            _default = false; _hp = true; _lotr = false; _pirates = false;
            btn_default.Hide();
            btn_lotr.Hide();
            btn_hp.Hide();
            btn_pirati.Hide();
            groupBox1.Hide();
            btn_stop.Hide();
        }

        private void btn_pirati_Click(object sender, EventArgs e)
        {
            _default = false; _hp = false; _lotr = false; _pirates = true;
            btn_default.Hide();
            btn_lotr.Hide();
            btn_hp.Hide();
            btn_pirati.Hide();
            groupBox1.Hide();
            btn_stop.Hide();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            bgw_nord.CancelAsync();
            bgw_est.CancelAsync();
            bgw_sud.CancelAsync();
            bgw_ovest.CancelAsync();
        }
        private void btn_rivincita_Click(object sender, EventArgs e)
        {
            r = new Risorsa();
            giocata = 1;
            pb_nord_turno.Hide();
            pb_est_turno.Hide();
            pb_sud_turno.Hide();
            pb_ovest_turno.Hide();
            NascondiDadi();
            btn_stop.Hide();
            bgw_nord.RunWorkerAsync();
            bgw_est.RunWorkerAsync();
            bgw_sud.RunWorkerAsync();
            bgw_ovest.RunWorkerAsync();
        }
        private void btn_default_Click(object sender, EventArgs e)
        {
            _default = true; _hp = false; _lotr = false; _pirates = false;
            btn_default.Hide();
            btn_lotr.Hide();
            btn_hp.Hide();
            btn_pirati.Hide();
            groupBox1.Hide();
            btn_stop.Hide();
        }
    }
}


