using LF08_LogFileProject.Models;
using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject
{
    public partial class EntriesPerCode : UserControl
    {
        List<Ip> Ips = new List<Ip>();
        private List<int> Codes = new List<int>();

        public EntriesPerCode()
        {
            InitializeComponent();
        }
        
        public Errors InitializeFilter(Filter filter)
        {
            filter.ShowAllAttributes = true;
            filter.UseFilter = true;
            
            if (!ActivateIpCB.Checked && !ActivateTimespanCB.Checked && !ActivateCodeCB.Checked)
            {
                filter.UseFilter = false;
                return Errors.NoError;
            }

            if (ActivateIpCB.Checked)
            {
                if (!Ips.Any())
                {
                    return Errors.NoIps;
                }
                
                List<string> ipStrings = new List<string>();
                foreach (var ip in Ips)
                {
                    string ipString = ip.ToString();
                    ipStrings.Add(ipString);
                }
                filter.Ips = ipStrings;
            }

            if (ActivateTimespanCB.Checked)
            {
                var start = BeginDTP.Value;
                var end = EndDTP.Value;

                if (start > end)
                {
                    return Errors.StartBiggerThanEnd;
                }

                filter.Start = start;
                filter.End = end;
            }

            if (ActivateCodeCB.Checked)
            {
                filter.FilterCodes = true;
                if (!Codes.Any())
                {
                    return Errors.NoCodes;
                }
                
                var codeList = new List<int>();
                foreach (var code in Codes)
                {
                    codeList.Add(code);
                }
                filter.Codes = codeList;
            }

            return Errors.NoError;
        }

        private void IpB_Click(object sender, EventArgs e)
        {
            Ip? ip = CreateIp();

            if(ip != null)
            {
                Ips.Add(ip);
            } else
            {
                // TODO display Error
            }

            DisplayIps();
        }

        private void deleteAllB_Click(object sender, EventArgs e)
        {
            Ips = new List<Ip>();

            DisplayIps();
        }

        private void deleteIpB_Click(object sender, EventArgs e)
        {
            var index = IpLB.SelectedIndex;
            Ips.RemoveAt(index);

            DisplayIps();
        }
        
        private Ip? CreateIp()
        {
            var ip1String = IpIN1.Text;
            var ip2String = IpIN2.Text;
            var ip3String = IpIN3.Text;
            var ip4String = IpIN4.Text;

            if (ip1String == "" || ip2String == "" || ip3String == "" || ip4String == "")
            {
                return null;
            }

            try
            {
                var ip = new Ip(ip1String + "." + ip2String + "." + ip3String + "." + ip4String);
                return ip;
            }
            catch
            {
                return null;
            }
        }
        
        private void DisplayIps()
        {
            IpLB.Items.Clear();

            foreach (var ip in Ips)
            {
                IpLB.Items.Add(ip);
            }
        }

        private void addCodeB_Click(object sender, EventArgs e)
        {
            Ip? ip = CreateIp();

            if (ip != null)
            {
                Ips.Add(ip);
            }
            else
            {
                // TODO display Error
            }

            DisplayCodes();
        }

        private void deleteAllCodesB_Click(object sender, EventArgs e)
        {
            Codes = new List<int>();

            DisplayCodes();
        }

        private void deleteCodeB_Click(object sender, EventArgs e)
        {
            var index = CodeLB.SelectedIndex;
            Codes.RemoveAt(index);

            DisplayCodes();
        }

        private void DisplayCodes()
        {
            CodeLB.Items.Clear();

            foreach (var code in Codes)
            {
                CodeLB.Items.Add(code.ToString());
            }
        }
    }
}
