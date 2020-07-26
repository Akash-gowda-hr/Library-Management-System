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
    public partial class aboutUserControl : UserControl
    {
        private static aboutUserControl _instance;

        public static aboutUserControl Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new aboutUserControl();
                }
                return _instance;
            }
        }

        public aboutUserControl()
        {
            InitializeComponent();
        }

        private void aboutUserControl_Load(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database3.mdf;Integrated Security=True");

        public void Refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("reportdatagridview_sp", con);
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
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("report1_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@year_of_pub", textBox1.Text);

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
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("report2_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@author", textBox2.Text);

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
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }




        private void button4_Click(object sender, EventArgs e)
        {
           /* try
            {
                SqlCommand cmd = new SqlCommand("report3_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", textBox3.Text);

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
                dataGridView.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }*/



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }
    }
}
