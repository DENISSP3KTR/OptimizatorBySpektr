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
    public class parametr
    {
        public void defender(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    RegistryKey key;
                    key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WinDefend");
                    key.SetValue("Start", 00000004);
                    key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService");
                    key.SetValue("Start", 00000004);
                    key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WdNisSvc");
                    key.SetValue("Start", 00000004);
                    key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Sense");
                    key.SetValue("Start", 00000004);
                    key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\wscsvc");
                    key.SetValue("Start", 00000004);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
                    key.SetValue("DisableAntiSpyware", 00000001);
                    key.SetValue("DisableRoutinelyTakingAction", 00000001);
                    key.SetValue("ServiceKeepAlive", 00000000);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
                    key.SetValue("DisableBehaviorMonitoring", 00000001);
                    key.SetValue("DisableIOAVProtection", 00000001);
                    key.SetValue("DisableOnAccessProtection", 00000001);
                    key.SetValue("DisableRealtimeMonitoring", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Reporting");
                    key.SetValue("DisableEnhancedNotifications", 00000001);
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender Security Center\\Notifications");
                    key.SetValue("DisableNotifications", 00000001);
                    key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\CurrentVersion\\PushNotifications");
                    key.SetValue("NoToastApplicationNotification", 00000001);
                    key.SetValue("NoToastApplicationNotificationOnLockScreen", 00000001);
                });
                t.Start();
                t.Wait();
            }
        }
        public void updatewin(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                const string comm = @"@echo
echo Sevice stop 
net stop wuauserv
net stop UsoSvc
@echo
echo Do Not Connect To Any Windows Update Locations
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"" /v ""DoNotConnectToWindowsUpdateInternetLocations"" /t REG_DWORD /d ""1"" /f
@echo
echo Remove Access To Use All Windows Update Features
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"" / v ""SetDisableUXWUAccess"" / t REG_DWORD / d ""1"" / f
@echo
echo Disable Automatic Updates
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU"" / v ""NoAutoUpdate"" / t REG_DWORD / d ""1"" / f
@echo
echo Do Not Include Drivers With Windows Update
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"" / v ""ExcludeWUDriversInQualityUpdate"" / t REG_DWORD / d ""1"" / f
@echo
gpupdate / force
@echo
echo Deleting Windows Update Files
rd / s / q C:\Windows\SoftwareDistribution
  md C:\Windows\SoftwareDistribution
  @echo
net start wuauserv
net start UsoSvc
echo Windows Updates Disabled Succesfully!
pause";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
                Task t = new Task(() =>
                {
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\wuauserv").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\WaaSMedicSvc").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\UsoSvc").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\BITS").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\DoSvc").SetValue("Start", 00000004);
                });
            }
        }
        public void firewall(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\ClipSVC").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\SecurityHealthService").SetValue("start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\wscsvc").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\mpssvc").SetValue("Start", 00000004);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\BFE").SetValue("Start", 00000004);
                });
                t.Start();
                t.Wait();
            }
        }
        public void smartscreen(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                const string comm = @"@echo off
echo ЋвЄ«озҐ­ЁҐ UAC...
reg add ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"" /v ""EnableLUA"" /t REG_DWORD /d 0 /f
reg add ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"" / v ""PromptOnSecureDesktop"" / t REG_DWORD / d 0 / f
reg add ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"" / v ""ConsentPromptBehaviorAdmin"" / t REG_DWORD / d 0 / f
echo ЋвЄ«озҐ­ЁҐ smartscreen...
reg add ""HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer"" / v SmartScreenEnabled / t REG_SZ / d ""Off"" / f
echo “бЇҐи­®!
pause";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
            }
        }
        public void mousespeed(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse").SetValue("MouseSensitivity", 10);
                    Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse").SetValue("MouseSensitivity", @"00, 00, 00, 00, 00, 00, 00, 00,
C0, CC, 0C, 00, 00, 00, 00, 00,
80, 99, 19, 00, 00, 00, 00, 00,
40, 66, 26, 00, 00, 00, 00, 00,
00, 33, 33, 00, 00, 00, 00, 00)");
                    Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse").SetValue("SmoothMouseYCurve", @"00,00,00,00,00,00,00,00,
