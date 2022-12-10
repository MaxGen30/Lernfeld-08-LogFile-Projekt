namespace LF08_LogFileProject;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MethodCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listLogsControl1 = new LF08_LogFileProject.ListLogsControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SelectMethodB = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.accessesPerIpControl1 = new LF08_LogFileProject.AccessesPerIpControl();
            this.entriesPerMethod1 = new LF08_LogFileProject.EntriesPerMethod();
            this.entriesPerCode1 = new LF08_LogFileProject.EntriesPerCode();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(20, 378);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 33;
            this.DGV.Size = new System.Drawing.Size(1220, 414);
            this.DGV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1070, 798);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import Log Daten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ImportLogFiles);
            // 
            // MethodCB
            // 
            this.MethodCB.FormattingEnabled = true;
            this.MethodCB.Location = new System.Drawing.Point(43, 37);
            this.MethodCB.Name = "MethodCB";
            this.MethodCB.Size = new System.Drawing.Size(300, 33);
            this.MethodCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Analyse Methode:";
            // 
            // listLogsControl1
            // 
            this.listLogsControl1.Location = new System.Drawing.Point(10, 75);
            this.listLogsControl1.Margin = new System.Windows.Forms.Padding(0);
            this.listLogsControl1.Name = "listLogsControl1";
            this.listLogsControl1.Size = new System.Drawing.Size(1230, 300);
            this.listLogsControl1.TabIndex = 4;
            this.listLogsControl1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listet alle Log-Einträge innerhalb der Datenbank auf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beschreibung";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1076, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Starte Analyse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StartAnalysis);
            // 
            // SelectMethodB
            // 
            this.SelectMethodB.Location = new System.Drawing.Point(349, 37);
            this.SelectMethodB.Name = "SelectMethodB";
            this.SelectMethodB.Size = new System.Drawing.Size(112, 34);
            this.SelectMethodB.TabIndex = 10;
            this.SelectMethodB.Text = "Auswählen";
            this.SelectMethodB.UseVisualStyleBackColor = true;
            this.SelectMethodB.Click += new System.EventHandler(this.SelectMethodB_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // accessesPerIpControl1
            // 
            this.accessesPerIpControl1.Location = new System.Drawing.Point(12, 75);
            this.accessesPerIpControl1.Name = "accessesPerIpControl1";
            this.accessesPerIpControl1.Padding = new System.Windows.Forms.Padding(6);
            this.accessesPerIpControl1.Size = new System.Drawing.Size(1220, 300);
            this.accessesPerIpControl1.TabIndex = 11;
            this.accessesPerIpControl1.Visible = false;
            // 
            // entriesPerMethod1
            // 
            this.entriesPerMethod1.Location = new System.Drawing.Point(20, 77);
            this.entriesPerMethod1.Name = "entriesPerMethod1";
            this.entriesPerMethod1.Padding = new System.Windows.Forms.Padding(10);
            this.entriesPerMethod1.Size = new System.Drawing.Size(1220, 300);
            this.entriesPerMethod1.TabIndex = 12;
            this.entriesPerMethod1.Visible = false;
            // 
            // entriesPerCode1
            // 
            this.entriesPerCode1.Location = new System.Drawing.Point(20, 77);
            this.entriesPerCode1.Name = "entriesPerCode1";
            this.entriesPerCode1.Padding = new System.Windows.Forms.Padding(10);
            this.entriesPerCode1.Size = new System.Drawing.Size(1220, 300);
            this.entriesPerCode1.TabIndex = 13;
            this.entriesPerCode1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 844);
            this.Controls.Add(this.entriesPerCode1);
            this.Controls.Add(this.entriesPerMethod1);
            this.Controls.Add(this.accessesPerIpControl1);
            this.Controls.Add(this.SelectMethodB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listLogsControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MethodCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Log-File-Analyser von Lina, Lisa und Max";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DataGridView DGV;
    private Button button1;
    private ComboBox MethodCB;
    private Label label1;
    private ListLogsControl listLogsControl1;
    private Label label2;
    private Label label3;
    private Button button2;
    private Button SelectMethodB;
    private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    private AccessesPerIpControl accessesPerIpControl1;
    private EntriesPerMethod entriesPerMethod1;
    private EntriesPerCode entriesPerCode1;
}