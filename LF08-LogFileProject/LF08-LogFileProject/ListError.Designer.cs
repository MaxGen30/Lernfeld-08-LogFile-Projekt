namespace LF08_LogFileProject
{
    partial class ListError
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
            this.HeaderL = new System.Windows.Forms.Label();
            this.DesL = new System.Windows.Forms.Label();
            this.ErrorDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.errorL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderL
            // 
            this.HeaderL.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderL.Location = new System.Drawing.Point(3, 10);
            this.HeaderL.Name = "HeaderL";
            this.HeaderL.Size = new System.Drawing.Size(594, 36);
            this.HeaderL.TabIndex = 1;
            this.HeaderL.Text = "Soll die Log-Datei importiert werden?";
            this.HeaderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesL
            // 
            this.DesL.Location = new System.Drawing.Point(3, 46);
            this.DesL.Name = "DesL";
            this.DesL.Size = new System.Drawing.Size(594, 25);
            this.DesL.TabIndex = 2;
            this.DesL.Text = "Dies kann einige Zeit dauern";
            this.DesL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorDGV
            // 
            this.ErrorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorDGV.Location = new System.Drawing.Point(3, 191);
            this.ErrorDGV.Name = "ErrorDGV";
            this.ErrorDGV.RowHeadersWidth = 62;
            this.ErrorDGV.RowTemplate.Height = 33;
            this.ErrorDGV.Size = new System.Drawing.Size(594, 516);
            this.ErrorDGV.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 713);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "fertig";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorL
            // 
            this.errorL.AutoSize = true;
            this.errorL.Location = new System.Drawing.Point(3, 718);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(165, 25);
            this.errorL.TabIndex = 5;
            this.errorL.Text = "Insgesamt: 0 Fehler";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sollte die Datei zu groß sein, so könnte es aussehen, als wäre das Programm abges" +
    "türzt. Bei einer Datei mit 10.000 Einträgen, kann es 2-3 Minuten dauern.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "alles importieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorDGV);
            this.Controls.Add(this.DesL);
            this.Controls.Add(this.HeaderL);
            this.Name = "ListError";
            this.Size = new System.Drawing.Size(600, 750);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderL;
        private Label DesL;
        private DataGridView ErrorDGV;
        private Button button1;
        private Label errorL;
        private Label label1;
        private Button button2;
    }
}
