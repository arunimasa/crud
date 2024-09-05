using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-4128Q006\\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ttt values(@id,@name,@age)", con);
            cmd.Parameters.AddWithValue("@id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name",textBox2.Text);
            cmd.Parameters.AddWithValue("@age",double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("succesfully saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-4128Q006\\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update ttt set name =@name,age=@age where id =@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("succesfully updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-4128Q006\\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ttt where id =@id",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("succesfully deleted");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-4128Q006\\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ttt ",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da .Fill(dt);

            dataGridView1.DataSource=dt;
        }
    }
}
