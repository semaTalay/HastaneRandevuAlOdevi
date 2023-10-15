namespace HastaneRandevuAlOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisiler = new List<Kisi>();
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.AdSoyad = txtAdSoyad.Text;
            kisi.Tc = mtxtTc.Text;
            kisi.Telefon = mtxtTelefon.Text;
            kisi.Cinsiyet = rdbKadin.Checked ? "Kadýn" : "Erkek";
            kisi.Poliklinik = cboxPoliklinik.SelectedItem.ToString();
            kisi.Tarih = dtpTarih.Value;
            if (rdb12.Checked) { kisi.Saat = "12.00"; }
            else if (rdb13.Checked) { kisi.Saat = "13.00"; }
            else if (rdb14.Checked) { kisi.Saat = "14.00"; }
            else { kisi.Saat = "15.00"; }


            DialogResult dialogResult = MessageBox.Show("Gerçekten Kaydetmek Ýstiyor Musunuz?", "Mesaj", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                kisiler.Add(kisi);
                ListBoxaEkle();
                MessageBox.Show("Kaydedildi");
                Clear();
            }


        }

        public void ListBoxaEkle()
        {
            Kisi kisi = new Kisi();
            lstKisiler.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                lstKisiler.Items.Add($"{kisi1.AdSoyad} - {kisi1.Poliklinik} - {kisi1.Tarih}- {kisi1.Saat}");
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex != -1)
            {
                int index = lstKisiler.SelectedIndex;
                Kisi secilikisi = kisiler[index];
                MessageBox.Show($"Ad Soyad : {secilikisi.AdSoyad}\n TC :{secilikisi.Tc}\n Cinsiyet  : {secilikisi.Cinsiyet}");

            }
            else
            {
                MessageBox.Show("Bir kiþi seçilemedi");
            }

        }


        private void Clear()
        {
            txtAdSoyad.Text = "";
            mtxtTc.Text = "";
            mtxtTelefon.Text = "";
            rdb12.Checked = false;
            rdb13.Checked = false;
            rdb14.Checked = false;
            rdb15.Checked = false;
            rdbErkek.Checked = false;
            rdbKadin.Checked = false;
        }
    }
}