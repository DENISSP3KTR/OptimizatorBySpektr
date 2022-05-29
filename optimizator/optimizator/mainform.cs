using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using optimizator.Forms;
using optimizator.Properties;
namespace optimizator
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        public int state = 0;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private Button currentBtn;
        private Form activeFrm;
        private void ActiveBtn(object btnsender)
        {
            if (btnsender != null && btnsender!=currentBtn)
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
            ToolTip t = new ToolTip();
            t.SetToolTip(closeBtn, "Выход");
            t.SetToolTip(collapseBtn, "Свернуть");
            this.Icon = Resources.windicon1;
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = Resources.closeicon2;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = Resources.closeicon;
        }

        private void collapseBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        private void OpenChildFrm(Form childFrm, object btnsender)
        {
            if (activeFrm != null)
            {
                activeFrm.Close();
            }
            ActiveBtn(btnsender);
            activeFrm = childFrm;
            childFrm.TopLevel = false;
            childFrm.FormBorderStyle = FormBorderStyle.None;
            childFrm.Dock = DockStyle.Fill;
            this.panelfrm.Controls.Add(childFrm);
            this.panelfrm.Tag = childFrm;
            childFrm.BackColor = Color.DimGray;
            childFrm.BringToFront();
            childFrm.Show();
        }

        private void tweakbtn_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Reestrfrm(), sender);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Clearfrm(), sender);
        }

        private void servicebtn_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Servicefrm(), sender);
        }

        private void parametrbtn_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Parametrfrm(), sender);
        }
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
    }
}
