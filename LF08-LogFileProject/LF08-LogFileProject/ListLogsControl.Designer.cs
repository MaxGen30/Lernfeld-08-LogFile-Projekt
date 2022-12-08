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
            this.ActivateIpRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ActivateTimespanRB = new System.Windows.Forms.RadioButton();
            this.ActivateAttributeRB = new System.Windows.Forms.RadioButton();
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
            this.AdressRB = new System.Windows.Forms.RadioButton();
            this.CodeRB = new System.Windows.Forms.RadioButton();
            this.ResponseTimeRB = new System.Windows.Forms.RadioButton();
            this.IpRB = new System.Windows.Forms.RadioButton();
            this.DateRB = new System.Windows.Forms.RadioButton();
            this.MethodRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 16);
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
            this.label5.Location = new System.Drawing.Point(885, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Attribut-Filter:";
            // 
            // ActivateIpRB
            // 
            this.ActivateIpRB.AutoSize = true;
            this.ActivateIpRB.Location = new System.Drawing.Point(20, 44);
            this.ActivateIpRB.Name = "ActivateIpRB";
            this.ActivateIpRB.Size = new System.Drawing.Size(53, 29);
            this.ActivateIpRB.TabIndex = 5;
            this.ActivateIpRB.TabStop = true;
            this.ActivateIpRB.Text = "Ip";
            this.ActivateIpRB.UseVisualStyleBackColor = true;
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
            // ActivateTimespanRB
            // 
            this.ActivateTimespanRB.AutoSize = true;
            this.ActivateTimespanRB.Location = new System.Drawing.Point(20, 79);
            this.ActivateTimespanRB.Name = "ActivateTimespanRB";
            this.ActivateTimespanRB.Size = new System.Drawing.Size(107, 29);
            this.ActivateTimespanRB.TabIndex = 7;
            this.ActivateTimespanRB.TabStop = true;
            this.ActivateTimespanRB.Text = "Zeitraum";
            this.ActivateTimespanRB.UseVisualStyleBackColor = true;
            // 
            // ActivateAttributeRB
            // 
            this.ActivateAttributeRB.AutoSize = true;
            this.ActivateAttributeRB.Location = new System.Drawing.Point(20, 113);
            this.ActivateAttributeRB.Name = "ActivateAttributeRB";
            this.ActivateAttributeRB.Size = new System.Drawing.Size(98, 29);
            this.ActivateAttributeRB.TabIndex = 8;
            this.ActivateAttributeRB.TabStop = true;
            this.ActivateAttributeRB.Text = "Attribut";
            this.ActivateAttributeRB.UseVisualStyleBackColor = true;
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
            this.IpIN1.Location = new System.Drawing.Point(237, 46);
            this.IpIN1.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN1.Name = "IpIN1";
            this.IpIN1.Size = new System.Drawing.Size(38, 31);
            this.IpIN1.TabIndex = 14;
            this.IpIN1.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = ".";
            // 
            // IpIN2
            // 
            this.IpIN2.Location = new System.Drawing.Point(291, 46);
            this.IpIN2.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN2.Name = "IpIN2";
            this.IpIN2.Size = new System.Drawing.Size(38, 31);
            this.IpIN2.TabIndex = 16;
            this.IpIN2.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = ".";
            // 
            // IpIN3
            // 
            this.IpIN3.Location = new System.Drawing.Point(345, 46);
            this.IpIN3.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN3.Name = "IpIN3";
            this.IpIN3.Size = new System.Drawing.Size(38, 31);
            this.IpIN3.TabIndex = 18;
            this.IpIN3.Text = "255";
            // 
            // IpIN4
            // 
            this.IpIN4.Location = new System.Drawing.Point(399, 46);
            this.IpIN4.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN4.Name = "IpIN4";
            this.IpIN4.Size = new System.Drawing.Size(38, 31);
            this.IpIN4.TabIndex = 20;
            this.IpIN4.Text = "255";
            // 
            // AdressRB
            // 
            this.AdressRB.AutoSize = true;
            this.AdressRB.Location = new System.Drawing.Point(1032, 54);
            this.AdressRB.Name = "AdressRB";
            this.AdressRB.Size = new System.Drawing.Size(100, 29);
            this.AdressRB.TabIndex = 21;
            this.AdressRB.TabStop = true;
            this.AdressRB.Text = "Adresse";
            this.AdressRB.UseVisualStyleBackColor = true;
            // 
            // CodeRB
            // 
            this.CodeRB.AutoSize = true;
            this.CodeRB.Location = new System.Drawing.Point(1032, 89);
            this.CodeRB.Name = "CodeRB";
            this.CodeRB.Size = new System.Drawing.Size(79, 29);
            this.CodeRB.TabIndex = 22;
            this.CodeRB.TabStop = true;
            this.CodeRB.Text = "Code";
            this.CodeRB.UseVisualStyleBackColor = true;
            // 
            // ResponseTimeRB
            // 
            this.ResponseTimeRB.AutoSize = true;
            this.ResponseTimeRB.Location = new System.Drawing.Point(1032, 124);
            this.ResponseTimeRB.Name = "ResponseTimeRB";
            this.ResponseTimeRB.Size = new System.Drawing.Size(128, 29);
            this.ResponseTimeRB.TabIndex = 23;
            this.ResponseTimeRB.TabStop = true;
            this.ResponseTimeRB.Text = "Antwortzeit";
            this.ResponseTimeRB.UseVisualStyleBackColor = true;
            // 
            // IpRB
            // 
            this.IpRB.AutoSize = true;
            this.IpRB.Location = new System.Drawing.Point(885, 54);
            this.IpRB.Name = "IpRB";
            this.IpRB.Size = new System.Drawing.Size(53, 29);
            this.IpRB.TabIndex = 21;
            this.IpRB.TabStop = true;
            this.IpRB.Text = "Ip";
            this.IpRB.UseVisualStyleBackColor = true;
            // 
            // DateRB
            // 
            this.DateRB.AutoSize = true;
            this.DateRB.Location = new System.Drawing.Point(885, 89);
            this.DateRB.Name = "DateRB";
            this.DateRB.Size = new System.Drawing.Size(91, 29);
            this.DateRB.TabIndex = 22;
            this.DateRB.TabStop = true;
            this.DateRB.Text = "Datum";
            this.DateRB.UseVisualStyleBackColor = true;
            // 
            // MethodRB
            // 
            this.MethodRB.AutoSize = true;
            this.MethodRB.Location = new System.Drawing.Point(885, 124);
            this.MethodRB.Name = "MethodRB";
            this.MethodRB.Size = new System.Drawing.Size(109, 29);
            this.MethodRB.TabIndex = 23;
            this.MethodRB.TabStop = true;
            this.MethodRB.Text = "Methode";
            this.MethodRB.UseVisualStyleBackColor = true;
            // 
            // ListLogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MethodRB);
            this.Controls.Add(this.ResponseTimeRB);
            this.Controls.Add(this.DateRB);
            this.Controls.Add(this.CodeRB);
            this.Controls.Add(this.IpRB);
            this.Controls.Add(this.AdressRB);
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
            this.Controls.Add(this.ActivateAttributeRB);
            this.Controls.Add(this.ActivateTimespanRB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ActivateIpRB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListLogsControl";
            this.Size = new System.Drawing.Size(1260, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton ActivateIpRB;
        private Label label6;
        private RadioButton ActivateTimespanRB;
        private RadioButton ActivateAttributeRB;
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
        private RadioButton AdressRB;
        private RadioButton CodeRB;
        private RadioButton ResponseTimeRB;
        private RadioButton IpRB;
        private RadioButton DateRB;
        private RadioButton MethodRB;
    }
}
