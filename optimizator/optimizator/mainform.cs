﻿using System;
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
        private Button currentBtn;
        private void ActiveBtn(object btnsender)
        {
            if (btnsender != null)
            {
                DisableBtn();
                if (currentBtn != (Button)btnsender)
                {
                    currentBtn = (Button)btnsender;
                    currentBtn.BackColor = Color.FromArgb(86, 151, 151, 219);
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Constantia",18F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                }
            }
        }
        private void DisableBtn()
        {
            foreach(Control control in panelmenu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(51, 51, 76);
                    control.ForeColor = Color.Gainsboro;
                    control.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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

        private void collapseBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void resizeBtn_MouseEnter(object sender, EventArgs e)
        {
            resizeBtn.BackColor = Color.FromArgb(129, 129, 234);
        }

        private void resizeBtn_MouseLeave(object sender, EventArgs e)
        {
            resizeBtn.BackColor = Color.FromArgb(134, 134, 194);
        }

        private void collapseBtn_MouseEnter(object sender, EventArgs e)
        {
            collapseBtn.BackColor = Color.FromArgb(129, 129, 234);
        }

        private void collapseBtn_MouseLeave(object sender, EventArgs e)
        {
            collapseBtn.BackColor = Color.FromArgb(134, 134, 194);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void tweakbtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
        }

        private void servicebtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
        }

        private void parametrbtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
        }
    }
}
