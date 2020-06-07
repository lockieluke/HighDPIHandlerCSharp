using System;
using System.Net.Mime;

namespace High_DPI_Handler
{
    public class HighDPIHandler
    {
        public static void EnableHighDPISupport()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
