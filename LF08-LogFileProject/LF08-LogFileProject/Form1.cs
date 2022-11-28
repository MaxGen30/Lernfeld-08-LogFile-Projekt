namespace LF08_LogFileProject;

public partial class Form1 : Form
{
    private Database Database;
    public Form1()
    {
        InitializeComponent();
        Database = new Database();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        await Database.Insert();
    }
}