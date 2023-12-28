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

namespace Hospital_project
{
    public partial class frm_hasta_kayit : Form
    {
        public frm_hasta_kayit()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        sqlConnect bgl = new sqlConnect();
        private void sign_up_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into (hasta_adi, hasta_soyadi, hasta_TC, hasta_telefon, hasta_sifre, hasta_cinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti("Data Source=Alp\\SQLEXPRESS;Initial Catalog=Hospital_project;Integrated Security=True;Trust Server Certificate=True"));
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", txtNumber.Text);
            komut.Parameters.AddWithValue("@p4", txtPhoneNumber.Text);
            komut.Parameters.AddWithValue("@p5", txtPassword.Text);
            komut.Parameters.AddWithValue("@p6", cmbSex.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız başarıyla oluşturuldu.. Şifreniz: " + txtPassword.Text,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
