
namespace optimizator
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelfrm = new System.Windows.Forms.Panel();
            this.servicebtn = new System.Windows.Forms.Button();
            this.parametrbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.tweakbtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.collapseBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.collapseBtn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmenu.Controls.Add(this.servicebtn);
            this.panelmenu.Controls.Add(this.parametrbtn);
            this.panelmenu.Controls.Add(this.clearbtn);
            this.panelmenu.Controls.Add(this.tweakbtn);
            resources.ApplyResources(this.panelmenu, "panelmenu");
            this.panelmenu.Name = "panelmenu";
            // 
            // panelfrm
            // 
            this.panelfrm.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.panelfrm, "panelfrm");
            this.panelfrm.Name = "panelfrm";
            // 
            // servicebtn
            // 
            this.servicebtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.servicebtn, "servicebtn");
            this.servicebtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.servicebtn.Image = global::optimizator.Properties.Resources.serviceicon;
            this.servicebtn.Name = "servicebtn";
            this.servicebtn.UseVisualStyleBackColor = true;
            this.servicebtn.Click += new System.EventHandler(this.servicebtn_Click);
            // 
            // parametrbtn
            // 
            this.parametrbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.parametrbtn, "parametrbtn");
            this.parametrbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.parametrbtn.Image = global::optimizator.Properties.Resources.parametricon;
            this.parametrbtn.Name = "parametrbtn";
            this.parametrbtn.UseVisualStyleBackColor = true;
            this.parametrbtn.Click += new System.EventHandler(this.parametrbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.clearbtn, "clearbtn");
            this.clearbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.clearbtn.Image = global::optimizator.Properties.Resources.musoricon;
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // tweakbtn
            // 
            this.tweakbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.tweakbtn, "tweakbtn");
            this.tweakbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.tweakbtn.Image = global::optimizator.Properties.Resources.reestricon;
            this.tweakbtn.Name = "tweakbtn";
            this.tweakbtn.UseVisualStyleBackColor = true;
            this.tweakbtn.Click += new System.EventHandler(this.tweakbtn_Click);
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::optimizator.Properties.Resources.closeicon;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // collapseBtn
            // 
            resources.ApplyResources(this.collapseBtn, "collapseBtn");
            this.collapseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapseBtn.Image = global::optimizator.Properties.Resources.collapseicon;
            this.collapseBtn.Name = "collapseBtn";
            this.collapseBtn.TabStop = false;
            this.collapseBtn.Click += new System.EventHandler(this.collapseBtn_Click);
            this.collapseBtn.MouseEnter += new System.EventHandler(this.collapseBtn_MouseEnter);
            this.collapseBtn.MouseLeave += new System.EventHandler(this.collapseBtn_MouseLeave);
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panelfrm);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "mainform";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox collapseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button parametrbtn;
        private System.Windows.Forms.Button servicebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button tweakbtn;
        private System.Windows.Forms.Panel panelfrm;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}

