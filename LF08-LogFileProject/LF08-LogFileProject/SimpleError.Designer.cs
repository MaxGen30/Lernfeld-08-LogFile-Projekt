namespace LF08_LogFileProject
{
    partial class SimpleError
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderL
            // 
            this.HeaderL.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderL.Location = new System.Drawing.Point(3, 49);
            this.HeaderL.Name = "HeaderL";
            this.HeaderL.Size = new System.Drawing.Size(594, 36);
            this.HeaderL.TabIndex = 0;
            this.HeaderL.Text = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
            this.HeaderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesL
            // 
            this.DesL.Location = new System.Drawing.Point(3, 103);
            this.DesL.Name = "DesL";
            this.DesL.Size = new System.Drawing.Size(594, 128);
            this.DesL.TabIndex = 1;
            this.DesL.Text = "ccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc";
            this.DesL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimpleError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DesL);
            this.Controls.Add(this.HeaderL);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SimpleError";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private Label HeaderL;
        private Label DesL;
        private Button button1;
    }
}
