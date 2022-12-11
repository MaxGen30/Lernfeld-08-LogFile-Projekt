namespace LF08_LogFileProject
{
    public partial class ListError : UserControl
    {
        private List<(int, string)> errors = new List<(int, string)>();
        private string _path = "";
        private Database _db;

        public ListError()
        {
            InitializeComponent();

            ErrorDGV.ColumnCount = 2;

            ErrorDGV.Columns[0].Name = "Zeile";
            ErrorDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            ErrorDGV.Columns[1].Name = "Fehler";
            ErrorDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            ErrorDGV.ReadOnly = true;
            ErrorDGV.AllowUserToAddRows = false;
            ErrorDGV.RowHeadersVisible = false;
        }

        public void DisplayDialog(string path, Database db)
        {
            Visible = true;
            _path = path;
            _db = db;
            errorL.Text = "Insgesamt: 0 Fehler";
            ErrorDGV.Rows.Clear();
            errors = new List<(int, string)>();
            button1.Visible = false;
            button2.Visible = true;
        }

        public void AddError(int index, string message)
        {
            errors.Add((index, message));
        }

        public void lastDisplay()
        {
            foreach (var (item1, item2) in errors)
            {
                ErrorDGV.Rows.Add(item1, item2);
            }
            
            errorL.Text = $"Insgesamt: {errors.Count} Fehler";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            var result = await _db.Insert(_path);
        }
    }
}