00,00,38,00,00,00,00,00,
00,00,70,00,00,00,00,00,
00,00,A8,00,00,00,00,00,
00,00,E0,00,00,00,00,00");
                    RegistryKey key = Registry.Users.CreateSubKey(@".DEFAULT\Control Panel\Mouse");
                    key.SetValue("MouseSpeed", 0);
                    key.SetValue("MouseThreshold1", 0);
                    key.SetValue("MouseThreshold2", 0);
                });
                t.Start();
                t.Wait();
            }
        }
        public void message(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Windows\Explorer").SetValue("DisableNotificationCenter", 00000001);
                });
                t.Start();
                t.Wait();
            }
        }
        public void gamebar(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\GameBar");
                    key.SetValue("AllowAutoGameMode", 00000001);
                    key.SetValue("AutoGameModeEnabled", 00000001);
                });
                t.Start();
                t.Wait();
            }
        }
        public void zalip(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility").SetValue("StickyKeys", 506);
                    Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\ToggleKeys").SetValue("Flags", 58);
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\Keyboard Response");
                    key.SetValue("DelayBeforeAcceptance", 0);
                    key.SetValue("AutoRepeatRate", 0);
                    key.SetValue("AutoRepeatDelay", 0);
                    key.SetValue("Flags", 0);
                });
                t.Start();
                t.Wait();
            }
        }
        public void fon(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy").SetValue("LetAppsRunInBackground", 2);
                    Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications").SetValue("GlobalUserDisabled", 00000001);
                    Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Search").SetValue("BackgroundAppGlobalToggle", 00000000);

                });
                t.Start();
                t.Wait();
            }
        }
        public void telemetry(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm = @"@echo off
rem Made by FadeMind

echo “Ў®аЄ  вҐ«Ґ¬ҐваЁЁ...

sc stop DiagTrack > NUL 2>&1
sc config DiagTrack start= disabled > NUL 2>&1
sc delete DiagTrack > NUL 2>&1

sc stop dmwappushservice > NUL 2>&1
sc config dmwappushservice start= disabled > NUL 2>&1
sc delete dmwappushservice > NUL 2>&1

set F=%TEMP%\al.reg
set F2=%TEMP%\al2.reg
regedit /e "" % F % "" ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\AutoLogger - Diagtrack - Listener"" > NUL 2>&1
powershell - Command ""Select-String -Pattern ""\""Enabled\"""", ""\[HKEY"", ""Windows\sRegistry"" - Path \""%F%\"" | ForEach-Object {$_.Line} | Foreach-Object {$_ -replace '\""Enabled\""=dword:00000001', '\""Enabled\""=dword:00000000'} | Out-File \""%F2%\"""" > NUL 2 > &1
regedit / s ""%F2%"" > NUL 2 > &1
del ""%F%"" ""%F2%"" > NUL 2 > &1
del ""%ProgramData%\Microsoft\Diagnosis\ETLLogs\AutoLogger\*.etl"" ""%ProgramData%\Microsoft\Diagnosis\ETLLogs\ShutdownLogger\*.etl"" > NUL 2 > &1
reg add ""HKLM\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener"" / v ""Start"" / t REG_DWORD / d 0 / f > NUL 2 > &1

sc config diagnosticshub.standardcollector.service start = disabled > NUL 2 > &1

schtasks / change / TN ""Microsoft\Windows\Autochk\Proxy"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Application Experience\ProgramDataUpdater"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Application Experience\StartupAppTask"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Customer Experience Improvement Program\Consolidator"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Customer Experience Improvement Program\UsbCeip"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticResolver"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\Maintenance\WinSAT"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\NetTrace\GatherNetworkInfo"" / DISABLE > NUL 2 > &1
schtasks / change / TN ""Microsoft\Windows\PI\Sqm-Tasks"" / DISABLE > NUL 2 > &1

echo “бЇҐи­®!
pause";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
            }
        }
        public void autoruns(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm = @"/c rd /s /q shell:startup";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
            }
        }
        public void fastdo(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                Task t = new Task(() =>
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects").SetValue("VisualFXSetting", 00000002);
                });
                t.Start();
                t.Wait();
            }
        }
    }
}
