﻿using System;
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
        List<Ip> Ips = new List<Ip>();

        public ListLogsControl()
        {
            InitializeComponent();
        }

        public Errors InitializeFilter(Filter filter)
        {
            filter.ShowAllAttributes = true;
            filter.UseFilter = true;
            
            if (!ActivateIpCB.Checked && !ActivateTimespanCB.Checked && !ActivateAttributeCB.Checked)
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

            if (ActivateAttributeCB.Checked)
            {
                List<Attributes> attributes = new List<Attributes>();
                filter.ShowAllAttributes = false;
                
                if (IdCB.Checked)
                {
                    attributes.Add(Attributes.Id);
                }

                if (IpCB.Checked)
                {
                    attributes.Add(Attributes.Ip);
                }

                if (AdressCB.Checked)
                {
                    attributes.Add(Attributes.Address);
                }

                if (DateCB.Checked)
                {
                    attributes.Add(Attributes.Date);
                }

                if (CodeCB.Checked)
                {
                    attributes.Add(Attributes.Code);
                }

                if (MethodCB.Checked)
                {
                    attributes.Add(Attributes.Method);
                }

                if (ResponseTimeCB.Checked)
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

        private void deleteIpB_Click(object sender, EventArgs e)
        {
            var index = IpLB.SelectedIndex;
            Ips.RemoveAt(index);

            DisplayIps();
        }

        private void deleteAllB_Click(object sender, EventArgs e)
        {
            Ips = new List<Ip>();

            DisplayIps();
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