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
    public partial class issueUserControl : UserControl
    {
        private static issueUserControl _instance;

        public static issueUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new issueUserControl();
                }
                return _instance;
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database3.mdf;Integrated Security=True");


        public issueUserControl()
        {
            InitializeComponent();
        }

        private void issueUserControl_Load(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void Refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showtranscation_SP", con);
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
            SqlCommand cmd = new SqlCommand("inserttranscations_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@card_nos", textBox1.Text);
            cmd.Parameters.AddWithValue("@accNos", textBox2.Text);
            cmd.Parameters.AddWithValue("@issue_date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@return_date", dateTimePicker2.Text);
            


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
            MessageBox.Show("BOOK ISSUED SUCCESSFULLY");
            Refresh_DataGridView();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("return_book_SP", con);
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
                MessageBox.Show("BOOK RETURNED SUCCESSFULLY");


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Refresh_DataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchreturn_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNos", textBox3.Text);

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
    }
}
