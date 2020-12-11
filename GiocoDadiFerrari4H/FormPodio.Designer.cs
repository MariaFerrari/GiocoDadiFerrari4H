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
            this.tb_terzo = new System.Windows.Forms.TextBox();
            this.tb_secondo = new System.Windows.Forms.TextBox();
            this.tb_quarto = new System.Windows.Forms.TextBox();
            this.btn_rivincita = new System.Windows.Forms.Button();
            this.pb_secondo = new System.Windows.Forms.PictureBox();
            this.pb_terzo = new System.Windows.Forms.PictureBox();
            this.pb_primo = new System.Windows.Forms.PictureBox();
            this.pb_quarto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_terzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_primo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quarto)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_primo
            // 
            this.tb_primo.Location = new System.Drawing.Point(317, 413);
            this.tb_primo.Name = "tb_primo";
            this.tb_primo.Size = new System.Drawing.Size(130, 20);
            this.tb_primo.TabIndex = 0;
            // 
            // tb_terzo
            // 
            this.tb_terzo.Location = new System.Drawing.Point(486, 413);
            this.tb_terzo.Name = "tb_terzo";
            this.tb_terzo.Size = new System.Drawing.Size(130, 20);
            this.tb_terzo.TabIndex = 1;
            // 
            // tb_secondo
            // 
            this.tb_secondo.Location = new System.Drawing.Point(160, 413);
            this.tb_secondo.Name = "tb_secondo";
            this.tb_secondo.Size = new System.Drawing.Size(130, 20);
            this.tb_secondo.TabIndex = 2;
            // 
            // tb_quarto
            // 
            this.tb_quarto.Location = new System.Drawing.Point(387, 593);
            this.tb_quarto.Name = "tb_quarto";
            this.tb_quarto.Size = new System.Drawing.Size(130, 20);
            this.tb_quarto.TabIndex = 3;
            // 
            // btn_rivincita
            // 
            this.btn_rivincita.Location = new System.Drawing.Point(670, 293);
            this.btn_rivincita.Name = "btn_rivincita";
            this.btn_rivincita.Size = new System.Drawing.Size(75, 23);
            this.btn_rivincita.TabIndex = 4;
            this.btn_rivincita.Text = "Altra Partita";
            this.btn_rivincita.UseVisualStyleBackColor = true;
            this.btn_rivincita.Click += new System.EventHandler(this.btn_rivincita_Click);
            // 
            // pb_secondo
            // 
            this.pb_secondo.Location = new System.Drawing.Point(175, 307);
            this.pb_secondo.Name = "pb_secondo";
            this.pb_secondo.Padding = new System.Windows.Forms.Padding(3);
            this.pb_secondo.Size = new System.Drawing.Size(100, 100);
            this.pb_secondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_secondo.TabIndex = 5;
            this.pb_secondo.TabStop = false;
            // 
            // pb_terzo
            // 
            this.pb_terzo.Location = new System.Drawing.Point(501, 307);
            this.pb_terzo.Name = "pb_terzo";
            this.pb_terzo.Padding = new System.Windows.Forms.Padding(3);
            this.pb_terzo.Size = new System.Drawing.Size(100, 100);
            this.pb_terzo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_terzo.TabIndex = 6;
            this.pb_terzo.TabStop = false;
            // 
            // pb_primo
            // 
            this.pb_primo.Location = new System.Drawing.Point(332, 307);
            this.pb_primo.Name = "pb_primo";
            this.pb_primo.Padding = new System.Windows.Forms.Padding(3);
            this.pb_primo.Size = new System.Drawing.Size(100, 100);
            this.pb_primo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_primo.TabIndex = 7;
            this.pb_primo.TabStop = false;
            // 
            // pb_quarto
            // 
            this.pb_quarto.Location = new System.Drawing.Point(402, 487);
            this.pb_quarto.Name = "pb_quarto";
            this.pb_quarto.Padding = new System.Windows.Forms.Padding(3);
            this.pb_quarto.Size = new System.Drawing.Size(100, 100);
            this.pb_quarto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_quarto.TabIndex = 8;
            this.pb_quarto.TabStop = false;
            // 
            // FormPodio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiocoDadiFerrari4H.Properties.Resources.podio;
            this.ClientSize = new System.Drawing.Size(787, 616);
            this.Controls.Add(this.pb_quarto);
            this.Controls.Add(this.pb_primo);
            this.Controls.Add(this.pb_terzo);
            this.Controls.Add(this.pb_secondo);
            this.Controls.Add(this.btn_rivincita);
            this.Controls.Add(this.tb_quarto);
            this.Controls.Add(this.tb_secondo);
            this.Controls.Add(this.tb_terzo);
            this.Controls.Add(this.tb_primo);
            this.Name = "FormPodio";
            this.Text = "FormPodio";
            this.Load += new System.EventHandler(this.FormPodio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_terzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_primo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_primo;
        private System.Windows.Forms.TextBox tb_terzo;
        private System.Windows.Forms.TextBox tb_secondo;
        private System.Windows.Forms.TextBox tb_quarto;
        private System.Windows.Forms.Button btn_rivincita;
        private System.Windows.Forms.PictureBox pb_secondo;
        private System.Windows.Forms.PictureBox pb_terzo;
        private System.Windows.Forms.PictureBox pb_primo;
        private System.Windows.Forms.PictureBox pb_quarto;
    }
}