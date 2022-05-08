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
    public partial class Clearfrm : Form
    {
        public Clearfrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void deltelemtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(deltelemtoggle, label7);
        }

        private void musortoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(musortoggle, label8);
        }

        private void deeptoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(deeptoggle, label9);
        }
    }
}
