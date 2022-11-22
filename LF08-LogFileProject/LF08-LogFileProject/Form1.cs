namespace LF08_LogFileProject;

public partial class Form1 : Form
{
    private Database database;
    public Form1()
    {
        InitializeComponent();
        database = new Database();
    }
}