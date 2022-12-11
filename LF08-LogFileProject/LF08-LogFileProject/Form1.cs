using LF08_LogFileProject.Models;
using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject;

public partial class Form1 : Form
{
    private Database Database;

    private const string MethodOne = "Logs anzeigen";
    private const string MethodOneDescription = "Listet alle Log-Einträge innerhalb der Datenbank auf";
    
    private const string MethodTwo = "Zugriffe pro Ip anzeigen";
    private const string MethodTwoDescription = "Listet die Menge an Zugriffen pro Ip-Adresse auf";

    private const string MethodThree = "Einträge pro Methode anzeigen";
    private const string MethodThreeDescription = "Listet die Menge an Einträgen pro Http-Methode auf";

    private const string MethodFour = "Einträge pro Code anzeigen";
    private const string MethodFourDescription = "Listet die Menge an Einträgen pro Http-Statuscode auf";


    private int _selectedMethod = 0;

    public Form1()
    {
        InitializeComponent();
        Database = new Database();

        MethodCB.Items.Add(MethodOne);
        MethodCB.Items.Add(MethodTwo);
        MethodCB.Items.Add(MethodThree);
        MethodCB.Items.Add(MethodFour);

        MethodCB.Text = MethodOne;
        discriptionLabel.Text = MethodOneDescription;
        listLogsControl1.Visible = true;
        
        listLogsControl1.GiveException(simpleError1);
        entriesPerMethod1.GiveException(simpleError1);
        entriesPerCode1.GiveException(simpleError1);
        accessesPerIpControl1.GiveException(simpleError1);
    }

    private void MethodCB_SelectedIndexChanged(object sender, EventArgs e)
    {
        _selectedMethod = MethodCB.SelectedIndex;

        listLogsControl1.Visible = false;
        accessesPerIpControl1.Visible = false;
        entriesPerCode1.Visible = false;
        entriesPerMethod1.Visible = false;

        switch (_selectedMethod)
        {
            case 0:
                discriptionLabel.Text = MethodOneDescription;
                listLogsControl1.Visible = true;
                break;
            case 1:
                discriptionLabel.Text = MethodTwoDescription;
                accessesPerIpControl1.Visible = true;
                break;
            case 2:
                discriptionLabel.Text = MethodThreeDescription;
                entriesPerMethod1.Visible = true;
                break;
            case 3:
                discriptionLabel.Text = MethodFourDescription;
                entriesPerCode1.Visible = true;
                break;
        }
    }

