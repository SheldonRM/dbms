using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Records_UserControl : UserControl
    {

        private static Records_UserControl _instance;
        public static Records_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Records_UserControl();
                }
                return _instance;
            }
        }



        public Records_UserControl()
        {
            InitializeComponent();
        }

        private void Records_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
