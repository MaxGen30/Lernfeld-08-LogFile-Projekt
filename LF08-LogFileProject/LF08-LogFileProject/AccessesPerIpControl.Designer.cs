namespace LF08_LogFileProject
{
    partial class AccessesPerIpControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActivateTimespanCB = new System.Windows.Forms.CheckBox();
            this.ActivateIpCB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteIpB = new System.Windows.Forms.Button();
            this.deleteAllB = new System.Windows.Forms.Button();
            this.IpB = new System.Windows.Forms.Button();
            this.IpLB = new System.Windows.Forms.ListBox();
            this.IpIN4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IpIN3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IpIN2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IpIN1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDTP = new System.Windows.Forms.DateTimePicker();
            this.BeginDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActivateTimespanCB
            // 
            this.ActivateTimespanCB.AutoSize = true;
            this.ActivateTimespanCB.Location = new System.Drawing.Point(16, 93);
            this.ActivateTimespanCB.Name = "ActivateTimespanCB";
            this.ActivateTimespanCB.Size = new System.Drawing.Size(108, 29);
            this.ActivateTimespanCB.TabIndex = 33;
            this.ActivateTimespanCB.Text = "Zeitraum";
            this.ActivateTimespanCB.UseVisualStyleBackColor = true;
            // 
            // ActivateIpCB
            // 
            this.ActivateIpCB.AutoSize = true;
            this.ActivateIpCB.Location = new System.Drawing.Point(16, 55);
            this.ActivateIpCB.Margin = new System.Windows.Forms.Padding(6);
            this.ActivateIpCB.Name = "ActivateIpCB";
            this.ActivateIpCB.Size = new System.Drawing.Size(54, 29);
            this.ActivateIpCB.TabIndex = 32;
            this.ActivateIpCB.Text = "Ip";
            this.ActivateIpCB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "Aktive Filter:";
            // 
            // deleteIpB
            // 
            this.deleteIpB.Location = new System.Drawing.Point(332, 257);
            this.deleteIpB.Margin = new System.Windows.Forms.Padding(6);
            this.deleteIpB.Name = "deleteIpB";
            this.deleteIpB.Size = new System.Drawing.Size(124, 34);
            this.deleteIpB.TabIndex = 45;
            this.deleteIpB.Text = "Ip löschen";
            this.deleteIpB.UseVisualStyleBackColor = true;
            this.deleteIpB.Click += new System.EventHandler(this.deleteIpB_Click);
            // 
            // deleteAllB
            // 
            this.deleteAllB.Location = new System.Drawing.Point(180, 257);
            this.deleteAllB.Margin = new System.Windows.Forms.Padding(6);
            this.deleteAllB.Name = "deleteAllB";
            this.deleteAllB.Size = new System.Drawing.Size(146, 34);
            this.deleteAllB.TabIndex = 44;
            this.deleteAllB.Text = "alle Ips löschen";
            this.deleteAllB.UseVisualStyleBackColor = true;
            this.deleteAllB.Click += new System.EventHandler(this.deleteAllB_Click);
            // 
            // IpB
            // 
            this.IpB.Location = new System.Drawing.Point(409, 51);
            this.IpB.Name = "IpB";
            this.IpB.Size = new System.Drawing.Size(47, 34);
            this.IpB.TabIndex = 43;
            this.IpB.Text = "+";
            this.IpB.UseVisualStyleBackColor = true;
            this.IpB.Click += new System.EventHandler(this.IpB_Click);
            // 
            // IpLB
            // 
            this.IpLB.FormattingEnabled = true;
            this.IpLB.ItemHeight = 25;
            this.IpLB.Location = new System.Drawing.Point(180, 91);
            this.IpLB.Margin = new System.Windows.Forms.Padding(6);
            this.IpLB.Name = "IpLB";
            this.IpLB.Size = new System.Drawing.Size(276, 154);
            this.IpLB.TabIndex = 42;
            // 
            // IpIN4
            // 
            this.IpIN4.Location = new System.Drawing.Point(348, 53);
            this.IpIN4.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN4.Name = "IpIN4";
            this.IpIN4.Size = new System.Drawing.Size(38, 31);
            this.IpIN4.TabIndex = 41;
            this.IpIN4.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = ".";
            // 
            // IpIN3
            // 
            this.IpIN3.Location = new System.Drawing.Point(288, 53);
            this.IpIN3.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN3.Name = "IpIN3";
            this.IpIN3.Size = new System.Drawing.Size(38, 31);
            this.IpIN3.TabIndex = 39;
            this.IpIN3.Text = "243";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = ".";
            // 
            // IpIN2
            // 
            this.IpIN2.Location = new System.Drawing.Point(234, 53);
            this.IpIN2.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN2.Name = "IpIN2";
            this.IpIN2.Size = new System.Drawing.Size(38, 31);
            this.IpIN2.TabIndex = 37;
            this.IpIN2.Text = "32";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = ".";
            // 
            // IpIN1
            // 
            this.IpIN1.Location = new System.Drawing.Point(180, 53);
            this.IpIN1.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN1.Name = "IpIN1";
            this.IpIN1.Size = new System.Drawing.Size(38, 31);
            this.IpIN1.TabIndex = 35;
            this.IpIN1.Text = "193";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(186, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ip-Filter:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "bis";
            // 
            // EndDTP
            // 
            this.EndDTP.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.EndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDTP.Location = new System.Drawing.Point(510, 128);
            this.EndDTP.Margin = new System.Windows.Forms.Padding(6);
            this.EndDTP.Name = "EndDTP";
            this.EndDTP.Size = new System.Drawing.Size(221, 31);
            this.EndDTP.TabIndex = 48;
            // 
            // BeginDTP
            // 
            this.BeginDTP.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.BeginDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDTP.Location = new System.Drawing.Point(510, 51);
            this.BeginDTP.Name = "BeginDTP";
            this.BeginDTP.Size = new System.Drawing.Size(221, 31);
            this.BeginDTP.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(516, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Zeitraum-Filter";
            // 
            // AccessesPerIpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EndDTP);
            this.Controls.Add(this.BeginDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteIpB);
            this.Controls.Add(this.deleteAllB);
            this.Controls.Add(this.IpB);
            this.Controls.Add(this.IpLB);
            this.Controls.Add(this.IpIN4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IpIN3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IpIN2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IpIN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActivateTimespanCB);
            this.Controls.Add(this.ActivateIpCB);
            this.Controls.Add(this.label6);
            this.Name = "AccessesPerIpControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1220, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ActivateTimespanCB;
        private CheckBox ActivateIpCB;
        private Label label6;
        private Button deleteIpB;
        private Button deleteAllB;
        private Button IpB;
        private ListBox IpLB;
        private TextBox IpIN4;
        private Label label10;
        private TextBox IpIN3;
        private Label label9;
        private TextBox IpIN2;
        private Label label8;
        private TextBox IpIN1;
        private Label label3;
        private Label label7;
        private DateTimePicker EndDTP;
        private DateTimePicker BeginDTP;
        private Label label4;
    }
}
