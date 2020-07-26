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

    
    public partial class addUserControl : UserControl
    {
        private static addUserControl _instance;
        public static addUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new addUserControl();
                }
                return _instance;
            }
        }
        public addUserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database3.mdf;Integrated Security=True");

        private void addUserControl_Load(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }

        
        

        public void Refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
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
                dataGridView3.DataSource = DS.Tables[0];
                
                }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("booksadd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNos", textBox2.Text);
            cmd.Parameters.AddWithValue("@name", textBox3.Text);
            cmd.Parameters.AddWithValue("@author", textBox4.Text);
            cmd.Parameters.AddWithValue("@publisher", textBox5.Text);
           

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
            Refresh_DataGridView();
            MessageBox.Show("ADDED SUCESSFULLY");



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        
            textBox5.Text = "";
            textBox4.Text = "";
            Refresh_DataGridView();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksDelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNos", textBox2.Text);

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
                Refresh_DataGridView();
                MessageBox.Show("DELETED SUCESSFULLY");


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ss_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNos", textBox1.Text);

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
                dataGridView3.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }




        }
    }
}
