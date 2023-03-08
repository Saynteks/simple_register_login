using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace simple_register_login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            /*
            create database simple_register_login

            create table users(
            u_username varchar(30),
            u_password varchar(30) 
            )
             */
            MySqlConnection baglanti1;
            string connectionString = "server=localhost;database=simple_register_login;uid=?;pwd=?";
            baglanti1 = new MySqlConnection(connectionString);
            baglanti1.Open();
            MySqlCommand sorgu = new MySqlCommand("select * from users where u_username=@u_username and u_password=@u_password", baglanti1);
            sorgu.Parameters.AddWithValue("@u_username", TextBox1.Text);
            sorgu.Parameters.AddWithValue("@u_password", TextBox2.Text);
            MySqlDataReader oku;
            oku = sorgu.ExecuteReader();


            if (oku.Read())
            {
                Session.Add("kullaniciAdi", oku["u_username"]);
                Response.Write("<script>alert('Oturum Açıldı!')</script>"+Session["kullaniciAdi"].ToString());
            }
            else
            {
                Response.Write("<script>alert('Hatalı Giriş!')</script>");
            }
            oku.Close();
            baglanti1.Close();
        }
    }
}