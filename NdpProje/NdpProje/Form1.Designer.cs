namespace NdpProje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.prgOrganik = new System.Windows.Forms.ProgressBar();
            this.btnOrganikBosalt = new System.Windows.Forms.Button();
            this.btnOrganikEkle = new System.Windows.Forms.Button();
            this.lstOrganikAtik = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prgKagit = new System.Windows.Forms.ProgressBar();
            this.btnKagitBosalt = new System.Windows.Forms.Button();
            this.btnKagitEkle = new System.Windows.Forms.Button();
            this.lstKagit = new System.Windows.Forms.ListBox();
            this.lblAtikKutulari = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prgCam = new System.Windows.Forms.ProgressBar();
            this.btnCamBosalt = new System.Windows.Forms.Button();
            this.btnCamEkle = new System.Windows.Forms.Button();
            this.lstCam = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prgMetal = new System.Windows.Forms.ProgressBar();
            this.btnMetalBosalt = new System.Windows.Forms.Button();
            this.btnMetalEkle = new System.Windows.Forms.Button();
            this.lstMetal = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPuanGöstergesi = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblSureSayaci = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.prgOrganik);
            this.panel1.Controls.Add(this.btnOrganikBosalt);
            this.panel1.Controls.Add(this.btnOrganikEkle);
            this.panel1.Controls.Add(this.lstOrganikAtik);
            this.panel1.Location = new System.Drawing.Point(280, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 301);
            this.panel1.TabIndex = 1;
            // 
            // prgOrganik
            // 
            this.prgOrganik.Enabled = false;
            this.prgOrganik.Location = new System.Drawing.Point(19, 223);
            this.prgOrganik.Name = "prgOrganik";
            this.prgOrganik.Size = new System.Drawing.Size(143, 23);
            this.prgOrganik.Step = 1;
            this.prgOrganik.TabIndex = 3;
            // 
            // btnOrganikBosalt
            // 
            this.btnOrganikBosalt.Location = new System.Drawing.Point(19, 252);
            this.btnOrganikBosalt.Name = "btnOrganikBosalt";
            this.btnOrganikBosalt.Size = new System.Drawing.Size(143, 39);
            this.btnOrganikBosalt.TabIndex = 2;
            this.btnOrganikBosalt.Text = "BOŞALT";
            this.btnOrganikBosalt.UseVisualStyleBackColor = true;
            this.btnOrganikBosalt.Click += new System.EventHandler(this.btnOrganikBosalt_Click);
            // 
            // btnOrganikEkle
            // 
            this.btnOrganikEkle.Location = new System.Drawing.Point(19, 8);
            this.btnOrganikEkle.Name = "btnOrganikEkle";
            this.btnOrganikEkle.Size = new System.Drawing.Size(143, 39);
            this.btnOrganikEkle.TabIndex = 1;
            this.btnOrganikEkle.Text = "ORGANİK ATIK";
            this.btnOrganikEkle.UseVisualStyleBackColor = true;
            this.btnOrganikEkle.Click += new System.EventHandler(this.btnOrganikEkle_Click);
            // 
            // lstOrganikAtik
            // 
            this.lstOrganikAtik.FormattingEnabled = true;
            this.lstOrganikAtik.ItemHeight = 16;
            this.lstOrganikAtik.Location = new System.Drawing.Point(19, 53);
            this.lstOrganikAtik.Name = "lstOrganikAtik";
            this.lstOrganikAtik.Size = new System.Drawing.Size(143, 164);
            this.lstOrganikAtik.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.prgKagit);
            this.panel2.Controls.Add(this.btnKagitBosalt);
            this.panel2.Controls.Add(this.btnKagitEkle);
            this.panel2.Controls.Add(this.lstKagit);
            this.panel2.Location = new System.Drawing.Point(471, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 301);
            this.panel2.TabIndex = 2;
            // 
            // prgKagit
            // 
            this.prgKagit.Location = new System.Drawing.Point(19, 223);
            this.prgKagit.Name = "prgKagit";
            this.prgKagit.Size = new System.Drawing.Size(143, 23);
            this.prgKagit.TabIndex = 3;
            // 
            // btnKagitBosalt
            // 
            this.btnKagitBosalt.Location = new System.Drawing.Point(19, 252);
            this.btnKagitBosalt.Name = "btnKagitBosalt";
            this.btnKagitBosalt.Size = new System.Drawing.Size(143, 39);
            this.btnKagitBosalt.TabIndex = 2;
            this.btnKagitBosalt.Text = "BOŞALT";
            this.btnKagitBosalt.UseVisualStyleBackColor = true;
            this.btnKagitBosalt.Click += new System.EventHandler(this.btnKagitBosalt_Click);
            // 
            // btnKagitEkle
            // 
            this.btnKagitEkle.Location = new System.Drawing.Point(19, 8);
            this.btnKagitEkle.Name = "btnKagitEkle";
            this.btnKagitEkle.Size = new System.Drawing.Size(143, 39);
            this.btnKagitEkle.TabIndex = 1;
            this.btnKagitEkle.Text = "KAĞIT";
            this.btnKagitEkle.UseVisualStyleBackColor = true;
            this.btnKagitEkle.Click += new System.EventHandler(this.btnKagitEkle_Click);
            // 
            // lstKagit
            // 
            this.lstKagit.FormattingEnabled = true;
            this.lstKagit.ItemHeight = 16;
            this.lstKagit.Location = new System.Drawing.Point(19, 53);
            this.lstKagit.Name = "lstKagit";
            this.lstKagit.Size = new System.Drawing.Size(143, 164);
            this.lstKagit.TabIndex = 0;
            // 
            // lblAtikKutulari
            // 
            this.lblAtikKutulari.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblAtikKutulari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtikKutulari.Location = new System.Drawing.Point(280, 22);
            this.lblAtikKutulari.Name = "lblAtikKutulari";
            this.lblAtikKutulari.Size = new System.Drawing.Size(376, 23);
            this.lblAtikKutulari.TabIndex = 3;
            this.lblAtikKutulari.Text = "ATIK KUTULARI";
            this.lblAtikKutulari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.prgCam);
            this.panel3.Controls.Add(this.btnCamBosalt);
            this.panel3.Controls.Add(this.btnCamEkle);
            this.panel3.Controls.Add(this.lstCam);
            this.panel3.Location = new System.Drawing.Point(280, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 301);
            this.panel3.TabIndex = 4;
            // 
            // prgCam
            // 
            this.prgCam.Location = new System.Drawing.Point(19, 223);
            this.prgCam.Name = "prgCam";
            this.prgCam.Size = new System.Drawing.Size(143, 23);
            this.prgCam.TabIndex = 3;
            // 
            // btnCamBosalt
            // 
            this.btnCamBosalt.Location = new System.Drawing.Point(19, 252);
            this.btnCamBosalt.Name = "btnCamBosalt";
            this.btnCamBosalt.Size = new System.Drawing.Size(143, 39);
            this.btnCamBosalt.TabIndex = 2;
            this.btnCamBosalt.Text = "BOŞALT";
            this.btnCamBosalt.UseVisualStyleBackColor = true;
            this.btnCamBosalt.Click += new System.EventHandler(this.btnCamBosalt_Click);
            // 
            // btnCamEkle
            // 
            this.btnCamEkle.Location = new System.Drawing.Point(19, 8);
            this.btnCamEkle.Name = "btnCamEkle";
            this.btnCamEkle.Size = new System.Drawing.Size(143, 39);
            this.btnCamEkle.TabIndex = 1;
            this.btnCamEkle.Text = "CAM";
            this.btnCamEkle.UseVisualStyleBackColor = true;
            this.btnCamEkle.Click += new System.EventHandler(this.btnCamEkle_Click);
            // 
            // lstCam
            // 
            this.lstCam.FormattingEnabled = true;
            this.lstCam.ItemHeight = 16;
            this.lstCam.Location = new System.Drawing.Point(19, 53);
            this.lstCam.Name = "lstCam";
            this.lstCam.Size = new System.Drawing.Size(143, 164);
            this.lstCam.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.prgMetal);
            this.panel4.Controls.Add(this.btnMetalBosalt);
            this.panel4.Controls.Add(this.btnMetalEkle);
            this.panel4.Controls.Add(this.lstMetal);
            this.panel4.Location = new System.Drawing.Point(471, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 301);
            this.panel4.TabIndex = 6;
            // 
            // prgMetal
            // 
            this.prgMetal.Location = new System.Drawing.Point(19, 223);
            this.prgMetal.Name = "prgMetal";
            this.prgMetal.Size = new System.Drawing.Size(143, 23);
            this.prgMetal.TabIndex = 3;
            // 
            // btnMetalBosalt
            // 
            this.btnMetalBosalt.Location = new System.Drawing.Point(19, 252);
            this.btnMetalBosalt.Name = "btnMetalBosalt";
            this.btnMetalBosalt.Size = new System.Drawing.Size(143, 39);
            this.btnMetalBosalt.TabIndex = 2;
            this.btnMetalBosalt.Text = "BOŞALT";
            this.btnMetalBosalt.UseVisualStyleBackColor = true;
            this.btnMetalBosalt.Click += new System.EventHandler(this.btnMetalBosalt_Click);
            // 
            // btnMetalEkle
            // 
            this.btnMetalEkle.Location = new System.Drawing.Point(19, 8);
            this.btnMetalEkle.Name = "btnMetalEkle";
            this.btnMetalEkle.Size = new System.Drawing.Size(143, 39);
            this.btnMetalEkle.TabIndex = 1;
            this.btnMetalEkle.Text = "METAL";
            this.btnMetalEkle.UseVisualStyleBackColor = true;
            this.btnMetalEkle.Click += new System.EventHandler(this.btnMetalEkle_Click);
            // 
            // lstMetal
            // 
            this.lstMetal.FormattingEnabled = true;
            this.lstMetal.ItemHeight = 16;
            this.lstMetal.Location = new System.Drawing.Point(19, 53);
            this.lstMetal.Name = "lstMetal";
            this.lstMetal.Size = new System.Drawing.Size(143, 164);
            this.lstMetal.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.Controls.Add(this.lblPuanGöstergesi);
            this.panel5.Controls.Add(this.lblPuan);
            this.panel5.Controls.Add(this.btnCikis);
            this.panel5.Controls.Add(this.lblSureSayaci);
            this.panel5.Controls.Add(this.btnYeniOyun);
            this.panel5.Controls.Add(this.lblSure);
            this.panel5.Location = new System.Drawing.Point(26, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 407);
            this.panel5.TabIndex = 7;
            // 
            // lblPuanGöstergesi
            // 
            this.lblPuanGöstergesi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuanGöstergesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuanGöstergesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuanGöstergesi.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPuanGöstergesi.Location = new System.Drawing.Point(31, 242);
            this.lblPuanGöstergesi.Name = "lblPuanGöstergesi";
            this.lblPuanGöstergesi.Size = new System.Drawing.Size(177, 48);
            this.lblPuanGöstergesi.TabIndex = 5;
            this.lblPuanGöstergesi.Text = "0";
            this.lblPuanGöstergesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuan.Location = new System.Drawing.Point(31, 207);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(177, 35);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Text = "PUAN";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(31, 315);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(177, 71);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSureSayaci
            // 
            this.lblSureSayaci.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSureSayaci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSureSayaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureSayaci.ForeColor = System.Drawing.Color.Turquoise;
            this.lblSureSayaci.Location = new System.Drawing.Point(31, 141);
            this.lblSureSayaci.Name = "lblSureSayaci";
            this.lblSureSayaci.Size = new System.Drawing.Size(177, 48);
            this.lblSureSayaci.TabIndex = 2;
            this.lblSureSayaci.Text = "60";
            this.lblSureSayaci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYeniOyun.Location = new System.Drawing.Point(31, 19);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(177, 71);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSure.Location = new System.Drawing.Point(31, 106);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(177, 35);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "SÜRE";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Menu;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(26, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 226);
            this.panel6.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(686, 674);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblAtikKutulari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prgOrganik;
        private System.Windows.Forms.Button btnOrganikBosalt;
        private System.Windows.Forms.Button btnOrganikEkle;
        private System.Windows.Forms.ListBox lstOrganikAtik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar prgKagit;
        private System.Windows.Forms.Button btnKagitBosalt;
        private System.Windows.Forms.Button btnKagitEkle;
        private System.Windows.Forms.ListBox lstKagit;
        private System.Windows.Forms.Label lblAtikKutulari;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar prgCam;
        private System.Windows.Forms.Button btnCamBosalt;
        private System.Windows.Forms.Button btnCamEkle;
        private System.Windows.Forms.ListBox lstCam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar prgMetal;
        private System.Windows.Forms.Button btnMetalBosalt;
        private System.Windows.Forms.Button btnMetalEkle;
        private System.Windows.Forms.ListBox lstMetal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSureSayaci;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label lblPuanGöstergesi;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
    }
}

