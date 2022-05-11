using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using optimizator.Controllers;
using System.Windows;
using System.IO;
using System.Management;
using Shell32;
using System.Diagnostics;
namespace optimizator.ClearClass
{
    public class Clear
    {
        public void Musor(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm = @"/c rd /s /q %temp%";
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
        }
    }
}
