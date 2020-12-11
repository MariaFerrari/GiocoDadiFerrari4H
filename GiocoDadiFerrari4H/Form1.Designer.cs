namespace GiocoDadiFerrari4H
{
    partial class FormNormale1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNormale1));
            this.tb_class_turno = new System.Windows.Forms.TextBox();
            this.tb_class_partita = new System.Windows.Forms.TextBox();
            this.bgw_nord = new System.ComponentModel.BackgroundWorker();
            this.bgw_est = new System.ComponentModel.BackgroundWorker();
            this.bgw_sud = new System.ComponentModel.BackgroundWorker();
            this.bgw_ovest = new System.ComponentModel.BackgroundWorker();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tb_giro = new System.Windows.Forms.TextBox();
            this.gb_temi = new System.Windows.Forms.GroupBox();
            this.btn_default = new System.Windows.Forms.Button();
            this.btn_lotr = new System.Windows.Forms.Button();
            this.btn_hp = new System.Windows.Forms.Button();
            this.btn_pirati = new System.Windows.Forms.Button();
            this.btn_inizio = new System.Windows.Forms.Button();
            this.tb_giro_lotr = new System.Windows.Forms.TextBox();
            this.tb_giro_hp = new System.Windows.Forms.TextBox();
            this.tb_giro_pirati = new System.Windows.Forms.TextBox();
            this.tb_class_turno_lotr = new System.Windows.Forms.TextBox();
            this.tb_class_turno_hp = new System.Windows.Forms.TextBox();
            this.tb_class_turno_pirati = new System.Windows.Forms.TextBox();
            this.tb_class_partita_lotr = new System.Windows.Forms.TextBox();
            this.tb_class_partita_hp = new System.Windows.Forms.TextBox();
            this.tb_class_partita_pirati = new System.Windows.Forms.TextBox();
            this.gb_class = new System.Windows.Forms.GroupBox();
            this.gb_giro = new System.Windows.Forms.GroupBox();
            this.pb_d2 = new System.Windows.Forms.PictureBox();
            this.pb_d1 = new System.Windows.Forms.PictureBox();
            this.pb_ovest_turno = new System.Windows.Forms.PictureBox();
            this.pb_sud_turno = new System.Windows.Forms.PictureBox();
            this.pb_est_turno = new System.Windows.Forms.PictureBox();
            this.pb_nord_turno = new System.Windows.Forms.PictureBox();
            this.pb_nord = new System.Windows.Forms.PictureBox();
            this.pb_sud = new System.Windows.Forms.PictureBox();
            this.pb_ovest = new System.Windows.Forms.PictureBox();
            this.pb_est = new System.Windows.Forms.PictureBox();
            this.gb_temi.SuspendLayout();
            this.gb_class.SuspendLayout();
            this.gb_giro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_class_turno
            // 
            this.tb_class_turno.Location = new System.Drawing.Point(7, 19);
            this.tb_class_turno.Multiline = true;
            this.tb_class_turno.Name = "tb_class_turno";
            this.tb_class_turno.Size = new System.Drawing.Size(112, 98);
            this.tb_class_turno.TabIndex = 5;
            // 
            // tb_class_partita
            // 
            this.tb_class_partita.Location = new System.Drawing.Point(124, 19);
            this.tb_class_partita.Multiline = true;
            this.tb_class_partita.Name = "tb_class_partita";
            this.tb_class_partita.Size = new System.Drawing.Size(112, 98);
            this.tb_class_partita.TabIndex = 6;
            // 
            // bgw_nord
            // 
            this.bgw_nord.WorkerReportsProgress = true;
            this.bgw_nord.WorkerSupportsCancellation = true;
            this.bgw_nord.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.bgw_nord.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.bgw_nord.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // bgw_est
            // 
            this.bgw_est.WorkerReportsProgress = true;
            this.bgw_est.WorkerSupportsCancellation = true;
            this.bgw_est.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.bgw_est.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.bgw_est.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // bgw_sud
            // 
            this.bgw_sud.WorkerReportsProgress = true;
            this.bgw_sud.WorkerSupportsCancellation = true;
            this.bgw_sud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.bgw_sud.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.bgw_sud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // bgw_ovest
            // 
            this.bgw_ovest.WorkerReportsProgress = true;
            this.bgw_ovest.WorkerSupportsCancellation = true;
            this.bgw_ovest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.bgw_ovest.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.bgw_ovest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(532, 236);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 28;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tb_giro
            // 
            this.tb_giro.Location = new System.Drawing.Point(6, 18);
            this.tb_giro.Multiline = true;
            this.tb_giro.Name = "tb_giro";
            this.tb_giro.Size = new System.Drawing.Size(230, 70);
            this.tb_giro.TabIndex = 29;
            // 
            // gb_temi
            // 
            this.gb_temi.Controls.Add(this.btn_default);
            this.gb_temi.Controls.Add(this.btn_lotr);
            this.gb_temi.Controls.Add(this.btn_hp);
            this.gb_temi.Controls.Add(this.btn_pirati);
            this.gb_temi.Location = new System.Drawing.Point(447, 267);
            this.gb_temi.Name = "gb_temi";
            this.gb_temi.Size = new System.Drawing.Size(230, 85);
            this.gb_temi.TabIndex = 30;
            this.gb_temi.TabStop = false;
            this.gb_temi.Text = "Temi";
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(7, 19);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(93, 23);
            this.btn_default.TabIndex = 31;
            this.btn_default.Text = "Default";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_lotr
            // 
            this.btn_lotr.Location = new System.Drawing.Point(106, 20);
            this.btn_lotr.Name = "btn_lotr";
            this.btn_lotr.Size = new System.Drawing.Size(118, 23);
            this.btn_lotr.TabIndex = 3;
            this.btn_lotr.Text = "Il Signore degli Anelli";
            this.btn_lotr.UseVisualStyleBackColor = true;
            this.btn_lotr.Click += new System.EventHandler(this.btn_lotr_Click);
            // 
            // btn_hp
            // 
            this.btn_hp.Location = new System.Drawing.Point(131, 49);
            this.btn_hp.Name = "btn_hp";
            this.btn_hp.Size = new System.Drawing.Size(93, 23);
            this.btn_hp.TabIndex = 2;
            this.btn_hp.Text = "Harry Potter";
            this.btn_hp.UseVisualStyleBackColor = true;
            this.btn_hp.Click += new System.EventHandler(this.btn_hp_Click);
            // 
            // btn_pirati
            // 
            this.btn_pirati.Location = new System.Drawing.Point(7, 48);
            this.btn_pirati.Name = "btn_pirati";
            this.btn_pirati.Size = new System.Drawing.Size(118, 23);
            this.btn_pirati.TabIndex = 1;
            this.btn_pirati.Text = "I pirati dei Caraibi";
            this.btn_pirati.UseVisualStyleBackColor = true;
            this.btn_pirati.Click += new System.EventHandler(this.btn_pirati_Click);
            // 
            // btn_inizio
            // 
            this.btn_inizio.Location = new System.Drawing.Point(532, 236);
            this.btn_inizio.Name = "btn_inizio";
            this.btn_inizio.Size = new System.Drawing.Size(75, 23);
            this.btn_inizio.TabIndex = 32;
            this.btn_inizio.Text = "Inizio";
            this.btn_inizio.UseVisualStyleBackColor = true;
            this.btn_inizio.Click += new System.EventHandler(this.btn_inizio_Click);
            // 
            // tb_giro_lotr
            // 
            this.tb_giro_lotr.Location = new System.Drawing.Point(6, 18);
            this.tb_giro_lotr.Multiline = true;
            this.tb_giro_lotr.Name = "tb_giro_lotr";
            this.tb_giro_lotr.Size = new System.Drawing.Size(230, 70);
            this.tb_giro_lotr.TabIndex = 43;
            // 
            // tb_giro_hp
            // 
            this.tb_giro_hp.Location = new System.Drawing.Point(6, 18);
            this.tb_giro_hp.Multiline = true;
            this.tb_giro_hp.Name = "tb_giro_hp";
            this.tb_giro_hp.Size = new System.Drawing.Size(230, 70);
            this.tb_giro_hp.TabIndex = 44;
            // 
            // tb_giro_pirati
            // 
            this.tb_giro_pirati.Location = new System.Drawing.Point(6, 18);
            this.tb_giro_pirati.Multiline = true;
            this.tb_giro_pirati.Name = "tb_giro_pirati";
            this.tb_giro_pirati.Size = new System.Drawing.Size(230, 70);
            this.tb_giro_pirati.TabIndex = 45;
            // 
            // tb_class_turno_lotr
            // 
            this.tb_class_turno_lotr.Location = new System.Drawing.Point(7, 19);
            this.tb_class_turno_lotr.Multiline = true;
            this.tb_class_turno_lotr.Name = "tb_class_turno_lotr";
            this.tb_class_turno_lotr.Size = new System.Drawing.Size(112, 98);
            this.tb_class_turno_lotr.TabIndex = 46;
            // 
            // tb_class_turno_hp
            // 
            this.tb_class_turno_hp.Location = new System.Drawing.Point(7, 19);
            this.tb_class_turno_hp.Multiline = true;
            this.tb_class_turno_hp.Name = "tb_class_turno_hp";
            this.tb_class_turno_hp.Size = new System.Drawing.Size(112, 98);
            this.tb_class_turno_hp.TabIndex = 47;
            // 
            // tb_class_turno_pirati
            // 
            this.tb_class_turno_pirati.Location = new System.Drawing.Point(7, 19);
            this.tb_class_turno_pirati.Multiline = true;
            this.tb_class_turno_pirati.Name = "tb_class_turno_pirati";
            this.tb_class_turno_pirati.Size = new System.Drawing.Size(112, 98);
            this.tb_class_turno_pirati.TabIndex = 48;
            // 
            // tb_class_partita_lotr
            // 
            this.tb_class_partita_lotr.Location = new System.Drawing.Point(124, 19);
            this.tb_class_partita_lotr.Multiline = true;
            this.tb_class_partita_lotr.Name = "tb_class_partita_lotr";
            this.tb_class_partita_lotr.Size = new System.Drawing.Size(112, 98);
            this.tb_class_partita_lotr.TabIndex = 49;
            // 
            // tb_class_partita_hp
            // 
            this.tb_class_partita_hp.Location = new System.Drawing.Point(124, 19);
            this.tb_class_partita_hp.Multiline = true;
            this.tb_class_partita_hp.Name = "tb_class_partita_hp";
            this.tb_class_partita_hp.Size = new System.Drawing.Size(112, 98);
            this.tb_class_partita_hp.TabIndex = 50;
            // 
            // tb_class_partita_pirati
            // 
            this.tb_class_partita_pirati.Location = new System.Drawing.Point(124, 19);
            this.tb_class_partita_pirati.Multiline = true;
            this.tb_class_partita_pirati.Name = "tb_class_partita_pirati";
            this.tb_class_partita_pirati.Size = new System.Drawing.Size(112, 98);
            this.tb_class_partita_pirati.TabIndex = 51;
            // 
            // gb_class
            // 
            this.gb_class.Controls.Add(this.tb_class_partita_pirati);
            this.gb_class.Controls.Add(this.tb_class_turno);
            this.gb_class.Controls.Add(this.tb_class_turno_lotr);
            this.gb_class.Controls.Add(this.tb_class_turno_hp);
            this.gb_class.Controls.Add(this.tb_class_partita_hp);
            this.gb_class.Controls.Add(this.tb_class_turno_pirati);
            this.gb_class.Controls.Add(this.tb_class_partita);
            this.gb_class.Controls.Add(this.tb_class_partita_lotr);
            this.gb_class.Location = new System.Drawing.Point(454, 5);
            this.gb_class.Name = "gb_class";
            this.gb_class.Size = new System.Drawing.Size(243, 124);
            this.gb_class.TabIndex = 52;
            this.gb_class.TabStop = false;
            this.gb_class.Text = "Classifiche";
            // 
            // gb_giro
            // 
            this.gb_giro.BackColor = System.Drawing.SystemColors.Control;
            this.gb_giro.Controls.Add(this.tb_giro);
            this.gb_giro.Controls.Add(this.tb_giro_hp);
            this.gb_giro.Controls.Add(this.tb_giro_pirati);
            this.gb_giro.Controls.Add(this.tb_giro_lotr);
            this.gb_giro.Location = new System.Drawing.Point(454, 136);
            this.gb_giro.Name = "gb_giro";
            this.gb_giro.Size = new System.Drawing.Size(243, 94);
            this.gb_giro.TabIndex = 53;
            this.gb_giro.TabStop = false;
            this.gb_giro.Text = "Giro";
            // 
            // pb_d2
            // 
            this.pb_d2.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_6_norm;
            this.pb_d2.Location = new System.Drawing.Point(176, 180);
            this.pb_d2.Name = "pb_d2";
            this.pb_d2.Size = new System.Drawing.Size(47, 50);
            this.pb_d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2.TabIndex = 27;
            this.pb_d2.TabStop = false;
            // 
            // pb_d1
            // 
            this.pb_d1.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_6_norm;
            this.pb_d1.Location = new System.Drawing.Point(123, 130);
            this.pb_d1.Name = "pb_d1";
            this.pb_d1.Size = new System.Drawing.Size(47, 48);
            this.pb_d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1.TabIndex = 22;
            this.pb_d1.TabStop = false;
            // 
            // pb_ovest_turno
            // 
            this.pb_ovest_turno.Location = new System.Drawing.Point(17, 130);
            this.pb_ovest_turno.Name = "pb_ovest_turno";
            this.pb_ovest_turno.Padding = new System.Windows.Forms.Padding(3);
            this.pb_ovest_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_ovest_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ovest_turno.TabIndex = 17;
            this.pb_ovest_turno.TabStop = false;
            // 
            // pb_sud_turno
            // 
            this.pb_sud_turno.Location = new System.Drawing.Point(123, 236);
            this.pb_sud_turno.Name = "pb_sud_turno";
            this.pb_sud_turno.Padding = new System.Windows.Forms.Padding(3);
            this.pb_sud_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_sud_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sud_turno.TabIndex = 16;
            this.pb_sud_turno.TabStop = false;
            // 
            // pb_est_turno
            // 
            this.pb_est_turno.Location = new System.Drawing.Point(231, 130);
            this.pb_est_turno.Name = "pb_est_turno";
            this.pb_est_turno.Padding = new System.Windows.Forms.Padding(3);
            this.pb_est_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_est_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_est_turno.TabIndex = 15;
            this.pb_est_turno.TabStop = false;
            // 
            // pb_nord_turno
            // 
            this.pb_nord_turno.Location = new System.Drawing.Point(123, 24);
            this.pb_nord_turno.Name = "pb_nord_turno";
            this.pb_nord_turno.Padding = new System.Windows.Forms.Padding(3);
            this.pb_nord_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_nord_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_nord_turno.TabIndex = 14;
            this.pb_nord_turno.TabStop = false;
            // 
            // pb_nord
            // 
            this.pb_nord.Image = ((System.Drawing.Image)(resources.GetObject("pb_nord.Image")));
            this.pb_nord.Location = new System.Drawing.Point(123, 24);
            this.pb_nord.Name = "pb_nord";
            this.pb_nord.Padding = new System.Windows.Forms.Padding(3);
            this.pb_nord.Size = new System.Drawing.Size(100, 100);
            this.pb_nord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_nord.TabIndex = 13;
            this.pb_nord.TabStop = false;
            // 
            // pb_sud
            // 
            this.pb_sud.Image = ((System.Drawing.Image)(resources.GetObject("pb_sud.Image")));
            this.pb_sud.Location = new System.Drawing.Point(123, 236);
            this.pb_sud.Name = "pb_sud";
            this.pb_sud.Padding = new System.Windows.Forms.Padding(3);
            this.pb_sud.Size = new System.Drawing.Size(100, 100);
            this.pb_sud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sud.TabIndex = 12;
            this.pb_sud.TabStop = false;
            // 
            // pb_ovest
            // 
            this.pb_ovest.Image = ((System.Drawing.Image)(resources.GetObject("pb_ovest.Image")));
            this.pb_ovest.Location = new System.Drawing.Point(17, 130);
            this.pb_ovest.Name = "pb_ovest";
            this.pb_ovest.Padding = new System.Windows.Forms.Padding(3);
            this.pb_ovest.Size = new System.Drawing.Size(100, 100);
            this.pb_ovest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ovest.TabIndex = 11;
            this.pb_ovest.TabStop = false;
            // 
            // pb_est
            // 
            this.pb_est.Image = ((System.Drawing.Image)(resources.GetObject("pb_est.Image")));
            this.pb_est.Location = new System.Drawing.Point(231, 130);
            this.pb_est.Name = "pb_est";
            this.pb_est.Padding = new System.Windows.Forms.Padding(3);
            this.pb_est.Size = new System.Drawing.Size(100, 100);
            this.pb_est.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_est.TabIndex = 10;
            this.pb_est.TabStop = false;
            // 
            // FormNormale1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.gb_giro);
            this.Controls.Add(this.gb_class);
            this.Controls.Add(this.btn_inizio);
            this.Controls.Add(this.gb_temi);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.pb_d2);
            this.Controls.Add(this.pb_d1);
            this.Controls.Add(this.pb_ovest_turno);
            this.Controls.Add(this.pb_sud_turno);
            this.Controls.Add(this.pb_est_turno);
            this.Controls.Add(this.pb_nord_turno);
            this.Controls.Add(this.pb_nord);
            this.Controls.Add(this.pb_sud);
            this.Controls.Add(this.pb_ovest);
            this.Controls.Add(this.pb_est);
            this.Name = "FormNormale1";
            this.Text = "FormNormale";
            this.gb_temi.ResumeLayout(false);
            this.gb_class.ResumeLayout(false);
            this.gb_class.PerformLayout();
            this.gb_giro.ResumeLayout(false);
            this.gb_giro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_class_turno;
        private System.Windows.Forms.TextBox tb_class_partita;
        private System.ComponentModel.BackgroundWorker bgw_nord;
        private System.ComponentModel.BackgroundWorker bgw_est;
        private System.ComponentModel.BackgroundWorker bgw_sud;
        private System.ComponentModel.BackgroundWorker bgw_ovest;
        private System.Windows.Forms.PictureBox pb_est;
        private System.Windows.Forms.PictureBox pb_ovest;
        private System.Windows.Forms.PictureBox pb_sud;
        private System.Windows.Forms.PictureBox pb_nord;
        private System.Windows.Forms.PictureBox pb_nord_turno;
        private System.Windows.Forms.PictureBox pb_est_turno;
        private System.Windows.Forms.PictureBox pb_sud_turno;
        private System.Windows.Forms.PictureBox pb_ovest_turno;
        private System.Windows.Forms.PictureBox pb_d1;
        private System.Windows.Forms.PictureBox pb_d2;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tb_giro;
        private System.Windows.Forms.GroupBox gb_temi;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_lotr;
        private System.Windows.Forms.Button btn_hp;
        private System.Windows.Forms.Button btn_pirati;
        private System.Windows.Forms.Button btn_inizio;
        private System.Windows.Forms.TextBox tb_giro_lotr;
        private System.Windows.Forms.TextBox tb_giro_hp;
        private System.Windows.Forms.TextBox tb_giro_pirati;
        private System.Windows.Forms.TextBox tb_class_turno_lotr;
        private System.Windows.Forms.TextBox tb_class_turno_hp;
        private System.Windows.Forms.TextBox tb_class_turno_pirati;
        private System.Windows.Forms.TextBox tb_class_partita_lotr;
        private System.Windows.Forms.TextBox tb_class_partita_hp;
        private System.Windows.Forms.TextBox tb_class_partita_pirati;
        private System.Windows.Forms.GroupBox gb_class;
        private System.Windows.Forms.GroupBox gb_giro;
    }
}

