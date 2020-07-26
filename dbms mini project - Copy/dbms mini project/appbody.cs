using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace dbms_mini_project
{
    public partial class appbody : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public appbody()
        {
            InitializeComponent();
            isSlidingPannelExpanded = true;
            expandSlidingPannelGUI();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!ContentPanel.Controls.Contains(issueUserControl.Instance))
            {
                ContentPanel.Controls.Add(issueUserControl.Instance);
                issueUserControl.Instance.Dock = DockStyle.Fill;
                issueUserControl.Instance.BringToFront();

            }
            else
            {
                issueUserControl.Instance.BringToFront();
            }









        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void log_in_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.325;
            }
            else
            {
                log_in_timer.Stop();
            }
        }



        private void appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            log_in_timer.Start();

        }

        bool isSlidingPannelExpanded;
        const int MaxSlidderWidth = 210;
        const int MinSliderWidth = 100;


        public void retractSlidingPannelGUI()
        {
            //GUI for expanding
            addstudenttabbutton.Text = "";
            booktabbutton.Text = "";
            issue_tab_button.Text = "";
           
            about_tab_button.Text = "";
            
            

            slidingpaneltogglebutton.Image = Properties.Resources.right;

            addstudenttabbutton.Image = Properties.Resources.new_user__2_;
            booktabbutton.Image = Properties.Resources.open_book;
            issue_tab_button.Image = Properties.Resources.add;
           // about_tab_button.Image = Properties.Resources.information_button;
            
            
        }

        public void expandSlidingPannelGUI()
        {
            //GUI for expanding
            addstudenttabbutton.Text = "ADD STUDENT";
            booktabbutton.Text = " ADD BOOKS";
            issue_tab_button.Text = "TRANSCATION";
            about_tab_button.Text = "REPORT GENERATION";
            

            slidingpaneltogglebutton.Image = Properties.Resources.left;

            addstudenttabbutton.Image = null;
            booktabbutton.Image = null;
            issue_tab_button.Image = null;
            about_tab_button.Image = null;
            
        }




        private void slidingpaneltogglebutton_Click(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract pannel
                retractSlidingPannelGUI();
            }
            sliding_panel_timer.Start();

        }

        private void sliding_panel_timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract pannel
                sliding_panel.Width -= 30;
                if (sliding_panel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = false;
                    sliding_panel_timer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                //expand the pannel
                sliding_panel.Width += 30;
                if (sliding_panel.Width >= MaxSlidderWidth)
                {
                    //stop expanding
                    isSlidingPannelExpanded = true;
                    sliding_panel_timer.Stop();
                    expandSlidingPannelGUI();
                    this.Refresh();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void booktabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(addUserControl.Instance))
            {
                ContentPanel.Controls.Add(addUserControl.Instance);
                addUserControl.Instance.Dock = DockStyle.Fill;
                addUserControl.Instance.BringToFront();

            }
            else
            {
                addUserControl.Instance.BringToFront();
            }

        }

        private void return_tab_button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(returnUserControl.Instance))
            {
                ContentPanel.Controls.Add(returnUserControl.Instance);
                returnUserControl.Instance.Dock = DockStyle.Fill;
                returnUserControl.Instance.BringToFront();

            }
            else
            {
                returnUserControl.Instance.BringToFront();
            }

        }

        private void about_tab_button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(aboutUserControl.Instance))
            {
                ContentPanel.Controls.Add(aboutUserControl.Instance);
                aboutUserControl.Instance.Dock = DockStyle.Fill;
                aboutUserControl.Instance.BringToFront();

            }
            else
            {
                aboutUserControl.Instance.BringToFront();
            }

        }

        private void addstudenttabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(addstudentUserControl1.Instance))
            {
                ContentPanel.Controls.Add(addstudentUserControl1.Instance);
                addstudentUserControl1.Instance.Dock = DockStyle.Fill;
                addstudentUserControl1.Instance.BringToFront();

            }
            else
            {
                addstudentUserControl1.Instance.BringToFront();
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sliding_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

    

