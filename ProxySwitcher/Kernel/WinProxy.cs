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
            _regKey.SetValue("ProxyServer", string.Format("{0}:{1}", ip, port.ToString() ));

            _renew();
        }

       
    }
}