    private async void ImportLogFiles(object sender, EventArgs e)
    {
        var error = false;
        var filePath = string.Empty;

        try
        {
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
                    var invalidLines = await Database.Insert(filePath);
                    // TODO display invalid lines
                }
            }
        }
        catch (Exception ex)
        {
            return;
        }
    }

    private async void StartAnalysis(object sender, EventArgs e)
    {
        var filter = new Filter();
        
        var error = Errors.NoError;
        switch (_selectedMethod)
        {
            case 0:
                error = listLogsControl1.InitializeFilter(filter);
                break;
            case 1:
                error = accessesPerIpControl1.InitializeFilter(filter);
                break;
            case 2:
                error = entriesPerMethod1.InitializeFilter(filter);
                break;
            case 3:
                error = entriesPerCode1.InitializeFilter(filter);
                break;
        }

        if (error != Errors.NoError)
        {
            simpleError1.DisplayError(error);
            return;
        }

        ClearDgv();

        try
        {
            List<ValueAmounts<string>> entries;
            switch (_selectedMethod)
            {
                case 0:
                    var logFiles = await Database.GetLogFilesAsync(filter);
                    DisplayLogFiles(logFiles, filter);
                    break;
                case 1:
                    entries = await Database.GetAmountOfAccessesPerIpAsync(filter);
                    DisplayEntries(entries, "Ip","Zugriffe");
                    break;
                case 2:
                    entries = await Database.GetAmountOfEntriesPerRequestMethods(filter);
                    DisplayEntries(entries, "Methode", "Einträge");
                    break;
                case 3:
                    entries = await Database.GetAmountOfEntriesPerErrorCode(filter);
                    DisplayEntries(entries, "Code", "Einträge");
                    break;
            }
        }
        catch (Exception ex)
        {
            simpleError1.DisplayError(Errors.FailedToRead);
            return;
        }
    }

    private void ClearDgv()
    {
        DGV.Rows.Clear();
        DGV.Columns.Clear();
        DGV.ReadOnly = true;
        DGV.AllowUserToAddRows = false;
        DGV.RowHeadersVisible = false;
    }

    private void DisplayLogFiles(List<LogFile> logs, Filter filter)
    {
        if (filter.ShowAllAttributes)
        {
            DGV.ColumnCount = 7;
        }
        else
        {
            DGV.ColumnCount = filter.Attributes?.Count ?? 0;
        }

        var attributeList = new List<Attributes>
        {
            Attributes.Id, Attributes.Ip, Attributes.Date, Attributes.Method, Attributes.Address, Attributes.Code,
            Attributes.ResponseTime
        };

        var useId = true;
        var useIp = true;
        var useDate = true;
        var useMethod = true;
        var useAddress = true;
        var useCode = true;
        var useResponse = true;

        var colIndex = 0;
        foreach (var attribute in attributeList)
        {
            var name = "";
            var columnSize = DataGridViewAutoSizeColumnMode.AllCells;
            switch (attribute)
            {
                case Attributes.Id:
                    name = "Id";
                    break;
                case Attributes.Ip:
                    name = "Ip";
                    break;
                case Attributes.Date:
                    name = "Datum";
                    break;
                case Attributes.Method:
                    name = "Methode";
                    break;
                case Attributes.Address:
                    name = "Adresse";
                    columnSize = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case Attributes.Code:
                    name = "Code";
                    break;
                case Attributes.ResponseTime:
                    name = "Antwortzeit";
                    break;
            }

            if (filter.ShowAllAttributes || (filter.Attributes != null && filter.Attributes.Contains(attribute)))
            {
                DGV.Columns[colIndex].Name = name;
                DGV.Columns[colIndex].AutoSizeMode = columnSize;
            }
            else if (filter.Attributes == null || !filter.Attributes.Contains(attribute))
            {
                switch (attribute)
                {
                    case Attributes.Id:
                        useId = false;
                        break;
                    case Attributes.Ip:
                        useIp = false;
                        break;
                    case Attributes.Date:
                        useDate = false;
                        break;
                    case Attributes.Method:
                        useMethod = false;
                        break;
                    case Attributes.Address:
                        useAddress = false;
                        break;
                    case Attributes.Code:
                        useCode = false;
                        break;
                    case Attributes.ResponseTime:
                        useResponse = false;
                        break;
                }

                continue;
            }

            colIndex++;
        }

        foreach (var log in logs)
        {
            var id = log.Id.ToString();
            var ip = log.Ip.ToString();
            var date = log.Date.ToString("yy-MMM-dd hh:mm:ss");
            var method = MethodUtils.GetMethodAsString(log.Method);
            var address = log.Address;
            var code = log.Code.ToString();
            var responseTime = (log.ResponseTime.HasValue ? log.ResponseTime.ToString() : "-")!;

            var values = new List<string>();
            if (useId) values.Add(id);
            if (useIp) values.Add(ip);
            if (useDate) values.Add(date);
            if (useMethod) values.Add(method);
            if (useAddress) values.Add(address);
            if (useCode) values.Add(code);
            if (useResponse) values.Add(responseTime);

            DGV.Rows.Add(values.ToArray());
        }
    }

    private void DisplayEntries<T>(List<ValueAmounts<T>> entries, string firstColumn, string secondColumn)
    {
        DGV.ColumnCount = 2;

        DGV.Columns[0].Name = firstColumn;
        DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        
        DGV.Columns[1].Name = secondColumn;
        DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        foreach (var entry in entries)
        {
            var first = entry.Value.ToString();
            var second = entry.Amount.ToString();
            
            var row = new string[]{first, second};
            DGV.Rows.Add(row);
        }
    }
}