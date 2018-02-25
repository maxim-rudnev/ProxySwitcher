using ProxySwitcher.Kernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public partial class MainForm : Form
    {
        WinProxy _winProxy = null;

        public MainForm()
        {
            InitializeComponent();

            _winProxy = new WinProxy();
        }

        private void buttonSaveProxyConfig_Click(object sender, EventArgs e)
        {
            try
            {
                _winProxy.SetProxy(textBoxIP.Text, int.Parse(textBoxPort.Text));
            }
            catch (Exception ex)
            {
            }

            if (checkBoxProxyEnabled.Enabled) _winProxy.ToEnableProxy();
            else _winProxy.ToDisableProxy();
        }
    }
}
