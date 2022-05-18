
namespace optimizator.Forms
{
    partial class Reestrfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AutoUptoggle = new optimizator.Controllers.ToggleSwitch();
            this.UACtoggle = new optimizator.Controllers.ToggleSwitch();
            this.gybertoggle = new optimizator.Controllers.ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SMTtoggle = new optimizator.Controllers.ToggleSwitch();
            this.LANEnertoggle = new optimizator.Controllers.ToggleSwitch();
            this.FSOtoggle = new optimizator.Controllers.ToggleSwitch();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(217, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 48);
            this.button1.TabIndex = 25;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label8.Location = new System.Drawing.Point(387, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Будет отключен";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(387, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Будет отключен";
            this.label7.Visible = false;
            // 
            // AutoUptoggle
            // 
            this.AutoUptoggle.AutoSize = true;
            this.AutoUptoggle.Location = new System.Drawing.Point(570, 111);
            this.AutoUptoggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.AutoUptoggle.Name = "AutoUptoggle";
            this.AutoUptoggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.AutoUptoggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.AutoUptoggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AutoUptoggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.AutoUptoggle.Size = new System.Drawing.Size(45, 22);
            this.AutoUptoggle.TabIndex = 21;
            this.AutoUptoggle.UseVisualStyleBackColor = true;
            this.AutoUptoggle.CheckedChanged += new System.EventHandler(this.AutoUptoggle_CheckedChanged);
            // 
            // UACtoggle
            // 
            this.UACtoggle.AutoSize = true;
            this.UACtoggle.Location = new System.Drawing.Point(570, 62);
            this.UACtoggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.UACtoggle.Name = "UACtoggle";
            this.UACtoggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.UACtoggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.UACtoggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.UACtoggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.UACtoggle.Size = new System.Drawing.Size(45, 22);
            this.UACtoggle.TabIndex = 20;
            this.UACtoggle.UseVisualStyleBackColor = true;
            this.UACtoggle.CheckedChanged += new System.EventHandler(this.UACtoggle_CheckedChanged);
            // 
            // gybertoggle
            // 
            this.gybertoggle.AutoSize = true;
            this.gybertoggle.Location = new System.Drawing.Point(570, 13);
            this.gybertoggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.gybertoggle.Name = "gybertoggle";
            this.gybertoggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.gybertoggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.gybertoggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.gybertoggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.gybertoggle.Size = new System.Drawing.Size(45, 22);
            this.gybertoggle.TabIndex = 19;
            this.gybertoggle.UseVisualStyleBackColor = true;
            this.gybertoggle.CheckedChanged += new System.EventHandler(this.gybertoggle_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(601, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "_________________________________________________________________________________" +
    "__________________\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Автообновления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "_________________________________________________________________________________" +
    "__________________\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отключение UAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выключение гибернации";
            // 
            // SMTtoggle
            // 
            this.SMTtoggle.AutoSize = true;
            this.SMTtoggle.Location = new System.Drawing.Point(570, 258);
            this.SMTtoggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.SMTtoggle.Name = "SMTtoggle";
            this.SMTtoggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.SMTtoggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.SMTtoggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SMTtoggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.SMTtoggle.Size = new System.Drawing.Size(45, 22);
            this.SMTtoggle.TabIndex = 34;
            this.SMTtoggle.UseVisualStyleBackColor = true;
            this.SMTtoggle.CheckedChanged += new System.EventHandler(this.SMTtoggle_CheckedChanged);
            // 
            // LANEnertoggle
            // 
            this.LANEnertoggle.AutoSize = true;
            this.LANEnertoggle.Location = new System.Drawing.Point(570, 209);
            this.LANEnertoggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.LANEnertoggle.Name = "LANEnertoggle";
            this.LANEnertoggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.LANEnertoggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.LANEnertoggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.LANEnertoggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.LANEnertoggle.Size = new System.Drawing.Size(45, 22);
            this.LANEnertoggle.TabIndex = 33;
            this.LANEnertoggle.UseVisualStyleBackColor = true;
            this.LANEnertoggle.CheckedChanged += new System.EventHandler(this.LANEnertoggle_CheckedChanged);
            // 
            // FSOtoggle
            // 
            this.FSOtoggle.AutoSize = true;
            this.FSOtoggle.Location = new System.Drawing.Point(570, 160);
            this.FSOtoggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.FSOtoggle.Name = "FSOtoggle";
            this.FSOtoggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.FSOtoggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.FSOtoggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.FSOtoggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.FSOtoggle.Size = new System.Drawing.Size(45, 22);
            this.FSOtoggle.TabIndex = 32;
            this.FSOtoggle.UseVisualStyleBackColor = true;
            this.FSOtoggle.CheckedChanged += new System.EventHandler(this.FSOtoggle_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(601, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "_________________________________________________________________________________" +
    "__________________\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(12, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(233, 26);
            this.label14.TabIndex = 30;
            this.label14.Text = "Spectre, Meldown, Tsx";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(601, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "_________________________________________________________________________________" +
    "__________________\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(12, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(326, 26);
            this.label16.TabIndex = 28;
            this.label16.Text = "Энергосбережение интернета";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(601, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "_________________________________________________________________________________" +
    "__________________\r\n";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(12, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 26);
            this.label18.TabIndex = 26;
            this.label18.Text = "FSO и GameBar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(387, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "Будет отключен";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label10.Location = new System.Drawing.Point(387, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "Будет отключен";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(387, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 26);
            this.label11.TabIndex = 37;
            this.label11.Text = "Будет отключен";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label12.Location = new System.Drawing.Point(387, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 26);
            this.label12.TabIndex = 38;
            this.label12.Text = "Будет отключен";
            this.label12.Visible = false;
            // 
            // Reestrfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(643, 457);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SMTtoggle);
            this.Controls.Add(this.LANEnertoggle);
            this.Controls.Add(this.FSOtoggle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AutoUptoggle);
            this.Controls.Add(this.UACtoggle);
            this.Controls.Add(this.gybertoggle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reestrfrm";
            this.Text = "Reestrfrm";
            this.Load += new System.EventHandler(this.Reestrfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Controllers.ToggleSwitch AutoUptoggle;
        private Controllers.ToggleSwitch UACtoggle;
        private Controllers.ToggleSwitch gybertoggle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controllers.ToggleSwitch SMTtoggle;
        private Controllers.ToggleSwitch LANEnertoggle;
        private Controllers.ToggleSwitch FSOtoggle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}