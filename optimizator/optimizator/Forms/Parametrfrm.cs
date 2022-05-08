using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using optimizator.Controllers;

namespace optimizator.Forms
{
    public partial class Parametrfrm : Form
    {
        public Parametrfrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void deftoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(deftoggle, label25);
        }

        private void updatetoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(updatetoggle, label26);
        }

        private void firewalltoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(firewalltoggle, label27);
        }

        private void smartsctoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(smartsctoggle, label28);
        }

        private void accelltoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(accelltoggle, label29);
        }

        private void messagetoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(messagetoggle, label30);
        }

        private void gamebartoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(gamebartoggle, label31);
        }

        private void zaliptoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(zaliptoggle, label32);
        }

        private void fonappstoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(fonappstoggle, label33);
        }

        private void telemetrytoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(telemetrytoggle, label34);
        }

        private void autorunstoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(autorunstoggle, label35);
        }

        private void fastdotoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(fastdotoggle, label36);
        }
    }
}
