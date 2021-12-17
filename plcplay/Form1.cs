using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace plcplay
{
    public partial class Form1 : Form
    {
        private Plc _plcClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtIP.Text)
                || !IPAddress.TryParse(this.txtIP.Text, out _))
            {
                MessageBox.Show("Please input plc ip.");
                return;
            }
            
            if (cbNewPlc.Checked)
            {
                _plcClient = new Plc(CpuType.S71200, this.txtIP.Text.Trim(), 0, 0);
            }
            else
            {
                _plcClient = new Plc(CpuType.S7200Smart, this.txtIP.Text.Trim(), 0, 0);
            }

            _plcClient.Open();

            if (_plcClient.IsConnected)
            {
                MessageBox.Show("Connected");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (_plcClient.IsConnected)
            {
                _plcClient.Close();
                MessageBox.Show("Disconnected.");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtWriteVariable.Text))
            {
                MessageBox.Show("Fail to parse write variable.");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtWriteValue.Text))
            {
                MessageBox.Show("invalid bit number.");
                return;
            }

            if (_plcClient.IsConnected)
            {
                _plcClient.Write(this.txtWriteVariable.Text.Trim(),
                    string.Equals(this.txtWriteValue.Text.Trim(), "1", StringComparison.OrdinalIgnoreCase));
                this.lblWriteResult.Text = "Write success.";
            }
        }

        private void btnReadVariable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtReadVariable.Text))
            {
                MessageBox.Show("Variable can not be empty.");
                return;
            }

            if (_plcClient.IsConnected)
            {
                var result = _plcClient.Read(this.txtReadVariable.Text.Trim());
                this.txtReadResult.Text = (Convert.ToInt32((bool)result)).ToString();
            }
        }
    }
}