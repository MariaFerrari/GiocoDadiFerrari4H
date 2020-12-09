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
        public  void VisualizzaClassifica(string[] classifica)
        {
            tb_primo.Text = classifica[0];
            tb_secondo.Text = classifica[1];
            tb_terzo.Text = classifica[2];
            tb_quarto.Text = classifica[3];
        }

        private void btn_rivincita_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
