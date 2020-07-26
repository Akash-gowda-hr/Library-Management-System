using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms_mini_project
{
    public partial class returnUserControl : UserControl
    {
        private static returnUserControl _instance;

        public static returnUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new returnUserControl();
                }
                return _instance;
            }
        }

        public returnUserControl()
        {
            InitializeComponent();
        }

        private void returnUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
