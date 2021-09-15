using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_OKUL
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }


        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();

        }
        string cinsiyet = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
         
            ds.OgrenciEkle(TxtOgrAd.Text, TxtOgrSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), cinsiyet);

            MessageBox.Show("Öğrenci Ekleme İşlemi Başarıyla Gerçekleşti!");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            MessageBox.Show("Listelendi!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // TxtOgrId.Text = comboBox1.SelectedValue.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtOgrId.Text));
            MessageBox.Show("Öğrenci Silme İşlemi Başarıyla Gerçekleşti!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtOgrAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtOgrSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //Radiobutton !!!!
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text,byte.Parse(comboBox1.SelectedValue.ToString()), cinsiyet,int.Parse(TxtOgrId.Text));
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Kız";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ds.OgrenciGetir(TxtAra.Text);
        }
    }
}
