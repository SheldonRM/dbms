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
    public partial class Staff_UserControl : UserControl
    {

        private static Staff_UserControl _instance;
        public static Staff_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Staff_UserControl();
                }
                return _instance;
            }
        }


        public Staff_UserControl()
        {
            InitializeComponent();
        }

        private void Staff_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
