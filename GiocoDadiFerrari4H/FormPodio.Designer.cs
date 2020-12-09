namespace GiocoDadiFerrari4H
{
    partial class FormPodio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_primo = new System.Windows.Forms.TextBox();
            this.tb_secondo = new System.Windows.Forms.TextBox();
            this.tb_terzo = new System.Windows.Forms.TextBox();
            this.tb_quarto = new System.Windows.Forms.TextBox();
            this.btn_rivincita = new System.Windows.Forms.Button();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_primo
            // 
            this.tb_primo.Location = new System.Drawing.Point(299, 106);
            this.tb_primo.Name = "tb_primo";
            this.tb_primo.Size = new System.Drawing.Size(106, 20);
            this.tb_primo.TabIndex = 0;
            // 
            // tb_secondo
            // 
            this.tb_secondo.Location = new System.Drawing.Point(441, 147);
            this.tb_secondo.Name = "tb_secondo";
            this.tb_secondo.Size = new System.Drawing.Size(106, 20);
            this.tb_secondo.TabIndex = 1;
            // 
            // tb_terzo
            // 
            this.tb_terzo.Location = new System.Drawing.Point(173, 162);
            this.tb_terzo.Name = "tb_terzo";
            this.tb_terzo.Size = new System.Drawing.Size(106, 20);
            this.tb_terzo.TabIndex = 2;
            // 
            // tb_quarto
            // 
            this.tb_quarto.Location = new System.Drawing.Point(299, 273);
            this.tb_quarto.Name = "tb_quarto";
            this.tb_quarto.Size = new System.Drawing.Size(106, 20);
            this.tb_quarto.TabIndex = 3;
            // 
            // btn_rivincita
            // 
            this.btn_rivincita.Location = new System.Drawing.Point(315, 344);
            this.btn_rivincita.Name = "btn_rivincita";
            this.btn_rivincita.Size = new System.Drawing.Size(75, 23);
            this.btn_rivincita.TabIndex = 4;
            this.btn_rivincita.Text = "Altra Partita";
            this.btn_rivincita.UseVisualStyleBackColor = true;
            this.btn_rivincita.Click += new System.EventHandler(this.btn_rivincita_Click);
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(315, 373);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(75, 23);
            this.btn_chiudi.TabIndex = 5;
            this.btn_chiudi.Text = "Stop";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // FormPodio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.btn_rivincita);
            this.Controls.Add(this.tb_quarto);
            this.Controls.Add(this.tb_terzo);
            this.Controls.Add(this.tb_secondo);
            this.Controls.Add(this.tb_primo);
            this.Name = "FormPodio";
            this.Text = "FormPodio";
            this.Load += new System.EventHandler(this.FormPodio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_primo;
        private System.Windows.Forms.TextBox tb_secondo;
        private System.Windows.Forms.TextBox tb_terzo;
        private System.Windows.Forms.TextBox tb_quarto;
        private System.Windows.Forms.Button btn_rivincita;
        private System.Windows.Forms.Button btn_chiudi;
    }
}