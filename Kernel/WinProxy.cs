using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Kernel
{
    public class WinProxy
    {
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        RegistryKey _regKey = null;

        public WinProxy()
        {
            _regKey = Registry.CurrentUser;
            _regKey = _regKey.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings");
        }

        private void _renew()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }


        public void ToEnableProxy()
        {
            _regKey.SetValue("ProxyEnable", 1);

            _renew();
        }

        public void ToDisableProxy()
        {
            _regKey.SetValue("ProxyEnable", 0);

            _renew();
        }
        

        public void SetProxy(string ip, int port)
        {
            _regKey.SetValue("ProxyServer", string.Format("{0}:{1}", ip.Trim(), port.ToString().Trim()));

            _renew();
        }

       
        public string GetCurrentProxy()
        {
            string res = string.Empty;

            try
            {
                res =(string)_regKey.GetValue("ProxyServer");
                res = res.Split(':')[0];
            }
            catch (Exception ex)
            {

            }


            return res;
        }

        public string GetCurrentProxyPort()
        {
            string res = string.Empty;

            try
            {
                res = (string)_regKey.GetValue("ProxyServer");
                res = res.Split(':')[1];
            }
            catch (Exception ex)
            {

            }


            return res;
        }

        public bool GetProxyEnableStatus()
        {
            bool res = false;

            try
            {
                int enableStatus = (int)_regKey.GetValue("ProxyEnable");


                if (enableStatus == 0)
                {
                    res = false;
                }
                else
                {
                    res = true;
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}
