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
    public partial class FrmRapor : Form
    {
        private List<OdaRezervasyon> odaRez;

        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<OdaRezervasyon> odaRez):this()
        {
            this.odaRez = odaRez;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            foreach(OdaRezervasyon item in odaRez) 
            {
                ListViewItem listViewItem = new ListViewItem(item.Musteri.AdSoyad);
                listViewItem.SubItems.Add(item.Musteri.TC);
                listViewItem.SubItems.Add(item.Oda.Numarasi.ToString());
                listViewItem.SubItems.Add(item.Musteri.GirisTarihi.ToString());
                listViewItem.SubItems.Add(item.Musteri.Tel);
                listViewItem.SubItems.Add(item.Musteri.KisiSayısı.ToString());
                listView1.Items.Add(listViewItem);

            }
        }
    }
}
