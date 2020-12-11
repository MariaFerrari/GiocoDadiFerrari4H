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
    public partial class FormNormale1 : Form
    {
       
        Risorsa r;
        int giocata;
        public Random rnd = new Random();
        bool _default, _lotr, _hp, _pirati;
        string tema; //usata nel RunWorkerCompleted per passarla al podio, globale perché gestita dai pulsanti
        public string[] Classifica
        {
            get
            {
                if (_default)
                    return r.ClassificaTotale("default");
                if (_hp)
                    return r.ClassificaTotale("hp");
                if (_lotr)
                    return r.ClassificaTotale("lotr");
                if (_pirati)
                    return r.ClassificaTotale("pirati");
                else
                    return r.ClassificaTotale("default");
            }
        } //usata nel RunWorkerCompleted per passarla al podio
        public FormNormale1()
        {
            InitializeComponent();
            r = new Risorsa(); //inizializzazione risorsa
            tema = "default"; //imposto il tema, 
            _default = true; _hp = false; _lotr = false; _pirati = false; //inizializzazione variabili globali per il tema
            giocata = 1; //turno in svolgimento (usato per la stampa riga: 117)
            //immagini per la picturebox: default no turno
            pb_nord_turno.Hide();
            pb_est_turno.Hide();
            pb_sud_turno.Hide();
            pb_ovest_turno.Hide(); 
            NascondiDadi(); //nascondo i dadi
            btn_inizio.Show(); //il pulsante è visibile == posso premerlo e iniziare
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            int d1, d2; //dadi
            do
            {
                if (bgw.CancellationPending) return; //se bgw.RunWorkwerAsync() è stato chiamato, esco.
                lock (r) //lock sulla risorsa
                {
                    MostraGiro(bgw); //chiamo la funzione per visualizzare l'ordine dei giocatori 
                    if (bgw == bgw_nord && r.Turno == r.Nord) //se sono il nord ed è il turno di nord
                        Turno(bgw, out d1, out d2, r.Nord); //svolgo il turno
                    if (bgw == bgw_est && r.Turno == r.Est) 
                        Turno(bgw, out d1, out d2, r.Est); 
                    if (bgw == bgw_sud && r.Turno == r.Sud)
                        Turno(bgw, out d1, out d2, r.Sud); 
                    if (bgw == bgw_ovest && r.Turno == r.Ovest)
                        Turno(bgw, out d1, out d2, r.Ovest);
                }
                Thread.Sleep(1000); //si dà il tempo di eseguire
            }
            while (!bgw.CancellationPending);
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            if(e.ProgressPercentage==-1)
            {
                //si nascondo le picturebox indicanti il giocatore quando è il suo turno
                if (bgw == bgw_nord) pb_nord_turno.Hide();
                if (bgw == bgw_est) pb_est_turno.Hide();
                if (bgw == bgw_sud) pb_sud_turno.Hide();
                if (bgw == bgw_ovest) pb_ovest_turno.Hide();
            }
            else
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage < 4)
            {
                //si mostra la picture box indicante che il giocatore sta svolgendo il turno
                if (bgw == bgw_nord)
                {
                    pb_nord_turno.Show();
                }
                else if (bgw == bgw_sud)
                {
                    pb_sud_turno.Show();
                }
                else if (bgw == bgw_est)
                {
                    pb_est_turno.Show();
                }
                else if(bgw==bgw_ovest)
                {
                    pb_ovest_turno.Show();
                }
            }
            if (e.ProgressPercentage==4)
            {
                List<string[]> parametri = e.UserState as List<string[]>;
                //si aggiunge a ogni textbox la classifica del proprio tema
                //quando uno dei quattro pulsanti viene premuto, sarà mostrata la textbox corretta
                for (int i = 0; i <= 4; i++)
                {
                    if (i == 0)
                    {
                        tb_class_turno.Text = " TURNO - " + giocata + Environment.NewLine; 
                        tb_class_turno_lotr.Text = " TURNO - " + giocata + Environment.NewLine;
                        tb_class_turno_hp.Text = " TURNO - " + giocata + Environment.NewLine;
                        tb_class_turno_pirati.Text = " TURNO - " + giocata + Environment.NewLine;

                        tb_class_partita.Text = " - CLASSIFICA - " + Environment.NewLine;
                        tb_class_partita_lotr.Text = " - CLASSIFICA - " + Environment.NewLine;
                        tb_class_partita_hp.Text = " - CLASSIFICA - " + Environment.NewLine;
                        tb_class_partita_pirati.Text = " - CLASSIFICA - " + Environment.NewLine;
                    }
                    else
                    {
                        tb_class_turno.Text += parametri[0][i - 1] + Environment.NewLine;
                        tb_class_turno_lotr.Text += parametri[2][i - 1] + Environment.NewLine;
                        tb_class_turno_hp.Text += parametri[4][i - 1] + Environment.NewLine;
                        tb_class_turno_pirati.Text += parametri[6][i - 1] + Environment.NewLine;

                        tb_class_partita.Text += parametri[1][i - 1] + Environment.NewLine;
                        tb_class_partita_lotr.Text += parametri[3][i - 1] + Environment.NewLine;
                        tb_class_partita_hp.Text += parametri[5][i - 1] + Environment.NewLine;
                        tb_class_partita_pirati.Text += parametri[7][i - 1] + Environment.NewLine;
                    }
                }
            }
            if (e.ProgressPercentage == 5)
            {
                int[] parametri = (int[])e.UserState;
                int dado1 = parametri[0];
                int dado2 = parametri[1];
                //si mostrano le picturebox nascoste alla fine della giocata precedente
                pb_d1.Show();
                pb_d2.Show();
                //a seconda dei valori dei due dadi viene cambiata l'immagine della picturebox
                switch (dado1)
                {
                    case 1:
                        pb_d1.Image = Properties.Resources.Dado_1_norm;
                        break;
                    case 2:
                        pb_d1.Image = Properties.Resources.Dado_2_norm;
                        break;
                    case 3:
                        pb_d1.Image = Properties.Resources.Dado_3_norm;
                        break;
                    case 4:
                        pb_d1.Image = Properties.Resources.Dado_4_norm;
                        break;
                    case 5:
                        pb_d1.Image = Properties.Resources.Dado_5_norm;
                        break;
                    case 6:
                        pb_d1.Image = Properties.Resources.Dado_6_norm;
                        break;
                }
                switch (dado2)
                {
                    case 1:
                        pb_d2.Image = Properties.Resources.Dado_1_norm;
                        break;
                    case 2:
                        pb_d2.Image = Properties.Resources.Dado_2_norm;
                        break;
                    case 3:
                        pb_d2.Image = Properties.Resources.Dado_3_norm;
                        break;
                    case 4:
                        pb_d2.Image = Properties.Resources.Dado_4_norm;
                        break;
                    case 5:
                        pb_d2.Image = Properties.Resources.Dado_5_norm;
                        break;
                    case 6:
                        pb_d2.Image = Properties.Resources.Dado_6_norm;
                        break;
                }
            }
            if (e.ProgressPercentage == 6) NascondiDadi();
            if (e.ProgressPercentage == 7) 
            {
                //si salvano i nomi dei giocatori nei vari array di stringhe nella posizione corretta
                string[] ordine = new string[4];
                string[] ordine_lotr = new string[4];
                string[] ordine_hp = new string[4];
                string[] ordine_pirati = new string[4];
                ordine[r.Nord] = "Azzurro";
                ordine[r.Sud] = "Grigio";
                ordine[r.Est] = "Rosa";
                ordine[r.Ovest] = "Viola";
                ordine_lotr[r.Nord] = "Elrond";
                ordine_lotr[r.Sud] = "Gandalf";
                ordine_lotr[r.Est] = "Sauron";
                ordine_lotr[r.Ovest] = "Galadriel";
                ordine_hp[r.Nord] = "Serpeverde";
                ordine_hp[r.Sud] = "Tassorosso";
                ordine_hp[r.Est] = "Corvonero";
                ordine_hp[r.Ovest] = "Grifondoro";
                ordine_pirati[r.Nord] = "Jack Sparrow";
                ordine_pirati[r.Sud] = "Barbossa";
                ordine_pirati[r.Est] = "Will Turner";
                ordine_pirati[r.Ovest] = "Elisabeth Swan";
                //si aggiunge a ogni textbox il giro del proprio tema
                //quando uno dei quattro pulsanti viene premuto, sarà mostrata la textbox corretta
                for (int i = 1; i <= 4; i++)
                    if (i > 1)
                    {
                        tb_giro.Text += string.Format("{0}) {1}" + Environment.NewLine, i, ordine[i - 1]);
                        tb_giro_lotr.Text += string.Format("{0}) {1}" + Environment.NewLine, i, ordine_lotr[i - 1]);
                        tb_giro_hp.Text += string.Format("{0}) {1}" + Environment.NewLine, i, ordine_hp[i - 1]);
                        tb_giro_pirati.Text += string.Format("{0}) {1}" + Environment.NewLine, i, ordine_pirati[i - 1]);
                    }
                    else
                    {
                        tb_giro.Text = string.Format("{0}) {1}" + Environment.NewLine, i, ordine[i - 1]);
                        tb_giro_lotr.Text = string.Format("{0}) {1}" + Environment.NewLine, i, ordine_lotr[i - 1]);
                        tb_giro_hp.Text = string.Format("{0}) {1}" + Environment.NewLine, i, ordine_hp[i - 1]);
                        tb_giro_pirati.Text = string.Format("{0}) {1}" + Environment.NewLine, i, ordine_pirati[i - 1]);
                    }
                }
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            //se ero l'ultimo del mio turno (necessario per non fare 4 volte il codice)
            if ((bgw == bgw_nord && r.Nord == 3) || (bgw == bgw_sud && r.Sud == 3) || (bgw == bgw_est && r.Est == 3) || (bgw == bgw_ovest && r.Ovest == 3)) 
            {
                //creo un nuovo FormPodio e chiamo il metodo per visualizzare la classifica
                FormPodio fp = new FormPodio();
                fp.VisualizzaClassifica(Classifica, tema);
                if (fp.ShowDialog() == DialogResult.OK) //se è stato premuto il pulsante Altra Partita
                {
                    r = new Risorsa(); //la risorsa viene annullata e se ne genera una nuova
                    giocata = 1; //il conto delle giocate riparte da 1
                    //vengono nascoste tutte le picturebox indicanti il turno
                    pb_nord_turno.Hide();
                    pb_est_turno.Hide();
                    pb_sud_turno.Hide();
                    pb_ovest_turno.Hide();
                    //vengono nascosti i dadi
                    NascondiDadi();
                    //vengono annullati i testi di tutte le textbox
                    tb_class_partita.Text = "";
                    tb_class_partita_lotr.Text = "";
                    tb_class_partita_hp.Text = "";
                    tb_class_partita_pirati.Text = "";

                    tb_class_turno.Text = "";
                    tb_class_turno_lotr.Text = "";
                    tb_class_turno_hp.Text = "";
                    tb_class_turno_pirati.Text = "";

                    tb_giro.Text = "";
                    tb_giro_lotr.Text = "";
                    tb_giro_hp.Text = "";
                    tb_giro_pirati.Text = "";
                    //vengono mostrati i pulsanti per cambiare i temi e quello per fermare il gioco
                    gb_temi.Show(); btn_stop.Show();
                    //vengono fatti partire tutti i bgw
                    bgw_nord.RunWorkerAsync();
                    bgw_est.RunWorkerAsync();
                    bgw_sud.RunWorkerAsync();
                    bgw_ovest.RunWorkerAsync();
                }
            }
        }
        private void Turno(BackgroundWorker bgw, out int d1, out int d2, int giocatore)
        {
            //Lancio dei dadi e salvataggio nella risorsa
            d1 = rnd.Next(1, 7);
            d2 = rnd.Next(1, 7);
            if (bgw.CancellationPending) return; //se bgw.RunWorkwerAsync() è stato chiamato, esco PRIMA DI SALVARE
            r.SalvaLancio(d1 + d2, giocatore);
            //passagio al Progress changed: si passa un array con i valori dei due dadi e la somma di essi
            int[] dadi = { d1, d2 };
            bgw.ReportProgress(r.Turno); //Progress Percentage compreso tra 0 e 3 = mostrare chi sta svolgendo il turno
            //ciclo per l'animazione del lancio dei dadi
            for (int i = 0; i <= 10; i++)
            {
                if (i != 10) //se non è la fine del ciclo
                {
                    int[] dadi2 = { rnd.Next(1, 7), rnd.Next(1, 7) }; //genero due valori casuali
                    bgw.ReportProgress(5, dadi2); //chiamo il Progress changed per mostrare i dadi corretti (5) e passo come parametro i due valori casuali
                    Thread.Sleep(150); //pausa per visualizzare
                    bgw.ReportProgress(6); //chiamo il Progress changed per togliere i dadi (6)
                }
                else
                {
                    bgw.ReportProgress(5, dadi);//chiamo il Progress changed per mostrare il dado corretto (5) e passo come parametro i due valori salvati nella risorsa
                    //non si richiama il Progress changed perché i dadi restano visibili fino al lancio del giocatore successivo
                }
                Thread.Sleep(150); //pausa per visualizzare
            }
            Thread.Sleep(1500); //pausa di fine turno
            bgw.ReportProgress(6);//chiamo il Progress changed per togliere i dadi (6)
            if (r.Turno == 3) //se sono l'ultimo giocatore
            {
                //si creano come parametri le classifiche per stampare quelle corrette e non quelle aggiornate dalla risorsa
                string[] classifica_gioc = r.ClassificaGiocata("default", giocata);
                string[] classifica_gioc_lotr = r.ClassificaGiocata("lotr", giocata);
                string[] classifica_gioc_hp = r.ClassificaGiocata("hp", giocata);
                string[] classifica_gioc_pirati = r.ClassificaGiocata("pirati", giocata);
                string[] classifica_partita = r.ClassificaTotale("default");
                string[] classifica_partita_lotr = r.ClassificaTotale("lotr");
                string[] classifica_partita_hp = r.ClassificaTotale("hp");
                string[] classifica_partita_pirati = r.ClassificaTotale("pirati");

                //si aggiungono alla lista parametri entrambe le classifiche in tutte le modalità, per tenere sempre aggiornate le varie textbox e mostrare solo quella adatta
                List<string[]> parametri = new List<string[]>();
                parametri.Add(classifica_gioc);
                parametri.Add(classifica_partita);
                parametri.Add(classifica_gioc_lotr);
                parametri.Add(classifica_partita_lotr);
                parametri.Add(classifica_gioc_hp);
                parametri.Add(classifica_partita_hp);
                parametri.Add(classifica_gioc_pirati);
                parametri.Add(classifica_partita_pirati);

                bgw.ReportProgress(4, parametri); //passo la lista come parametro al Progress changed perché le classifiche siano stampate(4)
                bgw.ReportProgress(-1); //si chiama il Progress changed per nascondere le picturebox che indicano chi sta giocando (-1);
                Thread.Sleep(3000); //attesa di fine turno 
                r.AggiornaGiocatori(); //cambio dell'ordine (0->1, 1->2, 2->3, 3->0)
                r.AzzeraGiocata(); //annullamento dei valori della giocata precedente
                giocata++; //incremento della giocata
                r.Turno = 0; //azzeramento contatore del giocatore della risorsa
            }
            else
            {
                r.Turno++; //incremento contatore del giocatore della risorsa
                bgw.ReportProgress(-1); //si chiama il Progress changed per nascondere le picturebox che indicano chi sta giocando (-1)
            }
        }
        private void VisualizzaTextBoxes()
        {
            //si assegna al valore Visible di ogni textbox vero se il suo tema è stato selezionato, falso altrimenti.
            tb_giro_lotr.Visible = _lotr;
            tb_giro_hp.Visible = _hp;
            tb_giro_pirati.Visible = _pirati;
            tb_giro.Visible = _default;

            tb_class_turno_lotr.Visible = _lotr;
            tb_class_turno_hp.Visible = _hp;
            tb_class_turno_pirati.Visible = _pirati;
            tb_class_turno.Visible = _default;
            
            tb_class_partita_lotr.Visible = _lotr;
            tb_class_partita_hp.Visible = _hp;
            tb_class_partita_pirati.Visible = _pirati;
            tb_class_partita.Visible = _default;
        }
        private void NascondiDadi()
        {
            pb_d1.Hide();
            pb_d2.Hide();
        }
        private void MostraGiro(BackgroundWorker bgw)
        {
            // si controlla se è il turno del bgw e se è il primo a giocare. 
            // se vero, si chiama il ReportProgress che stampa sulle varie textbox il giro
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
        private void btn_inizio_Click(object sender, EventArgs e)
        {
            //si controlla quale tema è selezionato e si preme il pulsante di conseguenza
            if (_default)
                btn_default_Click(sender, e);
            if (_hp)
                btn_hp_Click(sender, e);
            if (_lotr)
                btn_lotr_Click(sender, e);
            if (_pirati)
                btn_pirati_Click(sender, e);
            //si nasconde questo pulsante per evitare la generazione di eccezioni
            btn_inizio.Hide();
            //si fanno partire i bgw
            bgw_nord.RunWorkerAsync();
            bgw_est.RunWorkerAsync();
            bgw_sud.RunWorkerAsync();
            bgw_ovest.RunWorkerAsync();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            //si fermano i bgw e si nascondono i pulsanti di stop per evitare eccezioni e dei temi per non avre un podio fuoritema
            bgw_nord.CancelAsync();
            bgw_est.CancelAsync();
            bgw_sud.CancelAsync();
            bgw_ovest.CancelAsync();
            btn_stop.Hide();
            gb_temi.Hide();
        }
        
        #region Pulsanti Temi
        //si cambiano i valori dei booleani mettendo a vero quello corrispondente al tema e a falso quello degli altri. 
        //si cambia la stringa del tema e tutte le immagini. Si chiama il metodo textboxes per visualizzare le textbox corrette 
        private void btn_lotr_Click(object sender, EventArgs e)
        {
            _default = false; _hp = false; _lotr = true; _pirati = false;
            tema = "lotr";
            pb_nord.Image = Properties.Resources.Elrond;
            pb_sud.Image = Properties.Resources.Gandalf;
            pb_est.Image = Properties.Resources.Sauron;
            pb_ovest.Image = Properties.Resources.Galadriel;
            pb_nord_turno.Image = Properties.Resources.Elrond_turno;
            pb_sud_turno.Image = Properties.Resources.Gandalf_turno;
            pb_est_turno.Image = Properties.Resources.Sauron_turno;
            pb_ovest_turno.Image = Properties.Resources.Galadriel_turno;
            BackgroundImage = Properties.Resources.lotr_back;
            VisualizzaTextBoxes();
        }
        private void btn_hp_Click(object sender, EventArgs e)
        {
            _default = false; _hp = true; _lotr = false; _pirati = false;
            tema = "hp";
            pb_nord.Image = Properties.Resources.Slytherin;
            pb_sud.Image = Properties.Resources.Hufflepuff;
            pb_est.Image = Properties.Resources.Ravenclaw;
            pb_ovest.Image = Properties.Resources.Gryffindor;
            pb_nord_turno.Image = Properties.Resources.Slytherin_turno;
            pb_sud_turno.Image = Properties.Resources.Hufflepuff_turno;
            pb_est_turno.Image = Properties.Resources.Ravenclaw_turno;
            pb_ovest_turno.Image = Properties.Resources.Gryffindor_turno;
            this.BackgroundImage = Properties.Resources.hp_back;
            VisualizzaTextBoxes();
        }
        private void btn_pirati_Click(object sender, EventArgs e)
        {
            _default = false; _hp = false; _lotr = false; _pirati = true;
            tema = "pirati";
            pb_nord.Image = Properties.Resources.Sparrow;
            pb_sud.Image = Properties.Resources.Barbossa;
            pb_est.Image = Properties.Resources.Will;
            pb_ovest.Image = Properties.Resources.Elisabeth;
            pb_nord_turno.Image = Properties.Resources.Sparrow_turno;
            pb_sud_turno.Image = Properties.Resources.Barbossa_turno;
            pb_est_turno.Image = Properties.Resources.Will_turno;
            pb_ovest_turno.Image = Properties.Resources.Elisabeth_turno;
            BackgroundImage = Properties.Resources.pirati_back;
            VisualizzaTextBoxes();
        }
        private void btn_default_Click(object sender, EventArgs e)
        {
            _default = true; _hp = false; _lotr = false; _pirati = false;
            tema = "default";
            pb_nord.Image = Properties.Resources.Nord_normale_normale;
            pb_sud.Image = Properties.Resources.Sud_normale_normale;
            pb_est.Image = Properties.Resources.Est_normale_normale;
            pb_ovest.Image = Properties.Resources.Ovest_normale_normale;
            pb_nord_turno.Image = Properties.Resources.Nord_turno_normale;
            pb_sud_turno.Image = Properties.Resources.Sud_turno_normale;
            pb_est_turno.Image = Properties.Resources.Est_turno_normale;
            pb_ovest_turno.Image = Properties.Resources.Ovest_turno_normale;
            BackgroundImage = null;
            VisualizzaTextBoxes();

        }
        #endregion
    }
}


