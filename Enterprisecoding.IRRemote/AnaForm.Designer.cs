namespace Enterprisecoding.IRRemote
{
    partial class AnaForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.lblKod = new System.Windows.Forms.TextBox();
            this.btnKodOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSinyalKalitesi = new System.Windows.Forms.Label();
            this.lblIlerleme = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOgren = new System.Windows.Forms.Button();
            this.lblTasiyiciFrekans = new System.Windows.Forms.Label();
            this.pbSinyalKalitesi = new System.Windows.Forms.ProgressBar();
            this.pbIlerleme = new System.Windows.Forms.ProgressBar();
            this.gbOgrenmeSonucu = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnKoduSakla = new System.Windows.Forms.Button();
            this.tbEylemAdi = new System.Windows.Forms.TextBox();
            this.lblIRKodu = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOgrenmeSonucu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 1;
            label1.Text = "İlerleme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 13);
            label2.TabIndex = 3;
            label2.Text = "Sinyal Kalitesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 13);
            label3.TabIndex = 4;
            label3.Text = "Taşıyıcı Frekans";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 13);
            label4.TabIndex = 0;
            label4.Text = "IR Kodu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(10, 43);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 13);
            label8.TabIndex = 4;
            label8.Text = "Eylem Adı";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.lblKod);
            groupBox2.Controls.Add(this.btnKodOlustur);
            groupBox2.Location = new System.Drawing.Point(13, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(441, 217);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kod Üretimi";
            // 
            // lblKod
            // 
            this.lblKod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKod.Location = new System.Drawing.Point(13, 45);
            this.lblKod.Multiline = true;
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(422, 166);
            this.lblKod.TabIndex = 1;
            // 
            // btnKodOlustur
            // 
            this.btnKodOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKodOlustur.Location = new System.Drawing.Point(360, 19);
            this.btnKodOlustur.Name = "btnKodOlustur";
            this.btnKodOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnKodOlustur.TabIndex = 0;
            this.btnKodOlustur.Text = "&Kod Oluştur";
            this.btnKodOlustur.UseVisualStyleBackColor = true;
            this.btnKodOlustur.Click += new System.EventHandler(this.btnKodOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblSinyalKalitesi);
            this.groupBox1.Controls.Add(this.lblIlerleme);
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnOgren);
            this.groupBox1.Controls.Add(this.lblTasiyiciFrekans);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.pbSinyalKalitesi);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.pbIlerleme);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenme";
            // 
            // lblSinyalKalitesi
            // 
            this.lblSinyalKalitesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSinyalKalitesi.AutoSize = true;
            this.lblSinyalKalitesi.Location = new System.Drawing.Point(399, 50);
            this.lblSinyalKalitesi.Name = "lblSinyalKalitesi";
            this.lblSinyalKalitesi.Size = new System.Drawing.Size(21, 13);
            this.lblSinyalKalitesi.TabIndex = 9;
            this.lblSinyalKalitesi.Text = "%0";
            // 
            // lblIlerleme
            // 
            this.lblIlerleme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIlerleme.AutoSize = true;
            this.lblIlerleme.Location = new System.Drawing.Point(399, 20);
            this.lblIlerleme.Name = "lblIlerleme";
            this.lblIlerleme.Size = new System.Drawing.Size(21, 13);
            this.lblIlerleme.TabIndex = 8;
            this.lblIlerleme.Text = "%0";
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Enabled = false;
            this.btnIptal.Location = new System.Drawing.Point(360, 100);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "&İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOgren
            // 
            this.btnOgren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOgren.Location = new System.Drawing.Point(279, 100);
            this.btnOgren.Name = "btnOgren";
            this.btnOgren.Size = new System.Drawing.Size(75, 23);
            this.btnOgren.TabIndex = 6;
            this.btnOgren.Text = "&Öğren";
            this.btnOgren.UseVisualStyleBackColor = true;
            this.btnOgren.Click += new System.EventHandler(this.btnOgren_Click);
            // 
            // lblTasiyiciFrekans
            // 
            this.lblTasiyiciFrekans.AutoSize = true;
            this.lblTasiyiciFrekans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTasiyiciFrekans.Location = new System.Drawing.Point(99, 80);
            this.lblTasiyiciFrekans.Name = "lblTasiyiciFrekans";
            this.lblTasiyiciFrekans.Size = new System.Drawing.Size(11, 13);
            this.lblTasiyiciFrekans.TabIndex = 5;
            this.lblTasiyiciFrekans.Text = "-";
            // 
            // pbSinyalKalitesi
            // 
            this.pbSinyalKalitesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSinyalKalitesi.Location = new System.Drawing.Point(99, 45);
            this.pbSinyalKalitesi.Name = "pbSinyalKalitesi";
            this.pbSinyalKalitesi.Size = new System.Drawing.Size(293, 23);
            this.pbSinyalKalitesi.TabIndex = 2;
            // 
            // pbIlerleme
            // 
            this.pbIlerleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbIlerleme.Location = new System.Drawing.Point(99, 15);
            this.pbIlerleme.Name = "pbIlerleme";
            this.pbIlerleme.Size = new System.Drawing.Size(293, 23);
            this.pbIlerleme.TabIndex = 0;
            // 
            // gbOgrenmeSonucu
            // 
            this.gbOgrenmeSonucu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOgrenmeSonucu.Controls.Add(this.btnTest);
            this.gbOgrenmeSonucu.Controls.Add(this.btnKoduSakla);
            this.gbOgrenmeSonucu.Controls.Add(this.tbEylemAdi);
            this.gbOgrenmeSonucu.Controls.Add(label8);
            this.gbOgrenmeSonucu.Controls.Add(this.lblIRKodu);
            this.gbOgrenmeSonucu.Controls.Add(label4);
            this.gbOgrenmeSonucu.Enabled = false;
            this.gbOgrenmeSonucu.Location = new System.Drawing.Point(13, 150);
            this.gbOgrenmeSonucu.Name = "gbOgrenmeSonucu";
            this.gbOgrenmeSonucu.Size = new System.Drawing.Size(441, 97);
            this.gbOgrenmeSonucu.TabIndex = 1;
            this.gbOgrenmeSonucu.TabStop = false;
            this.gbOgrenmeSonucu.Text = "Öğrenme Sonucu";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(279, 68);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "&Test Et";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnKoduSakla
            // 
            this.btnKoduSakla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKoduSakla.Location = new System.Drawing.Point(360, 68);
            this.btnKoduSakla.Name = "btnKoduSakla";
            this.btnKoduSakla.Size = new System.Drawing.Size(75, 23);
            this.btnKoduSakla.TabIndex = 6;
            this.btnKoduSakla.Text = "&Sakla";
            this.btnKoduSakla.UseVisualStyleBackColor = true;
            this.btnKoduSakla.Click += new System.EventHandler(this.btnKoduSakla_Click);
            // 
            // tbEylemAdi
            // 
            this.tbEylemAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEylemAdi.Location = new System.Drawing.Point(99, 39);
            this.tbEylemAdi.Name = "tbEylemAdi";
            this.tbEylemAdi.Size = new System.Drawing.Size(336, 20);
            this.tbEylemAdi.TabIndex = 5;
            // 
            // lblIRKodu
            // 
            this.lblIRKodu.AutoSize = true;
            this.lblIRKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIRKodu.Location = new System.Drawing.Point(99, 20);
            this.lblIRKodu.Name = "lblIRKodu";
            this.lblIRKodu.Size = new System.Drawing.Size(11, 13);
            this.lblIRKodu.TabIndex = 2;
            this.lblIRKodu.Text = "-";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 483);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.gbOgrenmeSonucu);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "IR Kod üretici";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOgrenmeSonucu.ResumeLayout(false);
            this.gbOgrenmeSonucu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSinyalKalitesi;
        private System.Windows.Forms.Label lblIlerleme;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOgren;
        private System.Windows.Forms.Label lblTasiyiciFrekans;
        private System.Windows.Forms.ProgressBar pbSinyalKalitesi;
        private System.Windows.Forms.ProgressBar pbIlerleme;
        private System.Windows.Forms.GroupBox gbOgrenmeSonucu;
        private System.Windows.Forms.Button btnKoduSakla;
        private System.Windows.Forms.TextBox tbEylemAdi;
        private System.Windows.Forms.Label lblIRKodu;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox lblKod;
        private System.Windows.Forms.Button btnKodOlustur;

    }
}