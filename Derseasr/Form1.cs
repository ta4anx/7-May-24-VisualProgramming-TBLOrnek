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
            //SQL Servera ba�lanmak i�in gerekli olan ba�lant� c�mlesini olu�turuyoruz.
            //SQL Servera ba�lan�yoruz.
            //SqlConnection baglanti = new SqlConnection("Data Source=DESKYTOP-KAAN;Initial Catalog=ders;Integrated Security=True");
            //sqlconnection s�n�f�n� kullnrak bir sunucuya ba�lan�yoruz.
            //�ncelikle sqlconnection s�n�f�ndan bir nesne olu�turuyoruz.
            //sqlconnection s�nh�f�ndan nrrsneyi ��yle olu�turabiliriz.
            //sqlconnection baglanti = new sqlconnection();
            //Integrated Security=True; bu kod par�as� veritaban�na windows authentication ile ba�lanmam�z� sa�lar.
            //Data Source=DESKTOP-KAAN; bu kod par�as� veritaban�na ba�lanaca��m�z sunucunun ad�n� belirtir.
            //SqlCommand s�n�f� ile sql sorgular�n� �al��t�rabiliriz.
            //sqlcommand s�n�f�ndan bir nesne olu�turarak sql sorgular�n� �al��t�rabiliriz.
            //sqlcommand s�n�f�ndan bir nesne olu�turmak i�in �u kod par�as�n� kullanabiliriz.
            //Sunucuda �al��t�rmak istedi�imizkomutu SqlCOmmand s�n�f�ndan bir nesne olu�turarak �al��t�rabiliriz.
            //Sqlcommand s�n�f�ndan bir nesne olu�turmak i�in �u kod par�as�n� kullanabiliriz.
            //SqlCommand komut = new SqlCommand();
            //SqlCommand komut = new SqlCommand("insert into ogrenci (ad,soyad,numara) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglanti);
            //SqlCommand("insert into ogrenci (ad,soyad,numara) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglanti);
            //komut.ExecuteNonQuery();

            //komut.ExecuteReader(); bu kod par�as� veritaban�ndan veri okumam�z� sa�lar.
            //komut.ExecuteScaler(); bu kod par�as� veritaban�ndan tek bir de�er okumam�z� sa�lar.
            //insert update delete i�lemlerinde ExecuteNonQuery() kullan�l�r.
            //select i�lemlerinde ExecuteReader() kullan�l�r.
            //tek bir de�er okumak i�in ExecuteScaler() kullan�l�r.
            //baglanti.Open(); bu kod par�as� veritaban�na ba�lanmam�z� sa�lar.
            //baglanti.Close(); bu kod par�as� veritaban� ba�lant�s�n� kapat�r.

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
            MessageBox.Show("Kay�t Eklendi");



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
