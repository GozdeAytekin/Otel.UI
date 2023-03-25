using Otel.CommonClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Otelcim.org
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }
        
        private void ekMalzeme()  
        {
            string[] malzemeAdlari = { "Alkollü İçecekler", "Atıştırmalıklar", "Gazlı İçecekler", "Şekerlemeler","Bisküvi","Kurabiye","Kahve Çeşitleri","Çay ve Çeşitleri" };

            int[] malzemeFiyatlari = { 200, 25, 10, 5,10,20,50,10 };

            for (int i = 0; i < malzemeAdlari.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = malzemeAdlari[i];
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.Tag = new Minibar()
                {
                    UrunAdı = malzemeAdlari[i],
                    UrunFiyati = malzemeFiyatlari[i],
                };
                flEkMalzeme.Controls.Add(checkBox);
            }
            #region MyRegion
            //CheckBox checkBox1 = new CheckBox();
            //checkBox1.Text = "Alkollü İçecekler";
            //checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox1.Tag = new Minibar()
            //{
            //    UrunAdı = "Alkollü İçecekler",
            //    UrunFiyati = 200,
            //};
            //flEkMalzeme.Controls.Add(checkBox1);

            //CheckBox checkBox2 = new CheckBox();
            //checkBox2.Text = "Atıştırmalıklar";
            //checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox2.Tag = new Minibar()
            //{
            //    UrunAdı = "Atıştırmalıklar",
            //    UrunFiyati = 25,
            //};
            //flEkMalzeme.Controls.Add(checkBox2);

            //CheckBox checkBox3 = new CheckBox();
            //checkBox3.Text = "Şekerlemeler";
            //checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox3.Tag = new Minibar()
            //{
            //    UrunAdı = "Şekerlemeler",
            //    UrunFiyati = 25,
            //};
            //flEkMalzeme.Controls.Add(checkBox3);

            //CheckBox checkBox4 = new CheckBox();
            //checkBox4.Text = "Büskivi";
            //checkBox4.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox4.Tag = new Minibar()
            //{
            //    UrunAdı = "Büskivi",
            //    UrunFiyati = 10,
            //};
            //flEkMalzeme.Controls.Add(checkBox4);

            //CheckBox checkBox5 = new CheckBox();
            //checkBox5.Text = "Kahve ve Çeşitleri";
            //checkBox5.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox5.Tag = new Minibar()
            //{
            //    UrunAdı = "Kahve ve Çeşitleri",
            //    UrunFiyati = 50,
            //};
            //flEkMalzeme.Controls.Add(checkBox5);

            //CheckBox checkBox6 = new CheckBox();
            //checkBox6.Text = "Çay ve Çeşitleri";
            //checkBox6.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox6.Tag = new Minibar()
            //{
            //    UrunAdı = "Çay ve Çeşitleri",
            //    UrunFiyati = 5,
            //};
            //flEkMalzeme.Controls.Add(checkBox6);

            //CheckBox checkBox7 = new CheckBox();
            //checkBox7.Text = "Gazlı İçecek";
            //checkBox7.CheckedChanged += CheckBox_CheckedChanged;
            //checkBox7.Tag = new Minibar()
            //{
            //    UrunAdı = "Gazlı İçecek",
            //    UrunFiyati = 10,
            //};
            //flEkMalzeme.Controls.Add(checkBox7);


            //flEkMalzeme.Controls.Add(new CheckBox() {Text = "Alkollü İçecekler", Tag = new Minibar() { UrunAdı = "Alkollü İçecekler", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Atıştırmalıklar", Tag = new Minibar() { UrunAdı = "Atıştırmalıklar", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Gazlı İçecekler", Tag = new Minibar() { UrunAdı = "Gazlı İçecekler", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Şekerlemeler", Tag = new Minibar() { UrunAdı = "Şekerlemeler", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Bisküvi", Tag = new Minibar() { UrunAdı = "Bisküvi", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Kurabiye", Tag = new Minibar() { UrunAdı = "Kurabiye", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Kahve Çeşitleri", Tag = new Minibar() { UrunAdı = "Kahve Çeşitleri", UrunFiyati = 5 } });
            //flEkMalzeme.Controls.Add(new CheckBox() { Text = "Çay ve Çeşitleri", Tag = new Minibar() { UrunAdı = "Çay ve Çeşitleri", UrunFiyati = 5 } }); 
            #endregion



        }
        CheckBox tiklananCheckBox = null;
        Label lblurunAd = new Label();
        Label lblFiyat = new Label();

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tiklananCheckBox = sender as CheckBox;
            Minibar minibar = tiklananCheckBox.Tag as Minibar;

            if (tiklananCheckBox.Checked == true)
            {
                lblurunAd.Text = minibar.UrunAdı;
                lblFiyat.Text = Convert.ToString(minibar.UrunFiyati);
            }

        }


     

        Button btnKral = new Button();
        Label labelYataksayı = new Label();
        List<Musteri> musteriler = new List<Musteri>();
        List<Minibar> minibars= new List<Minibar>();
        List<OdaRezervasyon> odaRez = new List<OdaRezervasyon>();

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            ekMalzeme();


            for (int i = 0; i < 10; i++)
            {
                
                Button btn = new Button();
                btn.Text = Convert.ToString(101 + i);
                btn.BackColor = Color.Yellow;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 50,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = OdaDurumu.Bos,
                        YatakSayisi = 1
                    },
                    Musteri = new Musteri()
                    {
                        //Boş
                    }

                };
                btn.Click += Btn_Click;
                flKat1.Controls.Add(btn);

                Button btn2 = new Button();
                btn2.Text = Convert.ToString(201 + i);
                btn2.BackColor = Color.Yellow;
                btn2.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 100,
                        Numarasi = int.Parse(btn2.Text),
                        OdaDurumu = OdaDurumu.Bos,
                        YatakSayisi = 2
                        
                    },
                    Musteri = new Musteri()
                    {
                        //Boş
                    }

                };
                btn2.Click += Btn_Click;
                flKat2.Controls.Add(btn2);

                Button btn3 = new Button();
                btn3.Text = Convert.ToString(301 + i);
                btn3.BackColor = Color.Yellow;
                btn3.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 150,
                        Numarasi = int.Parse(btn3.Text),
                        OdaDurumu = OdaDurumu.Bos,
                        YatakSayisi = 3
                    },
                    Musteri = new Musteri()
                    {
                        //Boş
                    }

                };
                btn3.Click += Btn_Click;
                flKat3.Controls.Add(btn3);


               

            }
            btnKral = new Button();
            btnKral.Text = "Kral Dairesi";
            btnKral.BackColor = Color.Yellow;
            btnKral.Tag = new OdaRezervasyon()
            {
                Oda = new Oda()
                {
                    Fiyat = 1000,
                    Numarasi = 401,
                    OdaDurumu = OdaDurumu.Bos,
                    YatakSayisi = 6
                },
                Musteri = new Musteri()
                {
                    //Boş
                }

            };
            btnKral.Width = 248;
            btnKral.Height = 50;
            btnKral.Click += Btn_Click;
            flKat4.Controls.Add(btnKral);

        }

        Button tiklananButton = null;
       // CheckedListBox tiklananCheckbox = null;

        private void Btn_Click(object sender, EventArgs e)
        {
            // sender?
            tiklananButton = sender as Button;
            OdaRezervasyon rezervasyon = tiklananButton.Tag as OdaRezervasyon;
            groupBox1.Enabled = true;
            lblSecOda.Text = rezervasyon.Oda.Numarasi.ToString();
            lbFiyat.Text = Convert.ToString(rezervasyon.Oda.Fiyat);
            labelYataksayı.Text = rezervasyon.Oda.YatakSayisi.ToString();
            labelCksOda.Text = rezervasyon.Oda.Numarasi.ToString();





            //   MessageBox.Show(tiklananButton.Text + "Tıklandii");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ekleme.
            // Dolu ise yeni ekleme yapılmamış
            OdaRezervasyon rezervasyon = tiklananButton.Tag as OdaRezervasyon;
            
            if (rezervasyon.Oda.OdaDurumu == OdaDurumu.Bos)
            {

                //rez al
                rezervasyon.Musteri = new Musteri()
                {
                    AdSoyad = txtAd.Text,
                    GirisTarihi = dateTimePicker1.Value,
                    TC = mtxtboxTC.Text,
                    Tel = mtxtboxTelefon.Text,
                    KisiSayısı = Convert.ToInt32(nmKisi.Value),
                };
                odaRez.Add(rezervasyon);
                musteriler.Add(rezervasyon.Musteri);
                rezervasyon.Oda.Numarasi = int.Parse(lblSecOda.Text);
                rezervasyon.Oda.Fiyat = Convert.ToDouble(lbFiyat.Text);
                rezervasyon.Oda.YatakSayisi = Convert.ToByte(labelYataksayı.Text);
                rezervasyon.Oda.OdaDurumu = OdaDurumu.Dolu;
                label21.Text = Convert.ToString(rezervasyon.Oda.Fiyat);

                tiklananButton.BackColor = Color.Red;
                tabControl2.SelectedTab = tabControl2.TabPages[1];
           


            }
            else
            {
                // oda dolu
                MessageBox.Show("Oda dolu");
            }
            // click gibi yöntemler tarafımızca yönlendirilebilir.
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1) // Eğer ikinci sekme seçiliyse
            {
                // ComboBox içindeki öğeleri yükle
                comboBox1.Items.Clear();
                foreach (Musteri item in musteriler)
                {
                    comboBox1.Items.Add(item.AdSoyad);

                }

                // vb. devam eder
 // RadioButton2'e tıklandığında çağrılacak yöntemi ayarla

                if(labelCksOda.Text.Contains("1"))
                {
                    labelCksKat.Text = "1.Kat";
                }
                if (labelCksOda.Text.Contains("2"))
                {
                    labelCksKat.Text = "2.Kat";
                }
               if (labelCksOda.Text.Contains("3"))
                {
                    labelCksKat.Text = "3.Kat";
                }
                if (labelCksOda.Text.Contains("4"))
                {
                    labelCksKat.Text = "4.Kat";
                }
                


            }
            else
            {
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            // RadioButton1'e tıklandığında yapılacak işlemleri buraya yazın
          

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            // RadioButton2'e tıklandığında yapılacak işlemleri buraya yazın

        }
        decimal minibarFiyat;
        decimal otelF;
        private void buttonbarekle_Click(object sender, EventArgs e)
        {
            //minibar ekleme.

            otelF = Convert.ToDecimal(label21.Text);
            Minibar minibar = tiklananButton.Tag as Minibar;


            minibar = new Minibar()
            {
                UrunAdı = lblurunAd.Text,
                UrunFiyati = Convert.ToDecimal(lblFiyat.Text),
                
            };
            minibars.Add(minibar);
            minibarFiyat = minibar.UrunFiyati * nmMinibar.Value;

            label10.Text = minibarFiyat.ToString();

            label21.Text = Convert.ToString(minibarFiyat + otelF);

                //rezervasyon.Oda.Numarasi = int.Parse(lblSecOda.Text);
                //rezervasyon.Oda.Fiyat = Convert.ToDouble(lbFiyat.Text);
                //rezervasyon.Oda.YatakSayisi = Convert.ToByte(labelYataksayı.Text);
                //rezervasyon.Oda.OdaDurumu = OdaDurumu.Dolu;

                //tiklananButton.BackColor = Color.Red;
                //tabControl2.SelectedTab = tabControl2.TabPages[1];


        
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            otelF = Convert.ToDecimal(lbFiyat.Text);

            TimeSpan gunFarki = dateTimePicker1.Value - dateTimePicker2.Value;
          
            int gunSayisi = (int)gunFarki.TotalDays;
            label21.Text = (otelF * Math.Abs(gunSayisi)).ToString();
            foreach (Minibar item in minibars)
            {
                item.UrunFiyati = Convert.ToDecimal(label21.Text);
            }
            flEkMalzeme.Enabled=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödemeniz Yapılmıştır.Teşekkür ederiz.");
            FrmRapor frm= new FrmRapor(odaRez);
            frm.Show();
            this.Hide();

        }

        private void lbFiyat_Click(object sender, EventArgs e)
        {

        }

        private void flKat2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
