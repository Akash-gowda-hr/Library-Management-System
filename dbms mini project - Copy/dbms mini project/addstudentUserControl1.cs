using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_mini_project
{
    public partial class addstudentUserControl1 : UserControl
    {

        private static addstudentUserControl1 _instance;

        public static addstudentUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new addstudentUserControl1();
                }
                return _instance;
            }
        }

        private void issueUserControl_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database3.mdf;Integrated Security=True");
        public addstudentUserControl1()
        {
            InitializeComponent();
        }

        private void addstudentUserControl1_Load(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }

        public void Refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("studentdatagrisview", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<INVALID SQL OPERATION>>:\n" + ex);

                }
                con.Close();
                dataGridView2.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


         private void button1_Click(object sender, EventArgs e)
         {
            SqlCommand cmd = new SqlCommand("addstud", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usn", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox4.Text);
            cmd.Parameters.AddWithValue("@adress", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox5.Text);
            

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<INVALID SQL OPERATION>>>:\n" + ex);
            }
            con.Close();
            MessageBox.Show("ADDED SUCESSFULLY");
            Refresh_DataGridView();
            


         }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
            textBox4.Text = "";
            textBox5.Text = "";
            
            textBox7.Text = "";
            Refresh_DataGridView();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchstudentdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usn", textBox7.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<INVALID SQL OPERATION>>:\n" + ex);

                }
                con.Close();
                dataGridView2.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
