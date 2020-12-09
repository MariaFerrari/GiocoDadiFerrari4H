namespace GiocoDadiFerrari4H
{
    partial class FormNormale
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
            this.tb_class_turno = new System.Windows.Forms.TextBox();
            this.tb_class_partita = new System.Windows.Forms.TextBox();
            this.bgw_nord = new System.ComponentModel.BackgroundWorker();
            this.bgw_est = new System.ComponentModel.BackgroundWorker();
            this.bgw_sud = new System.ComponentModel.BackgroundWorker();
            this.bgw_ovest = new System.ComponentModel.BackgroundWorker();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tb_giro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_default = new System.Windows.Forms.Button();
            this.btn_lotr = new System.Windows.Forms.Button();
            this.btn_hp = new System.Windows.Forms.Button();
            this.btn_pirati = new System.Windows.Forms.Button();
            this.pb_d2_6 = new System.Windows.Forms.PictureBox();
            this.pb_d2_5 = new System.Windows.Forms.PictureBox();
            this.pb_d2_4 = new System.Windows.Forms.PictureBox();
            this.pb_d2_3 = new System.Windows.Forms.PictureBox();
            this.pb_d2_2 = new System.Windows.Forms.PictureBox();
            this.pb_d1_6 = new System.Windows.Forms.PictureBox();
            this.pb_d1_5 = new System.Windows.Forms.PictureBox();
            this.pb_d1_4 = new System.Windows.Forms.PictureBox();
            this.pb_d1_3 = new System.Windows.Forms.PictureBox();
            this.pb_d1_2 = new System.Windows.Forms.PictureBox();
            this.pb_ovest_turno = new System.Windows.Forms.PictureBox();
            this.pb_sud_turno = new System.Windows.Forms.PictureBox();
            this.pb_est_turno = new System.Windows.Forms.PictureBox();
            this.pb_nord_turno = new System.Windows.Forms.PictureBox();
            this.pb_nord = new System.Windows.Forms.PictureBox();
            this.pb_sud = new System.Windows.Forms.PictureBox();
            this.pb_ovest = new System.Windows.Forms.PictureBox();
            this.pb_est = new System.Windows.Forms.PictureBox();
            this.pb_d1_1 = new System.Windows.Forms.PictureBox();
            this.pb_d2_1 = new System.Windows.Forms.PictureBox();
            this.tb_giocata = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_class_turno
            // 
            this.tb_class_turno.Location = new System.Drawing.Point(391, 12);
            this.tb_class_turno.Multiline = true;
            this.tb_class_turno.Name = "tb_class_turno";
            this.tb_class_turno.Size = new System.Drawing.Size(76, 98);
            this.tb_class_turno.TabIndex = 5;
            // 
            // tb_class_partita
            // 
            this.tb_class_partita.Location = new System.Drawing.Point(475, 12);
            this.tb_class_partita.Multiline = true;
            this.tb_class_partita.Name = "tb_class_partita";
            this.tb_class_partita.Size = new System.Drawing.Size(76, 98);
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
            this.btn_stop.Location = new System.Drawing.Point(398, 212);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 28;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tb_giro
            // 
            this.tb_giro.Location = new System.Drawing.Point(391, 116);
            this.tb_giro.Multiline = true;
            this.tb_giro.Name = "tb_giro";
            this.tb_giro.Size = new System.Drawing.Size(160, 70);
            this.tb_giro.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_default);
            this.groupBox1.Controls.Add(this.btn_lotr);
            this.groupBox1.Controls.Add(this.btn_hp);
            this.groupBox1.Controls.Add(this.btn_pirati);
            this.groupBox1.Location = new System.Drawing.Point(391, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 85);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temi";
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(7, 19);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(75, 23);
            this.btn_default.TabIndex = 31;
            this.btn_default.Text = "Default";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_lotr
            // 
            this.btn_lotr.Location = new System.Drawing.Point(88, 20);
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
            this.btn_hp.Size = new System.Drawing.Size(75, 23);
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
            // pb_d2_6
            // 
            this.pb_d2_6.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_6_norm;
            this.pb_d2_6.Location = new System.Drawing.Point(176, 200);
            this.pb_d2_6.Name = "pb_d2_6";
            this.pb_d2_6.Size = new System.Drawing.Size(47, 50);
            this.pb_d2_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2_6.TabIndex = 27;
            this.pb_d2_6.TabStop = false;
            // 
            // pb_d2_5
            // 
            this.pb_d2_5.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_5_norm;
            this.pb_d2_5.Location = new System.Drawing.Point(176, 200);
            this.pb_d2_5.Name = "pb_d2_5";
            this.pb_d2_5.Size = new System.Drawing.Size(47, 50);
            this.pb_d2_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2_5.TabIndex = 26;
            this.pb_d2_5.TabStop = false;
            // 
            // pb_d2_4
            // 
            this.pb_d2_4.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_4_norm;
            this.pb_d2_4.Location = new System.Drawing.Point(176, 200);
            this.pb_d2_4.Name = "pb_d2_4";
            this.pb_d2_4.Size = new System.Drawing.Size(47, 50);
            this.pb_d2_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2_4.TabIndex = 25;
            this.pb_d2_4.TabStop = false;
            // 
            // pb_d2_3
            // 
            this.pb_d2_3.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_3_norm;
            this.pb_d2_3.Location = new System.Drawing.Point(176, 200);
            this.pb_d2_3.Name = "pb_d2_3";
            this.pb_d2_3.Size = new System.Drawing.Size(47, 50);
            this.pb_d2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2_3.TabIndex = 24;
            this.pb_d2_3.TabStop = false;
            // 
            // pb_d2_2
            // 
            this.pb_d2_2.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_2_norm;
            this.pb_d2_2.Location = new System.Drawing.Point(176, 200);
            this.pb_d2_2.Name = "pb_d2_2";
            this.pb_d2_2.Size = new System.Drawing.Size(47, 50);
            this.pb_d2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2_2.TabIndex = 23;
            this.pb_d2_2.TabStop = false;
            // 
            // pb_d1_6
            // 
            this.pb_d1_6.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_6_norm;
            this.pb_d1_6.Location = new System.Drawing.Point(123, 150);
            this.pb_d1_6.Name = "pb_d1_6";
            this.pb_d1_6.Size = new System.Drawing.Size(47, 48);
            this.pb_d1_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1_6.TabIndex = 22;
            this.pb_d1_6.TabStop = false;
            this.pb_d1_6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pb_d1_5
            // 
            this.pb_d1_5.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_5_norm;
            this.pb_d1_5.Location = new System.Drawing.Point(123, 150);
            this.pb_d1_5.Name = "pb_d1_5";
            this.pb_d1_5.Size = new System.Drawing.Size(47, 48);
            this.pb_d1_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1_5.TabIndex = 21;
            this.pb_d1_5.TabStop = false;
            // 
            // pb_d1_4
            // 
            this.pb_d1_4.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_4_norm;
            this.pb_d1_4.Location = new System.Drawing.Point(123, 150);
            this.pb_d1_4.Name = "pb_d1_4";
            this.pb_d1_4.Size = new System.Drawing.Size(47, 48);
            this.pb_d1_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1_4.TabIndex = 20;
            this.pb_d1_4.TabStop = false;
            // 
            // pb_d1_3
            // 
            this.pb_d1_3.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_3_norm;
            this.pb_d1_3.Location = new System.Drawing.Point(123, 150);
            this.pb_d1_3.Name = "pb_d1_3";
            this.pb_d1_3.Size = new System.Drawing.Size(47, 48);
            this.pb_d1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1_3.TabIndex = 19;
            this.pb_d1_3.TabStop = false;
            // 
            // pb_d1_2
            // 
            this.pb_d1_2.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_2_norm;
            this.pb_d1_2.Location = new System.Drawing.Point(123, 150);
            this.pb_d1_2.Name = "pb_d1_2";
            this.pb_d1_2.Size = new System.Drawing.Size(47, 48);
            this.pb_d1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1_2.TabIndex = 18;
            this.pb_d1_2.TabStop = false;
            // 
            // pb_ovest_turno
            // 
            this.pb_ovest_turno.Image = global::GiocoDadiFerrari4H.Properties.Resources.Ovest_turno_normale;
            this.pb_ovest_turno.Location = new System.Drawing.Point(17, 150);
            this.pb_ovest_turno.Name = "pb_ovest_turno";
            this.pb_ovest_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_ovest_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ovest_turno.TabIndex = 17;
            this.pb_ovest_turno.TabStop = false;
            // 
            // pb_sud_turno
            // 
            this.pb_sud_turno.Image = global::GiocoDadiFerrari4H.Properties.Resources.Sud_turno_normale;
            this.pb_sud_turno.Location = new System.Drawing.Point(123, 256);
            this.pb_sud_turno.Name = "pb_sud_turno";
            this.pb_sud_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_sud_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sud_turno.TabIndex = 16;
            this.pb_sud_turno.TabStop = false;
            // 
            // pb_est_turno
            // 
            this.pb_est_turno.Image = global::GiocoDadiFerrari4H.Properties.Resources.Est_turno_normale;
            this.pb_est_turno.Location = new System.Drawing.Point(231, 150);
            this.pb_est_turno.Name = "pb_est_turno";
            this.pb_est_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_est_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_est_turno.TabIndex = 15;
            this.pb_est_turno.TabStop = false;
            // 
            // pb_nord_turno
            // 
            this.pb_nord_turno.Image = global::GiocoDadiFerrari4H.Properties.Resources.Nord_turno_normale;
            this.pb_nord_turno.Location = new System.Drawing.Point(123, 44);
            this.pb_nord_turno.Name = "pb_nord_turno";
            this.pb_nord_turno.Size = new System.Drawing.Size(100, 100);
            this.pb_nord_turno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_nord_turno.TabIndex = 14;
            this.pb_nord_turno.TabStop = false;
            // 
            // pb_nord
            // 
            this.pb_nord.Image = global::GiocoDadiFerrari4H.Properties.Resources.Nord_normale_normale;
            this.pb_nord.Location = new System.Drawing.Point(123, 44);
            this.pb_nord.Name = "pb_nord";
            this.pb_nord.Size = new System.Drawing.Size(100, 100);
            this.pb_nord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_nord.TabIndex = 13;
            this.pb_nord.TabStop = false;
            // 
            // pb_sud
            // 
            this.pb_sud.Image = global::GiocoDadiFerrari4H.Properties.Resources.Sud_normale_normale;
            this.pb_sud.Location = new System.Drawing.Point(123, 256);
            this.pb_sud.Name = "pb_sud";
            this.pb_sud.Size = new System.Drawing.Size(100, 100);
            this.pb_sud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sud.TabIndex = 12;
            this.pb_sud.TabStop = false;
            // 
            // pb_ovest
            // 
            this.pb_ovest.Image = global::GiocoDadiFerrari4H.Properties.Resources.Ovest_normale_normale;
            this.pb_ovest.Location = new System.Drawing.Point(17, 150);
            this.pb_ovest.Name = "pb_ovest";
            this.pb_ovest.Size = new System.Drawing.Size(100, 100);
            this.pb_ovest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ovest.TabIndex = 11;
            this.pb_ovest.TabStop = false;
            // 
            // pb_est
            // 
            this.pb_est.Image = global::GiocoDadiFerrari4H.Properties.Resources.Est_normale_normale;
            this.pb_est.Location = new System.Drawing.Point(231, 150);
            this.pb_est.Name = "pb_est";
            this.pb_est.Size = new System.Drawing.Size(100, 100);
            this.pb_est.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_est.TabIndex = 10;
            this.pb_est.TabStop = false;
            // 
            // pb_d1_1
            // 
            this.pb_d1_1.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_1_norm;
            this.pb_d1_1.Location = new System.Drawing.Point(123, 150);
            this.pb_d1_1.Name = "pb_d1_1";
            this.pb_d1_1.Size = new System.Drawing.Size(47, 48);
            this.pb_d1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d1_1.TabIndex = 9;
            this.pb_d1_1.TabStop = false;
            // 
            // pb_d2_1
            // 
            this.pb_d2_1.Image = global::GiocoDadiFerrari4H.Properties.Resources.Dado_1_norm;
            this.pb_d2_1.Location = new System.Drawing.Point(176, 200);
            this.pb_d2_1.Name = "pb_d2_1";
            this.pb_d2_1.Size = new System.Drawing.Size(47, 50);
            this.pb_d2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_d2_1.TabIndex = 8;
            this.pb_d2_1.TabStop = false;
            // 
            // tb_giocata
            // 
            this.tb_giocata.Location = new System.Drawing.Point(479, 212);
            this.tb_giocata.Name = "tb_giocata";
            this.tb_giocata.Size = new System.Drawing.Size(95, 20);
            this.tb_giocata.TabIndex = 31;
            // 
            // FormNormale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_giocata);
            this.Controls.Add(this.tb_giro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.pb_d2_6);
            this.Controls.Add(this.pb_d2_5);
            this.Controls.Add(this.pb_d2_4);
            this.Controls.Add(this.pb_d2_3);
            this.Controls.Add(this.pb_d2_2);
            this.Controls.Add(this.pb_d1_6);
            this.Controls.Add(this.pb_d1_5);
            this.Controls.Add(this.pb_d1_4);
            this.Controls.Add(this.pb_d1_3);
            this.Controls.Add(this.pb_d1_2);
            this.Controls.Add(this.pb_ovest_turno);
            this.Controls.Add(this.pb_sud_turno);
            this.Controls.Add(this.pb_est_turno);
            this.Controls.Add(this.pb_nord_turno);
            this.Controls.Add(this.pb_nord);
            this.Controls.Add(this.pb_sud);
            this.Controls.Add(this.pb_ovest);
            this.Controls.Add(this.pb_est);
            this.Controls.Add(this.pb_d1_1);
            this.Controls.Add(this.pb_d2_1);
            this.Controls.Add(this.tb_class_partita);
            this.Controls.Add(this.tb_class_turno);
            this.Name = "FormNormale";
            this.Text = "FormNormale";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ovest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_est)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d2_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_class_turno;
        private System.Windows.Forms.TextBox tb_class_partita;
        private System.ComponentModel.BackgroundWorker bgw_nord;
        private System.ComponentModel.BackgroundWorker bgw_est;
        private System.ComponentModel.BackgroundWorker bgw_sud;
        private System.ComponentModel.BackgroundWorker bgw_ovest;
        private System.Windows.Forms.PictureBox pb_d2_1;
        private System.Windows.Forms.PictureBox pb_d1_1;
        private System.Windows.Forms.PictureBox pb_est;
        private System.Windows.Forms.PictureBox pb_ovest;
        private System.Windows.Forms.PictureBox pb_sud;
        private System.Windows.Forms.PictureBox pb_nord;
        private System.Windows.Forms.PictureBox pb_nord_turno;
        private System.Windows.Forms.PictureBox pb_est_turno;
        private System.Windows.Forms.PictureBox pb_sud_turno;
        private System.Windows.Forms.PictureBox pb_ovest_turno;
        private System.Windows.Forms.PictureBox pb_d1_2;
        private System.Windows.Forms.PictureBox pb_d1_3;
        private System.Windows.Forms.PictureBox pb_d1_4;
        private System.Windows.Forms.PictureBox pb_d1_5;
        private System.Windows.Forms.PictureBox pb_d1_6;
        private System.Windows.Forms.PictureBox pb_d2_2;
        private System.Windows.Forms.PictureBox pb_d2_3;
        private System.Windows.Forms.PictureBox pb_d2_4;
        private System.Windows.Forms.PictureBox pb_d2_5;
        private System.Windows.Forms.PictureBox pb_d2_6;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tb_giro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_lotr;
        private System.Windows.Forms.Button btn_hp;
        private System.Windows.Forms.Button btn_pirati;
        private System.Windows.Forms.TextBox tb_giocata;
    }
}

