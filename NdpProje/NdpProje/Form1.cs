/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:NDP Proje Ödevi
**				ÖĞRENCİ ADI............:FATİH DURMAZ
**				ÖĞRENCİ NUMARASI.......:G191210064
**              DERSİN ALINDIĞI GRUP...:2/B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProje
{
    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; set; }
    }

    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }

        bool Ekle(IAtik atik1,IAtik atik2);

        bool Bosalt();
    }

    public partial class Form1 : Form
    {
        Salatalik salatalik= new Salatalik();
        Domates domates = new Domates();
        Bardak bardak = new Bardak();
        CamSise camSise = new CamSise();
        Dergi dergi = new Dergi();
        Gazete gazete = new Gazete();
        KolaKutusu kolaKutusu = new KolaKutusu();
        SalcaKutusu salcaKutusu = new SalcaKutusu();

        OrganikAtikKutusu organikAtik = new OrganikAtikKutusu();
        KagitKutusu kagit = new KagitKutusu();
        CamKutusu cam = new CamKutusu();
        MetalKutusu metal = new MetalKutusu()

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void ResimAta()
        {
            Random random = new Random();

            int rastegeleResim = random.Next(1, 9);

            if (rastegeleResim == 1)
            {
                pictureBox1.Image = salatalik.Image;
                atikUrun = "salatalik";
            }
            if (rastegeleResim == 2)
            {
                pictureBox1.Image = domates.Image;
                atikUrun = "domates";
            }
            if (rastegeleResim == 3)
            {
                pictureBox1.Image = dergi.Image;
                atikUrun = "dergi";
            }
            if (rastegeleResim == 4)
            {
                pictureBox1.Image = gazete.Image;
                atikUrun = "gazete";
            }
            if (rastegeleResim == 5)
            {
                pictureBox1.Image = bardak.Image;
                atikUrun = "bardak";
            }
            if (rastegeleResim == 6)
            {
                pictureBox1.Image = camSise.Image;
                atikUrun = "camSise";
            }
            if (rastegeleResim == 7)
            {
                pictureBox1.Image = kolaKutusu.Image;
                atikUrun = "kolaKutusu";
            }
            if (rastegeleResim == 8)
            {
                pictureBox1.Image = salcaKutusu.Image;
                atikUrun = "salcaKutusu";
            }
        }

        public string atikUrun;
        public int sayac = 60;
        public int toplamPuan = 0;

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            if (sayac == 60)
            {
                timer1.Start();

                ResimAta();

                btnYeniOyun.ForeColor= System.Drawing.Color.Turquoise;
                lblSureSayaci.BackColor = System.Drawing.Color.Turquoise;
                lblSureSayaci.ForeColor = System.Drawing.SystemColors.ButtonFace;
                lblPuanGöstergesi.BackColor = System.Drawing.Color.Turquoise;
                lblPuanGöstergesi.ForeColor = System.Drawing.SystemColors.ButtonFace;

                btnOrganikEkle.Enabled = true;
                btnOrganikBosalt.Enabled = true;
                lstOrganikAtik.Enabled = true;

                btnKagitEkle.Enabled = true;
                btnKagitBosalt.Enabled = true;
                lstKagit.Enabled = true;

                btnCamEkle.Enabled = true;
                btnCamBosalt.Enabled = true;
                lstCam.Enabled = true;

                btnMetalEkle.Enabled = true;
                btnMetalBosalt.Enabled = true;
                lstMetal.Enabled = true;

                lstCam.Items.Clear();
                lstKagit.Items.Clear();
                lstMetal.Items.Clear();
                lstOrganikAtik.Items.Clear();

                prgCam.Value = 0;
                prgKagit.Value = 0;
                prgMetal.Value = 0;
                prgOrganik.Value = 0;

                toplamPuan = 0;
                lblPuanGöstergesi.Text = "0";          
            }     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            
            lblSureSayaci.Text = sayac.ToString();

            if (sayac == 0)
            {
                timer1.Stop();
                sayac = 60;

                btnYeniOyun.ForeColor = System.Drawing.SystemColors.ButtonFace;
                lblSureSayaci.BackColor = System.Drawing.SystemColors.Window;
                lblSureSayaci.ForeColor = System.Drawing.Color.Turquoise;
                lblPuanGöstergesi.BackColor = System.Drawing.SystemColors.Window;
                lblPuanGöstergesi.ForeColor = System.Drawing.Color.Turquoise;

                btnOrganikEkle.Enabled = false;
                btnOrganikBosalt.Enabled = false;
                lstOrganikAtik.Enabled = false;

                btnKagitEkle.Enabled = false;
                btnKagitBosalt.Enabled = false;
                lstKagit.Enabled = false;

                btnCamEkle.Enabled = false;
                btnCamBosalt.Enabled = false;
                lstCam.Enabled = false;

                btnMetalEkle.Enabled = false;
                btnMetalBosalt.Enabled = false;
                lstMetal.Enabled = false;
            }
        }

        public int organikDoluluk = 0;
        private void btnOrganikEkle_Click(object sender, EventArgs e)
        {
            organikAtik.Kapasite = 700;
            prgOrganik.Maximum = organikAtik.Kapasite;
            organikAtik.DoluHacim = organikDoluluk;
 
            bool kontrol1= organikAtik.Ekle(domates,salatalik);

            if (kontrol1) 
            {
                if (atikUrun == "salatalik")
                {
                    lstOrganikAtik.Items.Add("Salatalık(120)");
                    toplamPuan += salatalik.Hacim;
                    organikDoluluk += salatalik.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgOrganik.Value += salatalik.Hacim;
                    ResimAta();

                }
                else if (atikUrun == "domates")
                {
                    lstOrganikAtik.Items.Add("Domates(150)");
                    toplamPuan += domates.Hacim;
                    organikDoluluk += domates.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgOrganik.Value += domates.Hacim;
                    ResimAta();
                }
            }         
        }

        public int kagitDoluluk = 0;
        private void btnKagitEkle_Click(object sender, EventArgs e)
        {
            kagit.Kapasite = 1200;
            prgKagit.Maximum = kagit.Kapasite;
            kagit.DoluHacim = kagitDoluluk;

            bool kontrol2 = kagit.Ekle(dergi, gazete);

            if (kontrol2) 
            {
                if (atikUrun == "dergi")
                {
                    lstKagit.Items.Add("Dergi(200)");
                    toplamPuan += dergi.Hacim;
                    kagitDoluluk += dergi.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgKagit.Value += dergi.Hacim;
                    ResimAta();
                }
                else if (atikUrun == "gazete")
                {
                    lstKagit.Items.Add("Gazete(250)");
                    toplamPuan += gazete.Hacim;
                    kagitDoluluk += gazete.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgKagit.Value += gazete.Hacim;
                    ResimAta();
                }
            }
        }

        public int camDoluluk = 0;
        private void btnCamEkle_Click(object sender, EventArgs e)
        {
            cam.Kapasite = 2200;
            prgCam.Maximum = cam.Kapasite;
            cam.DoluHacim = camDoluluk;

            bool kontrol3 = cam.Ekle(bardak, camSise);

            if (kontrol3)
            {
                if (atikUrun == "bardak")
                {
                    lstCam.Items.Add("Bardak(250)");
                    toplamPuan += bardak.Hacim;
                    camDoluluk += bardak.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgCam.Value += bardak.Hacim;
                    ResimAta();
                }
                else if (atikUrun == "camSise")
                {
                    lstCam.Items.Add("Cam Şişe(600)");
                    toplamPuan += camSise.Hacim;
                    camDoluluk += camSise.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgCam.Value += camSise.Hacim;
                    ResimAta();
                }
            }
        }

        public int metalDoluluk = 0;
        private void btnMetalEkle_Click(object sender, EventArgs e)
        {
            metal.Kapasite = 2300;
            prgMetal.Maximum = metal.Kapasite;
            metal.DoluHacim = metalDoluluk;

            bool kontrol4 = metal.Ekle(kolaKutusu, salcaKutusu);
            
            if(kontrol4)
            {
                if (atikUrun == "kolaKutusu")
                {
                    lstMetal.Items.Add("Kola Kutusu(350)");
                    toplamPuan += kolaKutusu.Hacim;
                    metalDoluluk += kolaKutusu.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgMetal.Value += kolaKutusu.Hacim;
                    ResimAta();
                }
                else if (atikUrun == "salcaKutusu")
                {
                    lstMetal.Items.Add("Salça Kutusu(550)");
                    toplamPuan += salcaKutusu.Hacim;
                    metalDoluluk += salcaKutusu.Hacim;
                    lblPuanGöstergesi.Text = toplamPuan.ToString();
                    prgMetal.Value += salcaKutusu.Hacim;
                    ResimAta();
                }
            } 
        }


        private void btnOrganikBosalt_Click(object sender, EventArgs e)
        {
            organikAtik.DoluHacim = organikDoluluk;

            bool kontrol_1 = organikAtik.Bosalt();

            if (kontrol_1) 
            {
                lstOrganikAtik.Items.Clear();
                prgOrganik.Value = 0;
                organikDoluluk = 0;
                toplamPuan += organikAtik.BosaltmaPuani;
                lblPuanGöstergesi.Text = toplamPuan.ToString();
                sayac += 3;
            }
        }

        private void btnKagitBosalt_Click(object sender, EventArgs e)
        {
            kagit.DoluHacim = kagitDoluluk;

            bool kontrol_2 = kagit.Bosalt();

            if (kontrol_2)
            {
                lstKagit.Items.Clear();
                prgKagit.Value = 0;
                kagitDoluluk = 0;
                toplamPuan += kagit.BosaltmaPuani;
                lblPuanGöstergesi.Text = toplamPuan.ToString();
                sayac += 3;
            }
        }

        private void btnCamBosalt_Click(object sender, EventArgs e)
        {
            cam.DoluHacim = camDoluluk;

            bool kontrol_3 = cam.Bosalt();

            if (kontrol_3)
            {
                lstCam.Items.Clear();
                prgCam.Value = 0;
                camDoluluk = 0;
                toplamPuan += cam.BosaltmaPuani;
                lblPuanGöstergesi.Text = toplamPuan.ToString();
                sayac += 3;
            }
        }

        private void btnMetalBosalt_Click(object sender, EventArgs e)
        {
            metal.DoluHacim = metalDoluluk;

            bool kontrol_4 = metal.Bosalt();

            if (kontrol_4)
            {
                lstMetal.Items.Clear();
                prgMetal.Value = 0;
                metalDoluluk = 0;
                toplamPuan += metal.BosaltmaPuani;
                lblPuanGöstergesi.Text = toplamPuan.ToString();
                sayac += 3;
            }
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
