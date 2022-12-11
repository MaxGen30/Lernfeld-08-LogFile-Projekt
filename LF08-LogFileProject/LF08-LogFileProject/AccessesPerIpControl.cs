using LF08_LogFileProject.Models;
using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject
{
    public partial class AccessesPerIpControl : UserControl
    {
        List<Ip> Ips = new List<Ip>();
        private SimpleError SE;

        public AccessesPerIpControl()
        {
            InitializeComponent();
        }
        
        public void GiveException(SimpleError se)
        {
            SE = se;
        }
        
        public Errors InitializeFilter(Filter filter)
        {
            filter.ShowAllAttributes = true;
            filter.UseFilter = true;
            
            if (!ActivateIpCB.Checked && !ActivateTimespanCB.Checked)
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
                DateTime start;
                try
                {
                    start = BeginDP.Value.Date + BeginTP.Value.TimeOfDay;
                }
                catch (Exception e)
                {
                    return Errors.InvalidBegin;
                }
                
                DateTime end;
                try
                {
                    end = EndDP.Value.Date + EndTP.Value.TimeOfDay;
                }
                catch (Exception e)
                {
                    return Errors.InvalidEnd;
                }

                if (start > end)
                {
                    return Errors.StartBiggerThanEnd;
                }

                filter.Start = start;
                filter.End = end;
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
                SE.DisplayError(Errors.InvalidIp);
                return;
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
            try
            {
                var index = IpLB.SelectedIndex;
                Ips.RemoveAt(index);

                DisplayIps();
            }
            catch (Exception ex)
            {
                SE.DisplayError(Errors.DeleteIpError);
            }
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
    }
}
