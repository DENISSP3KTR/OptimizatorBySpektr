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
    public class Clear
    {
        public void Musor(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm = @"/c rd /s /q %temp% && rd /s /q %windir%\temp";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
                var p1 = Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = "& {Clear-RecycleBin -Force}",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p1.WaitForExit();
            }
        }
        public void Telemetry(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm1 = "@echo off" + "\n" +
                    "sc stop NvTelemetryContainer > NUL 2>&1" + "\n" +
                    "sc config NvTelemetryContainer start= disabled > NUL 2>&1" + "\n" +
                    "for /f \"tokens = 1 delims =,\" %%t in ('schtasks /Query /FO CSV ^| find /v \"TaskName\" ^| find \"NvTmMon\"') do schtasks /Change /TN \" %% ~t\" /Disable >nul 2>&1" + "\n" +
                    "for /f \"tokens = 1 delims =,\" %%t in ('schtasks /Query /FO CSV ^| find /v \"TaskName\" ^| find \"NvTmRep\"') do schtasks /Change /TN \" %% ~t\" /Disable >nul 2>&1" + "\n" +
                    "for /f \"tokens = 1 delims =,\" %%t in ('schtasks /Query /FO CSV ^| find /v \"TaskName\" ^| find \"NvTmRepOnLogon\"') do schtasks /Change /TN \" %% ~t\" /Disable >nul 2>&1" + "\n" +
                    "for /f \"tokens = 1 delims =,\" %%t in ('schtasks /Query /FO CSV ^| find /v \"TaskName\" ^| find \"NvProfileUpdaterDaily\"') do schtasks /Change /TN \" %% ~t\" /Disable >nul 2>&1" + "\n" +
                    "for /f \"tokens = 1 delims =,\" %%t in ('schtasks /Query /FO CSV ^| find /v \"TaskName\" ^| find \"NvProfileUpdaterOnLogon\"') do schtasks /Change /TN \" %% ~t\" /Disable >nul 2>&1" + "\n" +
                    "reg add \"HKCU\\SOFTWARE\\NVIDIA Corporation\\NVControlPanel2\\Client\" /v \"OptInOrOutPreference\" /t REG_DWORD /d 0 /f > NUL 2>&1" + "\n" +
                    "pause";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = comm1,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
                Task task1 = new Task(() =>
                {
                    RegistryKey key;
                    key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
                    key.SetValue("Start_TrackProgs", 00000000);
                    key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager");
                    key.SetValue("SubscribedContent-338393Enabled", 00000000);
                    key.SetValue("SubscribedContent-353694Enabled", 00000000);
                    key.SetValue("SubscribedContent-353696Enabled", 00000000);
                    key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments");
                    key.SetValue("SaveZoneInformation", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack\\EventTranscriptKey");
                    key.SetValue("EnableEventTranscript", 00000000);
                    key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Privacy");
                    key.SetValue("TailoredExperiencesWithDiagnosticDataEnabled", 00000000);
                    key = Registry.CurrentUser.CreateSubKey("Control Panel\\International\\User Profile");
                    key.SetValue("HttpAcceptLanguageOptOut", 00000001);
                    key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\InputPersonalization\\TrainedDataStore");
                    key.SetValue("HarvestContacts", 00000000);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
                    key.SetValue("DoNotShowFeedbackNotifications", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
                    key.SetValue("AllowTelemetry", 00000000);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat");
                    key.SetValue("AITEnable", 00000000);
                    key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Siuf\\Rules");
                    key.SetValue("NumberOfSIUFInPeriod", 00000000);
                    key.DeleteValue("PeriodInNanoSeconds");
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
                    key.SetValue("PublishUserActivities", 00000000);
                    key.SetValue("UploadUserActivities", 00000000);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
                    key.SetValue("MaintenanceDisabled", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat");
                    key.SetValue("DisableInventory", 00000001);
                    key.SetValue("DisableUAR", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization");
                    key.SetValue("NoLockScreenCamera", 00000001);
                    key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
                    key.SetValue("Start_TrackProgs", 00000000);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\TabletPC");
                    key.SetValue("PreventHandwritingDataSharing", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\HandwritingErrorReports");
                    key.SetValue("PreventHandwritingErrorReports", 00000001);
                    key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Input\\TIPC");
                    key.SetValue("Enabled", 00000000);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors");
                    key.SetValue("DisableLocation", 00000001);
                    key.SetValue("DisableLocationScripting", 00000001);
                    key.SetValue("DisableWindowsLocationProvider", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
                    key.SetValue("DoNotShowFeedbackNotifications", 00000001);
                    key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Siuf\\Rules");
                    key.SetValue("NumberOfSIUFInPeriod", 00000000);
                    key.SetValue("PeriodInNanoSeconds", 00000000);
                });
                task1.Start();
                task1.Wait();
            }
        }
        public void Ugl(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm1 = @"/c DISM.exe /online /Cleanup-Image /StartComponentCleanup";
                const string comm2 = @"DISM.exe /online /Cleanup-Image /SPSuperseded";
                const string comm3 = @"vssadmin delete shadows /all /quiet";
                const string comm4 = @"ipconfig /flushdns";
                const string comm5 = @"rd /s /q C:\windows.old";
                const string comm = comm1 + " && " + comm2 + " && " + comm3 + " && " + comm4 + " && " + comm5;
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
                Telemetry(tg);
                Musor(tg);
            }
        }
    }
}
