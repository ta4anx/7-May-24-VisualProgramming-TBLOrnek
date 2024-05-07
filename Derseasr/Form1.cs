using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Derseasr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Servera baðlanmak için gerekli olan baðlantý cümlesini oluþturuyoruz.
            //SQL Servera baðlanýyoruz.
            //SqlConnection baglanti = new SqlConnection("Data Source=DESKYTOP-KAAN;Initial Catalog=ders;Integrated Security=True");
            //sqlconnection sýnýfýný kullnrak bir sunucuya baðlanýyoruz.
            //öncelikle sqlconnection sýnýfýndan bir nesne oluþturuyoruz.
            //sqlconnection sýnhýfýndan nrrsneyi þöyle oluþturabiliriz.
            //sqlconnection baglanti = new sqlconnection();
            //Integrated Security=True; bu kod parçasý veritabanýna windows authentication ile baðlanmamýzý saðlar.
            //Data Source=DESKTOP-KAAN; bu kod parçasý veritabanýna baðlanacaðýmýz sunucunun adýný belirtir.
            //SqlCommand sýnýfý ile sql sorgularýný çalýþtýrabiliriz.
            //sqlcommand sýnýfýndan bir nesne oluþturarak sql sorgularýný çalýþtýrabiliriz.
            //sqlcommand sýnýfýndan bir nesne oluþturmak için þu kod parçasýný kullanabiliriz.
            //Sunucuda çalýþtýrmak istediðimizkomutu SqlCOmmand sýnýfýndan bir nesne oluþturarak çalýþtýrabiliriz.
            //Sqlcommand sýnýfýndan bir nesne oluþturmak için þu kod parçasýný kullanabiliriz.
            //SqlCommand komut = new SqlCommand();
            //SqlCommand komut = new SqlCommand("insert into ogrenci (ad,soyad,numara) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglanti);
            //SqlCommand("insert into ogrenci (ad,soyad,numara) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglanti);
            //komut.ExecuteNonQuery();

            //komut.ExecuteReader(); bu kod parçasý veritabanýndan veri okumamýzý saðlar.
            //komut.ExecuteScaler(); bu kod parçasý veritabanýndan tek bir deðer okumamýzý saðlar.
            //insert update delete iþlemlerinde ExecuteNonQuery() kullanýlýr.
            //select iþlemlerinde ExecuteReader() kullanýlýr.
            //tek bir deðer okumak için ExecuteScaler() kullanýlýr.
            //baglanti.Open(); bu kod parçasý veritabanýna baðlanmamýzý saðlar.
            //baglanti.Close(); bu kod parçasý veritabaný baðlantýsýný kapatýr.

            string ad, tel, mem;
            int yas;
            ad = textBox1.Text;
            tel = textBox2.Text;
            mem = textBox4.Text;
            yas = Convert.ToInt32(textBox3.Text);

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KAAN;Initial Catalog=ders;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into ogrenci (ad,soyad,numara,yas) values ('" + ad + "','" + tel + "','" + mem + "','" + yas + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Kayýt Eklendi");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear(); 
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KAAN;Initial Catalog=ders;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from ogrenci", baglanti);
            cmd.ExecuteReader dr= cmd.ExecuteReader();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
