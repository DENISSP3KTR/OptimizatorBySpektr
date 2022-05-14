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
using Microsoft;
using Microsoft.Win32;

namespace optimizator.Functions
{
    public class Service
    {
        public void Cart(ToggleSwitch tg)
        {
            if(tg.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\MapsBroker").SetValue("Start", 00000004);
            }
        }
        public void Xbox(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\XblGameSave").SetValue("Start", 00000004);
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\XboxNetApiSvc").SetValue("Start", 00000004);
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\XboxGipSvc").SetValue("Start", 00000004);
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\XblAuthManager").SetValue("Start", 00000004);
            }
        }
        public void Printer(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Spooler").SetValue("Start", 00000004);
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\PrintNotify").SetValue("Start", 00000004);
            }
        }
        public void Bluetooth(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\BTAGService").SetValue("Start", 00000004);
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\bthserv").SetValue("Start", 00000004);
            }
        }
        public void Sysmain(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\sysmain").SetValue("Start", 00000004);
            }
        }
        public void MStore(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\WindowsStore").SetValue("AutoDownload", 00000002);
            }
        }
    }
}
