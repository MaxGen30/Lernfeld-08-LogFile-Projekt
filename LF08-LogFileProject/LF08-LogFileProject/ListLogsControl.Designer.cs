namespace LF08_LogFileProject
{
    partial class ListLogsControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BeginDTP = new System.Windows.Forms.DateTimePicker();
            this.EndDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.IpIN1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IpIN2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IpIN3 = new System.Windows.Forms.TextBox();
            this.IpIN4 = new System.Windows.Forms.TextBox();
            this.IpLB = new System.Windows.Forms.ListBox();
            this.IpB = new System.Windows.Forms.Button();
            this.deleteAllB = new System.Windows.Forms.Button();
            this.deleteIpB = new System.Windows.Forms.Button();
            this.ActivateIpCB = new System.Windows.Forms.CheckBox();
            this.ActivateTimespanCB = new System.Windows.Forms.CheckBox();
            this.ActivateAttributeCB = new System.Windows.Forms.CheckBox();
            this.IpCB = new System.Windows.Forms.CheckBox();
            this.DateCB = new System.Windows.Forms.CheckBox();
            this.MethodCB = new System.Windows.Forms.CheckBox();
            this.AdressCB = new System.Windows.Forms.CheckBox();
            this.CodeCB = new System.Windows.Forms.CheckBox();
            this.ResponseTimeCB = new System.Windows.Forms.CheckBox();
            this.IdCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ip-Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zeitraum-Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(884, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Attribut-Filter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Aktive Filter";
            // 
            // BeginDTP
            // 
            this.BeginDTP.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.BeginDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDTP.Location = new System.Drawing.Point(479, 44);
            this.BeginDTP.Name = "BeginDTP";
            this.BeginDTP.Size = new System.Drawing.Size(300, 31);
            this.BeginDTP.TabIndex = 10;
            // 
            // EndDTP
            // 
            this.EndDTP.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.EndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDTP.Location = new System.Drawing.Point(479, 106);
            this.EndDTP.Name = "EndDTP";
            this.EndDTP.Size = new System.Drawing.Size(300, 31);
            this.EndDTP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "bis";
            // 
            // IpIN1
            // 
            this.IpIN1.Location = new System.Drawing.Point(165, 46);
            this.IpIN1.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN1.Name = "IpIN1";
            this.IpIN1.Size = new System.Drawing.Size(38, 31);
            this.IpIN1.TabIndex = 14;
            this.IpIN1.Text = "193";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = ".";
            // 
            // IpIN2
            // 
            this.IpIN2.Location = new System.Drawing.Point(219, 46);
            this.IpIN2.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN2.Name = "IpIN2";
            this.IpIN2.Size = new System.Drawing.Size(38, 31);
            this.IpIN2.TabIndex = 16;
            this.IpIN2.Text = "32";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = ".";
            // 
            // IpIN3
            // 
            this.IpIN3.Location = new System.Drawing.Point(273, 46);
            this.IpIN3.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN3.Name = "IpIN3";
            this.IpIN3.Size = new System.Drawing.Size(38, 31);
            this.IpIN3.TabIndex = 18;
            this.IpIN3.Text = "243";
            // 
            // IpIN4
            // 
            this.IpIN4.Location = new System.Drawing.Point(327, 46);
            this.IpIN4.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN4.Name = "IpIN4";
            this.IpIN4.Size = new System.Drawing.Size(38, 31);
            this.IpIN4.TabIndex = 20;
            this.IpIN4.Text = "1";
            // 
            // IpLB
            // 
            this.IpLB.FormattingEnabled = true;
            this.IpLB.ItemHeight = 25;
            this.IpLB.Location = new System.Drawing.Point(165, 89);
            this.IpLB.Name = "IpLB";
            this.IpLB.Size = new System.Drawing.Size(276, 154);
            this.IpLB.TabIndex = 24;
            // 
            // IpB
            // 
            this.IpB.Location = new System.Drawing.Point(394, 44);
            this.IpB.Name = "IpB";
            this.IpB.Size = new System.Drawing.Size(47, 34);
            this.IpB.TabIndex = 25;
            this.IpB.Text = "+";
            this.IpB.UseVisualStyleBackColor = true;
            this.IpB.Click += new System.EventHandler(this.IpB_Click);
            // 
            // deleteAllB
            // 
            this.deleteAllB.Location = new System.Drawing.Point(165, 249);
            this.deleteAllB.Name = "deleteAllB";
            this.deleteAllB.Size = new System.Drawing.Size(146, 34);
            this.deleteAllB.TabIndex = 26;
            this.deleteAllB.Text = "alle Ips löschen";
            this.deleteAllB.UseVisualStyleBackColor = true;
            this.deleteAllB.Click += new System.EventHandler(this.deleteAllB_Click);
            // 
            // deleteIpB
            // 
            this.deleteIpB.Location = new System.Drawing.Point(317, 249);
            this.deleteIpB.Name = "deleteIpB";
            this.deleteIpB.Size = new System.Drawing.Size(124, 34);
            this.deleteIpB.TabIndex = 27;
            this.deleteIpB.Text = "Ip löschen";
            this.deleteIpB.UseVisualStyleBackColor = true;
            this.deleteIpB.Click += new System.EventHandler(this.deleteIpB_Click);
            // 
            // ActivateIpCB
            // 
            this.ActivateIpCB.AutoSize = true;
            this.ActivateIpCB.Location = new System.Drawing.Point(20, 48);
            this.ActivateIpCB.Name = "ActivateIpCB";
            this.ActivateIpCB.Size = new System.Drawing.Size(54, 29);
            this.ActivateIpCB.TabIndex = 28;
            this.ActivateIpCB.Text = "Ip";
            this.ActivateIpCB.UseVisualStyleBackColor = true;
            // 
            // ActivateTimespanCB
            // 
            this.ActivateTimespanCB.AutoSize = true;
            this.ActivateTimespanCB.Location = new System.Drawing.Point(20, 83);
            this.ActivateTimespanCB.Name = "ActivateTimespanCB";
            this.ActivateTimespanCB.Size = new System.Drawing.Size(108, 29);
            this.ActivateTimespanCB.TabIndex = 29;
            this.ActivateTimespanCB.Text = "Zeitraum";
            this.ActivateTimespanCB.UseVisualStyleBackColor = true;
            // 
            // ActivateAttributeCB
            // 
            this.ActivateAttributeCB.AutoSize = true;
            this.ActivateAttributeCB.Location = new System.Drawing.Point(20, 118);
            this.ActivateAttributeCB.Name = "ActivateAttributeCB";
            this.ActivateAttributeCB.Size = new System.Drawing.Size(99, 29);
            this.ActivateAttributeCB.TabIndex = 30;
            this.ActivateAttributeCB.Text = "Attribut";
            this.ActivateAttributeCB.UseVisualStyleBackColor = true;
            // 
            // IpCB
            // 
            this.IpCB.AutoSize = true;
            this.IpCB.Location = new System.Drawing.Point(884, 83);
            this.IpCB.Name = "IpCB";
            this.IpCB.Size = new System.Drawing.Size(54, 29);
            this.IpCB.TabIndex = 31;
            this.IpCB.Text = "Ip";
            this.IpCB.UseVisualStyleBackColor = true;
            // 
            // DateCB
            // 
            this.DateCB.AutoSize = true;
            this.DateCB.Location = new System.Drawing.Point(884, 118);
            this.DateCB.Name = "DateCB";
            this.DateCB.Size = new System.Drawing.Size(92, 29);
            this.DateCB.TabIndex = 32;
            this.DateCB.Text = "Datum";
            this.DateCB.UseVisualStyleBackColor = true;
            // 
            // MethodCB
            // 
            this.MethodCB.AutoSize = true;
            this.MethodCB.Location = new System.Drawing.Point(884, 153);
            this.MethodCB.Name = "MethodCB";
            this.MethodCB.Size = new System.Drawing.Size(110, 29);
            this.MethodCB.TabIndex = 33;
            this.MethodCB.Text = "Methode";
            this.MethodCB.UseVisualStyleBackColor = true;
            // 
            // AdressCB
            // 
            this.AdressCB.AutoSize = true;
            this.AdressCB.Location = new System.Drawing.Point(1027, 48);
            this.AdressCB.Name = "AdressCB";
            this.AdressCB.Size = new System.Drawing.Size(112, 29);
            this.AdressCB.TabIndex = 34;
            this.AdressCB.Text = "Addresse";
            this.AdressCB.UseVisualStyleBackColor = true;
            // 
            // CodeCB
            // 
            this.CodeCB.AutoSize = true;
            this.CodeCB.Location = new System.Drawing.Point(1027, 83);
            this.CodeCB.Name = "CodeCB";
            this.CodeCB.Size = new System.Drawing.Size(80, 29);
            this.CodeCB.TabIndex = 35;
            this.CodeCB.Text = "Code";
            this.CodeCB.UseVisualStyleBackColor = true;
            // 
            // ResponseTimeCB
            // 
            this.ResponseTimeCB.AutoSize = true;
            this.ResponseTimeCB.Location = new System.Drawing.Point(1027, 118);
            this.ResponseTimeCB.Name = "ResponseTimeCB";
            this.ResponseTimeCB.Size = new System.Drawing.Size(129, 29);
            this.ResponseTimeCB.TabIndex = 36;
            this.ResponseTimeCB.Text = "Antwortzeit";
            this.ResponseTimeCB.UseVisualStyleBackColor = true;
            // 
            // IdCB
            // 
            this.IdCB.AutoSize = true;
            this.IdCB.Location = new System.Drawing.Point(884, 48);
            this.IdCB.Name = "IdCB";
            this.IdCB.Size = new System.Drawing.Size(54, 29);
            this.IdCB.TabIndex = 37;
            this.IdCB.Text = "Id";
            this.IdCB.UseVisualStyleBackColor = true;
            // 
            // ListLogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdCB);
            this.Controls.Add(this.ResponseTimeCB);
            this.Controls.Add(this.CodeCB);
            this.Controls.Add(this.AdressCB);
            this.Controls.Add(this.MethodCB);
            this.Controls.Add(this.DateCB);
            this.Controls.Add(this.IpCB);
            this.Controls.Add(this.ActivateAttributeCB);
            this.Controls.Add(this.ActivateTimespanCB);
            this.Controls.Add(this.ActivateIpCB);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EndDTP);
            this.Controls.Add(this.BeginDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListLogsControl";
            this.Size = new System.Drawing.Size(1260, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker BeginDTP;
        private DateTimePicker EndDTP;
        private Label label7;
        private TextBox IpIN1;
        private Label label8;
        private TextBox IpIN2;
        private Label label9;
        private Label label10;
        private TextBox IpIN3;
        private TextBox IpIN4;
        private ListBox IpLB;
        private Button IpB;
        private Button deleteAllB;
        private Button deleteIpB;
        private CheckBox ActivateIpCB;
        private CheckBox ActivateTimespanCB;
        private CheckBox ActivateAttributeCB;
        private CheckBox IpCB;
        private CheckBox DateCB;
        private CheckBox MethodCB;
        private CheckBox AdressCB;
        private CheckBox CodeCB;
        private CheckBox ResponseTimeCB;
        private CheckBox IdCB;
    }
}
