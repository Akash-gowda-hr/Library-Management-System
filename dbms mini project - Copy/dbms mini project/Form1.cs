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

namespace dbms_mini_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"|DataDirectory|\\Database3.mdf\";Integrated Security = True");//connection string
        SqlCommand cmd;
        SqlDataReader dr;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private string getusername()
        {
            // fetch data from database
            con.Open();
            string syntax = "SELECT value FROM systemtable where  property='username'"; ;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private string getpassword()
        {
            // fetch data from database
            con.Open();
            string syntax = "SELECT value FROM systemtable where  property='password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();

            return temp;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            getusername();
            string uname = getusername(), upass = getpassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(uname) && pass.Equals(upass))
            {
                //login
                label3.Hide();
                appbody obj = new appbody();
                this.Hide();
                obj.Show();

            }
            else
            {
                //dont login
                label3.Show();
            }

        }


    }
}

