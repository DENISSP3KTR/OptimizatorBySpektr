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
    public class reestr
    {
        public void gyber(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Power").SetValue("HiberbootEnabled", 00000000);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\SYSTEM\CurrentControlSet\Control\Power").SetValue("HibernateEnabled", 00000000);
                });
                t.Start();
                t.Wait();
            }
        }
        public void uac(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    RegistryKey key;
                    key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
                    key.SetValue("EnableLUA", 00000000);
                    key.SetValue("PromptOnSecureDesktop", 00000000);
                    key.SetValue("ConsentPromptBehaviorAdmin", 00000000);
                });
                t.Start();
                t.Wait();
            }
        }
        public void AutoUp(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DriverSearching").SetValue("SearchOrderConfig", 00000000);
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate").SetValue("ExcludeWUDriversInQualityUpdate", 00000001);
                });
                t.Start();
                t.Wait();
            }
        }
        public void FSO(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    RegistryKey key;
                    key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\GameBar");
                    key.SetValue("AllowAutoGameMode", 00000000);
                    key.SetValue("AutoGameModeEnabled", 00000000);
                    key.SetValue("GamePanelStartupTipIndex", 00000003);
                    key.SetValue("ShowStartupPanel", 00000000);
                    key.SetValue("UseNexusForGameBarEnabled", 00000000);
                    key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR");
                    key.SetValue("AppCaptureEnabled", 00000000);
                    key = Registry.CurrentUser.CreateSubKey(@"System\GameConfigStore");
                    key.DeleteValue("Win32_AutoGameModeDefaultProfile");
                    key.DeleteValue("Win32_GameModeRelatedProcesses");
                    key.SetValue("GameDVR_DSEBehavior", 00000002);
                    key.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", 00000001);
                    key.SetValue("GameDVR_EFSEFeatureFlags", 00000000);
                    key.SetValue("GameDVR_Enabled", 00000000);
                    key.SetValue("GameDVR_FSEBehavior", 00000002);
                    key.SetValue("GameDVR_FSEBehaviorMode", 00000002);
                    key.SetValue("GameDVR_HonorUserFSEBehaviorMode", 00000001);
                    key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\GameDVR");
                    key.SetValue("AllowGameDVR", 00000000);
                    key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR");
                    key.SetValue("value", 00000000);
                    Registry.CurrentUser.DeleteSubKey(@"HKEY_CURRENT_USER\SYSTEM\GameConfigStore\Children");
                    Registry.CurrentUser.DeleteSubKey(@"HKEY_CURRENT_USER\SYSTEM\GameConfigStore\Parents");
                });
                t.Start();
                t.Wait();
            }
        }
        public void LANEner(ToggleSwitch tg)
        {
            if (tg.Checked == true)
            {
                const string comm = @"if (!([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] ""Administrator"")) { Start-Process powershell.exe "" - NoProfile - ExecutionPolicy Bypass - File `""$PSCommandPath`"""" -Verb RunAs; exit }

Set - ExecutionPolicy Unrestricted

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Energy-Efficient Ethernet"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Энергосберегающий Ethernet"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Ultra Low Power Mode"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Ultra Low Power Mode"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Green Ethernet"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Зеленый Ethernet"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Gigabit Lite"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Gigabit Lite"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Power Saving Mode"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Power Saving Mode"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Auto Disable Gigabit"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Автоотключение гигабитной скорости"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Advanced EEE"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Advanced EEE"" - DisplayValue ""Выкл""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Packet Coalescing"" - DisplayValue ""Disabled""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Объединение пакетов"" - DisplayValue ""Выключено""

Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""MIMO power save mode"" - DisplayValue ""No SMPS""
Set - NetAdapterAdvancedProperty - Name ""*"" - DisplayName ""Режим энергосбережения MIMO"" - DisplayValue ""Нет SMPS""";
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = comm,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                p.WaitForExit();
            }
        }
        public void SMT(ToggleSwitch tg)
        {
            if (tg.Checked)
            {
                Task t = new Task(() =>
                {
                    RegistryKey key;
                    key = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management");
                    key.SetValue("FeatureSettings", 00000001);
                    key.SetValue("FeatureSettingsOverride", 00000003);
                    key.SetValue("FeatureSettingsOverrideMask", 00000003);
                    Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Kernel").SetValue("DisableTsx", 00000001);
                });
                t.Start();
                t.Wait();
            }
        }

    }
}
