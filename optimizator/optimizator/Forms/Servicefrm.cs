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
    public partial class Servicefrm : Form
    {
        public Servicefrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void KARTYtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(KARTYtoggle, label7);
        }

        private void XBOXtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(XBOXtoggle, label8);
        }

        private void Printtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Printtoggle, label9);
        }

        private void Bluetoothtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Bluetoothtoggle, label10);
        }

        private void Sysmaintoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Sysmaintoggle, label11);
        }

        private void Storetoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Storetoggle, label12);
        }
    }
}
