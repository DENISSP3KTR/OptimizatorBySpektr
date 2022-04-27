using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optimizator.Forms
{
    public partial class Clearfrm : Form
    {
        public Clearfrm()
        {
            InitializeComponent();
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch1.Checked == true)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void toggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch2.Checked == true)
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
        }

        private void toggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch3.Checked == true)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
        }
    }
}
