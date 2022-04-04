using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optimizator
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        Image closeicon1 = Image.FromFile("D:/github/optimizatorbyspektr/img/closeicon.png");
        Image closeicon2 = Image.FromFile("D:/github/optimizatorbyspektr/img/closeicon2.png");
        public int state = 0;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = closeicon2;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = closeicon1;
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            if(state == 0)
            {
                WindowState = FormWindowState.Maximized;
                state = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                state = 0;
            }
        }
    }
}
