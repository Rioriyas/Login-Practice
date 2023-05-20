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


namespace example1
{
    public partial class Regform : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn= new SqlConnection();
        public Regform()
        {
            conn.ConnectionString = "data source = RIYAS\\SQLEXPRESS;initial catalog = practice;integrated security = true";
            conn.Open();
            InitializeComponent();
        }
            protected void Submit_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO reg"+"(firstname,lastname,email,password)VALUES(@Firstname,@Lastname,@Email,@Password)",conn);
            cmd.Parameters.Add(new SqlParameter("@Firstname",fname.Text));
            cmd.Parameters.Add(new SqlParameter("@Lastname",lname.Text));
            cmd.Parameters.Add(new SqlParameter("@Email",emailtext.Text));
            cmd.Parameters.Add(new SqlParameter("@Password",pwdtext.Text));
            cmd.ExecuteNonQuery();
            info.Text = "Submit Successfully !";

        }
    }
}
