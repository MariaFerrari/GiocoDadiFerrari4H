using GiocoDadiFerrari4H.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDadiFerrari4H
{
    public partial class FormPodio : Form
    {
        public FormPodio()
        {
            InitializeComponent();
        }

        private void FormPodio_Load(object sender, EventArgs e)
        {
            
        }
        public  void VisualizzaClassifica(string[] classifica, string tema)
        {
            tb_primo.Text = classifica[0];
            tb_secondo.Text = classifica[1];
            tb_terzo.Text = classifica[2];
            tb_quarto.Text = classifica[3];
            int t = 0;
            switch (tema)
            {
                case "default": break;
                case "lotr": BackgroundImage = Resources.podio_lotr;
                    t = 1;
                    break;
                case "hp":
                    BackgroundImage = Resources.podio_hp;
                    t = 2;
                    break;
                case "pirati":
                    BackgroundImage = Resources.podio_pirati;
                    t = 3;
                    break;
            }
            for(int i=0; i<4; i++)
            {
                if (t == 0)
                {
                    if (classifica[i].Contains("Azzurro"))
                        SelezionaImmagine(i, Resources.Nord_turno_normale);
                    if (classifica[i].Contains("Rosa"))
                        SelezionaImmagine(i, Resources.Est_turno_normale);
                    if (classifica[i].Contains("Grigio"))
                        SelezionaImmagine(i, Resources.Sud_turno_normale);
                    if (classifica[i].Contains("Viola"))
                        SelezionaImmagine(i, Resources.Ovest_turno_normale);
                }
                if (t == 1)
                {
                    if (classifica[i].Contains("Galadriel"))
                        SelezionaImmagine(i, Resources.Galadriel);
                    if (classifica[i].Contains("Gandalf"))
                        SelezionaImmagine(i, Resources.Gandalf);
                    if (classifica[i].Contains("Sauron"))
                        SelezionaImmagine(i, Resources.Sauron);
                    if (classifica[i].Contains("Elrond"))
                        SelezionaImmagine(i, Resources.Elrond);
                }
                if (t == 2)
                {
                    if (classifica[i].Contains("Grif"))
                        SelezionaImmagine(i, Resources.Gryffindor_turno);
                    if (classifica[i].Contains("Corvo"))
                        SelezionaImmagine(i, Resources.Ravenclaw_turno);
                    if (classifica[i].Contains("Tasso"))
                        SelezionaImmagine(i, Resources.Hufflepuff_turno);
                    if (classifica[i].Contains("Serpe"))
                        SelezionaImmagine(i, Resources.Slytherin_turno);
                }
                if (t == 3)
                {
                    if (classifica[i].Contains("Jack"))
                        SelezionaImmagine(i, Resources.Sparrow);
                    if (classifica[i].Contains("Barbossa"))
                        SelezionaImmagine(i, Resources.Barbossa);
                    if (classifica[i].Contains("Elis"))
                        SelezionaImmagine(i, Resources.Elisabeth);
                    if (classifica[i].Contains("Will"))
                        SelezionaImmagine(i, Resources.Will);
                }
            }
        }
        private void SelezionaImmagine(int i, Image img)
        {
            if (i == 0)
                pb_primo.Image = img;
            if (i == 1)
                pb_secondo.Image = img;
            if (i == 2)
                pb_terzo.Image = img;
            if (i == 3)
                pb_quarto.Image = img;
        }
        private void btn_rivincita_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
