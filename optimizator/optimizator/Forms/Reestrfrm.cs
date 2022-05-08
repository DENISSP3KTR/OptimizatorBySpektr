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
    public partial class Reestrfrm : Form
    {
        public Reestrfrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void gybertoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(gybertoggle, label7);
        }

        private void UACtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(UACtoggle, label8);
        }

        private void AutoUptoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(AutoUptoggle, label9);
        }

        private void FSOtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(FSOtoggle, label10);
        }

        private void LANEnertoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(LANEnertoggle, label11);
        }

        private void SMTtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(SMTtoggle, label12);
        }
    }
}
