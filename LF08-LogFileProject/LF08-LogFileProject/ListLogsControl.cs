using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LF08_LogFileProject.Models;
using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject
{
    public partial class ListLogsControl : UserControl
    {
        public ListLogsControl()
        {
            InitializeComponent();
        }

        public Errors InitializeFilter(Filter filter)
        {
            if (ActivateIpRB.Checked)
            {
                // TODO es müssen mehrere Ips angegeben werden können
                var ip = CreateIp();
                if (ip == null)
                {
                    return Errors.WrongIp;
                }

                string ipString = ip.ToString();

                filter.Ips = new [] {ipString};
            }

            if (ActivateTimespanRB.Checked)
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

            if (ActivateAttributeRB.Checked)
            {
                List<Attributes> attributes = new List<Attributes>();

                if (IpRB.Checked)
                {
                    attributes.Add(Attributes.Ip);
                }

                if (AdressRB.Checked)
                {
                    attributes.Add(Attributes.Address);
                }

                if (DateRB.Checked)
                {
                    attributes.Add(Attributes.Date);
                }

                if (CodeRB.Checked)
                {
                    attributes.Add(Attributes.Code);
                }

                if (MethodRB.Checked)
                {
                    attributes.Add(Attributes.Method);
                }

                if (ResponseTimeRB.Checked)
                {
                    attributes.Add(Attributes.ResponseTime);
                }

                filter.Attributes = attributes;
            }

            return Errors.NoError;
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
    }
}