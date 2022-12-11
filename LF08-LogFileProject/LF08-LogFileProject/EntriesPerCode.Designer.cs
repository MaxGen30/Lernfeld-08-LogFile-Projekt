namespace LF08_LogFileProject
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
            this.codeB = new System.Windows.Forms.NumericUpDown();
            this.EndTP = new System.Windows.Forms.DateTimePicker();
            this.BeginTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDP = new System.Windows.Forms.DateTimePicker();
            this.BeginDP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeB)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivateCodeCB
            // 
            this.ActivateCodeCB.AutoSize = true;
            this.ActivateCodeCB.Location = new System.Drawing.Point(0, 33);
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
            this.label1.Location = new System.Drawing.Point(182, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 93;
            this.label1.Text = "Code-Filter:";
            // 
            // deleteIpB
            // 
            this.deleteIpB.Location = new System.Drawing.Point(661, 236);
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
            this.deleteAllB.Location = new System.Drawing.Point(509, 236);
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
            this.IpB.Location = new System.Drawing.Point(738, 32);
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
            this.IpLB.Location = new System.Drawing.Point(509, 73);
            this.IpLB.Margin = new System.Windows.Forms.Padding(6);
            this.IpLB.Name = "IpLB";
            this.IpLB.Size = new System.Drawing.Size(276, 154);
            this.IpLB.TabIndex = 85;
            // 
            // IpIN4
            // 
            this.IpIN4.Location = new System.Drawing.Point(671, 34);
            this.IpIN4.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN4.Name = "IpIN4";
            this.IpIN4.Size = new System.Drawing.Size(38, 31);
            this.IpIN4.TabIndex = 84;
            this.IpIN4.Text = "255";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(655, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 83;
            this.label10.Text = ".";
            // 
            // IpIN3
            // 
            this.IpIN3.Location = new System.Drawing.Point(617, 34);
            this.IpIN3.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN3.Name = "IpIN3";
            this.IpIN3.Size = new System.Drawing.Size(38, 31);
            this.IpIN3.TabIndex = 82;
            this.IpIN3.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = ".";
            // 
            // IpIN2
            // 
            this.IpIN2.Location = new System.Drawing.Point(563, 34);
            this.IpIN2.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN2.Name = "IpIN2";
            this.IpIN2.Size = new System.Drawing.Size(38, 31);
            this.IpIN2.TabIndex = 80;
            this.IpIN2.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = ".";
            // 
            // IpIN1
            // 
            this.IpIN1.Location = new System.Drawing.Point(509, 33);
            this.IpIN1.Margin = new System.Windows.Forms.Padding(0);
            this.IpIN1.Name = "IpIN1";
            this.IpIN1.Size = new System.Drawing.Size(38, 31);
            this.IpIN1.TabIndex = 78;
            this.IpIN1.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 77;
            this.label3.Text = "Ip-Filter:";
            // 
            // ActivateTimespanCB
            // 
            this.ActivateTimespanCB.AutoSize = true;
            this.ActivateTimespanCB.Location = new System.Drawing.Point(0, 103);
            this.ActivateTimespanCB.Name = "ActivateTimespanCB";
            this.ActivateTimespanCB.Size = new System.Drawing.Size(108, 29);
            this.ActivateTimespanCB.TabIndex = 76;
            this.ActivateTimespanCB.Text = "Zeitraum";
            this.ActivateTimespanCB.UseVisualStyleBackColor = true;
            // 
            // ActivateIpCB
            // 
            this.ActivateIpCB.AutoSize = true;
            this.ActivateIpCB.Location = new System.Drawing.Point(0, 68);
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
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 30);
            this.label6.TabIndex = 74;
            this.label6.Text = "Aktive Filter:";
            // 
            // CodeLB
            // 
            this.CodeLB.FormattingEnabled = true;
            this.CodeLB.ItemHeight = 25;
            this.CodeLB.Location = new System.Drawing.Point(182, 73);
            this.CodeLB.Margin = new System.Windows.Forms.Padding(6);
            this.CodeLB.Name = "CodeLB";
            this.CodeLB.Size = new System.Drawing.Size(276, 154);
            this.CodeLB.TabIndex = 98;
            // 
            // deleteAllCodesB
            // 
            this.deleteAllCodesB.Location = new System.Drawing.Point(182, 236);
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
            this.deleteCodeB.Location = new System.Drawing.Point(313, 236);
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
            this.addCodeB.Location = new System.Drawing.Point(411, 30);
            this.addCodeB.Name = "addCodeB";
            this.addCodeB.Size = new System.Drawing.Size(47, 34);
            this.addCodeB.TabIndex = 102;
            this.addCodeB.Text = "+";
            this.addCodeB.UseVisualStyleBackColor = true;
            this.addCodeB.Click += new System.EventHandler(this.addCodeB_Click);
            // 
            // codeB
            // 
            this.codeB.Location = new System.Drawing.Point(182, 33);
            this.codeB.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.codeB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.codeB.Name = "codeB";
            this.codeB.Size = new System.Drawing.Size(85, 31);
            this.codeB.TabIndex = 103;
            this.codeB.Value = new decimal(new int[] {
            404,
            0,
            0,
            0});
            // 
            // EndTP
            // 
            this.EndTP.CustomFormat = "HH:mm:ss";
            this.EndTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTP.Location = new System.Drawing.Point(986, 93);
            this.EndTP.Name = "EndTP";
            this.EndTP.Size = new System.Drawing.Size(157, 31);
            this.EndTP.TabIndex = 109;
            // 
            // BeginTP
            // 
            this.BeginTP.CustomFormat = "HH:mm:ss";
            this.BeginTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginTP.Location = new System.Drawing.Point(984, 31);
            this.BeginTP.Name = "BeginTP";
            this.BeginTP.Size = new System.Drawing.Size(157, 31);
            this.BeginTP.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(823, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 107;
            this.label7.Text = "bis";
            // 
            // EndDP
            // 
            this.EndDP.CustomFormat = "dd.MM.yyyy";
            this.EndDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDP.Location = new System.Drawing.Point(823, 93);
            this.EndDP.Name = "EndDP";
            this.EndDP.Size = new System.Drawing.Size(157, 31);
            this.EndDP.TabIndex = 106;
            // 
            // BeginDP
            // 
            this.BeginDP.CustomFormat = "dd.MM.yyyy";
            this.BeginDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDP.Location = new System.Drawing.Point(823, 31);
            this.BeginDP.Name = "BeginDP";
            this.BeginDP.Size = new System.Drawing.Size(157, 31);
            this.BeginDP.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(823, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 104;
            this.label4.Text = "Zeitraum-Filter";
            // 
            // EntriesPerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndTP);
            this.Controls.Add(this.BeginTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EndDP);
            this.Controls.Add(this.BeginDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codeB);
            this.Controls.Add(this.addCodeB);
            this.Controls.Add(this.deleteCodeB);
            this.Controls.Add(this.deleteAllCodesB);
            this.Controls.Add(this.CodeLB);
            this.Controls.Add(this.ActivateCodeCB);
            this.Controls.Add(this.label1);
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
            this.Size = new System.Drawing.Size(1234, 270);
            ((System.ComponentModel.ISupportInitialize)(this.codeB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ActivateCodeCB;
        private Label label1;
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
        private NumericUpDown codeB;
        private DateTimePicker EndTP;
        private DateTimePicker BeginTP;
        private Label label7;
        private DateTimePicker EndDP;
        private DateTimePicker BeginDP;
        private Label label4;
    }
}
