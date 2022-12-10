﻿namespace LF08_LogFileProject
{
    partial class EntriesPerCode
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
            this.ActivateCodeCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDTP = new System.Windows.Forms.DateTimePicker();
            this.BeginDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
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
            this.ActivateTimespanCB = new System.Windows.Forms.CheckBox();
            this.ActivateIpCB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CodeLB = new System.Windows.Forms.ListBox();
            this.deleteAllCodesB = new System.Windows.Forms.Button();
            this.deleteCodeB = new System.Windows.Forms.Button();
            this.addCodeB = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivateCodeCB
            // 
            this.ActivateCodeCB.AutoSize = true;
            this.ActivateCodeCB.Location = new System.Drawing.Point(16, 58);
            this.ActivateCodeCB.Margin = new System.Windows.Forms.Padding(6);
            this.ActivateCodeCB.Name = "ActivateCodeCB";
            this.ActivateCodeCB.Size = new System.Drawing.Size(80, 29);
            this.ActivateCodeCB.TabIndex = 97;
            this.ActivateCodeCB.Text = "Code";
            this.ActivateCodeCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 93;
            this.label1.Text = "Code-Filter:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(818, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "bis";
            // 
            // EndDTP
            // 
            this.EndDTP.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.EndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDTP.Location = new System.Drawing.Point(818, 132);
            this.EndDTP.Margin = new System.Windows.Forms.Padding(6);
            this.EndDTP.Name = "EndDTP";
            this.EndDTP.Size = new System.Drawing.Size(221, 31);
            this.EndDTP.TabIndex = 91;
            // 
            // BeginDTP
            // 
            this.BeginDTP.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.BeginDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDTP.Location = new System.Drawing.Point(818, 52);
            this.BeginDTP.Margin = new System.Windows.Forms.Padding(6);
            this.BeginDTP.Name = "BeginDTP";
            this.BeginDTP.Size = new System.Drawing.Size(221, 31);
            this.BeginDTP.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(818, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 89;
            this.label4.Text = "Zeitraum-Filter";
            // 
            // deleteIpB
            // 
            this.deleteIpB.Location = new System.Drawing.Point(663, 253);
            this.deleteIpB.Margin = new System.Windows.Forms.Padding(6);
            this.deleteIpB.Name = "deleteIpB";
            this.deleteIpB.Size = new System.Drawing.Size(124, 34);
            this.deleteIpB.TabIndex = 88;
            this.deleteIpB.Text = "Ip löschen";
            this.deleteIpB.UseVisualStyleBackColor = true;
            this.deleteIpB.Click += new System.EventHandler(this.deleteIpB_Click);
            // 
            // deleteAllB
            // 
            this.deleteAllB.Location = new System.Drawing.Point(511, 253);
            this.deleteAllB.Margin = new System.Windows.Forms.Padding(6);
            this.deleteAllB.Name = "deleteAllB";
            this.deleteAllB.Size = new System.Drawing.Size(146, 34);
            this.deleteAllB.TabIndex = 87;
            this.deleteAllB.Text = "alle Ips löschen";
            this.deleteAllB.UseVisualStyleBackColor = true;
            this.deleteAllB.Click += new System.EventHandler(this.deleteAllB_Click);
            // 
            // IpB
            // 
            this.IpB.Location = new System.Drawing.Point(740, 48);
            this.IpB.Name = "IpB";
            this.IpB.Size = new System.Drawing.Size(47, 34);
            this.IpB.TabIndex = 86;
            this.IpB.Text = "+";
            this.IpB.UseVisualStyleBackColor = true;
            this.IpB.Click += new System.EventHandler(this.IpB_Click);
            // 
            // IpLB
            // 
            this.IpLB.FormattingEnabled = true;
            this.IpLB.ItemHeight = 25;
            this.IpLB.Location = new System.Drawing.Point(511, 87);
            this.IpLB.Margin = new System.Windows.Forms.Padding(6);
            this.IpLB.Name = "IpLB";
            this.IpLB.Size = new System.Drawing.Size(276, 154);
            this.IpLB.TabIndex = 85;
            // 
            // IpIN4
            // 
            this.IpIN4.Location = new System.Drawing.Point(673, 51);
            this.IpIN4.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN4.Name = "IpIN4";
            this.IpIN4.Size = new System.Drawing.Size(38, 31);
            this.IpIN4.TabIndex = 84;
            this.IpIN4.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 83;
            this.label10.Text = ".";
            // 
            // IpIN3
            // 
            this.IpIN3.Location = new System.Drawing.Point(619, 50);
            this.IpIN3.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN3.Name = "IpIN3";
            this.IpIN3.Size = new System.Drawing.Size(38, 31);
            this.IpIN3.TabIndex = 82;
            this.IpIN3.Text = "243";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = ".";
            // 
            // IpIN2
            // 
            this.IpIN2.Location = new System.Drawing.Point(565, 50);
            this.IpIN2.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN2.Name = "IpIN2";
            this.IpIN2.Size = new System.Drawing.Size(38, 31);
            this.IpIN2.TabIndex = 80;
            this.IpIN2.Text = "32";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = ".";
            // 
            // IpIN1
            // 
            this.IpIN1.Location = new System.Drawing.Point(511, 50);
            this.IpIN1.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN1.Name = "IpIN1";
            this.IpIN1.Size = new System.Drawing.Size(38, 31);
            this.IpIN1.TabIndex = 78;
            this.IpIN1.Text = "193";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(511, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 77;
            this.label3.Text = "Ip-Filter:";
            // 
            // ActivateTimespanCB
            // 
            this.ActivateTimespanCB.AutoSize = true;
            this.ActivateTimespanCB.Location = new System.Drawing.Point(16, 140);
            this.ActivateTimespanCB.Margin = new System.Windows.Forms.Padding(6);
            this.ActivateTimespanCB.Name = "ActivateTimespanCB";
            this.ActivateTimespanCB.Size = new System.Drawing.Size(108, 29);
            this.ActivateTimespanCB.TabIndex = 76;
            this.ActivateTimespanCB.Text = "Zeitraum";
            this.ActivateTimespanCB.UseVisualStyleBackColor = true;
            // 
            // ActivateIpCB
            // 
            this.ActivateIpCB.AutoSize = true;
            this.ActivateIpCB.Location = new System.Drawing.Point(16, 99);
            this.ActivateIpCB.Margin = new System.Windows.Forms.Padding(6);
            this.ActivateIpCB.Name = "ActivateIpCB";
            this.ActivateIpCB.Size = new System.Drawing.Size(54, 29);
            this.ActivateIpCB.TabIndex = 75;
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
            this.label6.TabIndex = 74;
            this.label6.Text = "Aktive Filter:";
            // 
            // CodeLB
            // 
            this.CodeLB.FormattingEnabled = true;
            this.CodeLB.ItemHeight = 25;
            this.CodeLB.Location = new System.Drawing.Point(201, 87);
            this.CodeLB.Margin = new System.Windows.Forms.Padding(6);
            this.CodeLB.Name = "CodeLB";
            this.CodeLB.Size = new System.Drawing.Size(276, 154);
            this.CodeLB.TabIndex = 98;
            // 
            // deleteAllCodesB
            // 
            this.deleteAllCodesB.Location = new System.Drawing.Point(201, 253);
            this.deleteAllCodesB.Margin = new System.Windows.Forms.Padding(6);
            this.deleteAllCodesB.Name = "deleteAllCodesB";
            this.deleteAllCodesB.Size = new System.Drawing.Size(119, 34);
            this.deleteAllCodesB.TabIndex = 99;
            this.deleteAllCodesB.Text = "alle löschen";
            this.deleteAllCodesB.UseVisualStyleBackColor = true;
            this.deleteAllCodesB.Click += new System.EventHandler(this.deleteAllCodesB_Click);
            // 
            // deleteCodeB
            // 
            this.deleteCodeB.Location = new System.Drawing.Point(332, 253);
            this.deleteCodeB.Margin = new System.Windows.Forms.Padding(6);
            this.deleteCodeB.Name = "deleteCodeB";
            this.deleteCodeB.Size = new System.Drawing.Size(145, 34);
            this.deleteCodeB.TabIndex = 100;
            this.deleteCodeB.Text = "Code löschen";
            this.deleteCodeB.UseVisualStyleBackColor = true;
            this.deleteCodeB.Click += new System.EventHandler(this.deleteCodeB_Click);
            // 
            // addCodeB
            // 
            this.addCodeB.Location = new System.Drawing.Point(430, 48);
            this.addCodeB.Name = "addCodeB";
            this.addCodeB.Size = new System.Drawing.Size(47, 34);
            this.addCodeB.TabIndex = 102;
            this.addCodeB.Text = "+";
            this.addCodeB.UseVisualStyleBackColor = true;
            this.addCodeB.Click += new System.EventHandler(this.addCodeB_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(201, 51);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 31);
            this.numericUpDown1.TabIndex = 103;
            this.numericUpDown1.Value = new decimal(new int[] {
            404,
            0,
            0,
            0});
            // 
            // EntriesPerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.addCodeB);
            this.Controls.Add(this.deleteCodeB);
            this.Controls.Add(this.deleteAllCodesB);
            this.Controls.Add(this.CodeLB);
            this.Controls.Add(this.ActivateCodeCB);
            this.Controls.Add(this.label1);
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
            this.Name = "EntriesPerCode";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1220, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ActivateCodeCB;
        private Label label1;
        private Label label7;
        private DateTimePicker EndDTP;
        private DateTimePicker BeginDTP;
        private Label label4;
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
        private CheckBox ActivateTimespanCB;
        private CheckBox ActivateIpCB;
        private Label label6;
        private ListBox CodeLB;
        private Button deleteAllCodesB;
        private Button deleteCodeB;
        private Button addCodeB;
        private NumericUpDown numericUpDown1;
    }
}
