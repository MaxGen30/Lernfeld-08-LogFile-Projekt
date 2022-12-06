using LF08_LogFileProject.Models;

namespace LF08_LogFileProject;

public partial class Form1 : Form
{
    private Database Database;
    public Form1()
    {
        InitializeComponent();
        Database = new Database();
    }

    private async void ImportLogFiles(object sender, EventArgs e)
    {
        var error = false;
        var filePath = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "log files (*.log)|*.log|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }

            if (error == false)
            {
                await Database.Insert(filePath);
            }
        }
    }

    private async void StartAnalysis(object sender, EventArgs e)
    {
        var filter = new Filter();

        var resultOne = await Database.GetLogFilesAsync(filter);

        var resultTwo = await Database.GetAmountOfAccessesPerIpAsync(filter);

        var resultThree = await Database.GetAmountOfEntriesPerErrorCode(filter);

        var resultFour = await Database.GetAmountOfEntriesPerRequestMethods(filter);

        int a = 1;
    }
}