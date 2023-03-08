using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace simple_register_login
{
    public partial class register : System.Web.UI.Page
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

            MySqlCommand sorgu1 = new MySqlCommand("select * from users where u_username= " + "'" + TextBox1.Text + "'", baglanti1);
            baglanti1.Open();
            MySqlDataReader oku = sorgu1.ExecuteReader();

            if (oku.Read())
            {

                Response.Write("<script>alert('Bu kayıt daha önce yapılmış!')</script>");

                baglanti1.Close();
            }

            else if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Response.Write("<script>alert('Boş Alan Bırakmayınız!')</script>");
            }

            else
            {
                baglanti1.Close();
                string sorgu = "insert into users (u_username,u_password) Values (@u_username,@u_password)";
                MySqlCommand kayitEkle = new MySqlCommand(sorgu, baglanti1);
                kayitEkle.Parameters.AddWithValue("@u_username", TextBox1.Text);
                kayitEkle.Parameters.AddWithValue("@u_password", TextBox2.Text);

                baglanti1.Open();
                kayitEkle.ExecuteNonQuery();
                baglanti1.Close();
            }
        }
    }
}