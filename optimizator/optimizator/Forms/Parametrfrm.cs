using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using optimizator.Controllers;
using optimizator.Functions;

namespace optimizator.Forms
{
    public partial class Parametrfrm : Form
    {
        public Parametrfrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void deftoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(deftoggle, label25);
        }

        private void updatetoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(updatetoggle, label26);
        }

        private void firewalltoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(firewalltoggle, label27);
        }

        private void smartsctoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(smartsctoggle, label28);
        }

        private void accelltoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(accelltoggle, label29);
        }

        private void messagetoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(messagetoggle, label30);
        }

        private void gamebartoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(gamebartoggle, label31);
        }

        private void zaliptoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(zaliptoggle, label32);
        }

        private void fonappstoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(fonappstoggle, label33);
        }

        private void telemetrytoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(telemetrytoggle, label34);
        }

        private void autorunstoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(autorunstoggle, label35);
        }

        private void fastdotoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(fastdotoggle, label36);
        }

        private void Parametrfrm_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.AutoPopDelay = 10000;
            t.SetToolTip(label1, @"Защитник Windows, защищает от угроз и вирусов в фоне.
Рекомендуется отключить, если играете в игры, что каждый фпс важен и уверенно пользуетесь интернетом.");
            t.SetToolTip(label4, @"Автообновление Windows может начаться самое неудобное время(во время игры,
скачивания важных атрибутов и т.д.), это приведет к снижению производительности.
Рекомендуется отключить.");
            t.SetToolTip(label6, @"Брандмауэр – служба, которая контролирует входящий, исходящий трафик.
Рекомендуется отключить для игр, так как могут быть потери пакетов.");
            t.SetToolTip(label12, @"Smartscreen - проверяет скачанные файлы, сайты на угрозы, но иногда видит
нормальные файлы как угрозу, при этом снижает производительность.
Рекомендуется отключить для игр.");
            t.SetToolTip(label10, @"Ускорение курсора в зависимости от скорости передвижения мыши.
Рекомендуется отключить для игр.");
            t.SetToolTip(label8, @"Уведомления системы о угрозах, обновления и т.д.
Рекомендуется отключить.");
            t.SetToolTip(label24, @"Функция дает приоритет производительности для игр.
Особенно помогает слабым ПК.
Рекомендуется включить.");
            t.SetToolTip(label22, @"Это специальный режим для пользователей, которым в силу ограниченных
возможностей сложно зажимать несколько клавиш одновременно. Но для простых пользователей при спаме клавиши вылетает приложение.
Рекомендуется отключить.");
            t.SetToolTip(label20, @"Работа приложений в фоновом режиме. Снижается производительность.
Рекомендуется отключить.");
            t.SetToolTip(label18, @"Microsoft собирает персональные данные от пользователей, 
например, Microsoft edge собирает информацию с поисков в интернете,
Ваше местоположение обрабатывается встроенными сервисами телеметрии,
вводимая информация с клавиатуры/рукописным вводом или голосовыми командами считывается и запоминается,
постоянное «подслушивание» по микрофону, обработка контактов, текстовых сообщений,
чтение жестких дисков и передача ключей шифрования на сервера Microsoft.
Рекомендуется отключить.");
            t.SetToolTip(label16, @"При старте операционной системы одновременно включаются приложения.
Это нагружает систему уже при старте и они же будут работать в фоне.
Рекомендуется отключить.");
            t.SetToolTip(label14, @"В ОС есть много анимации при отрытии папок, приложений и т.д.
Отключение этой функции даст вам прирост производительности, но плавность и сглаженность Windows значительно уменьшиться.
Рекомендуется отключить.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(accelltoggle.Checked || updatetoggle.Checked || deftoggle.Checked || firewalltoggle.Checked || smartsctoggle.Checked || messagetoggle.Checked || gamebartoggle.Checked || zaliptoggle.Checked || fonappstoggle.Checked || telemetrytoggle.Checked || autorunstoggle.Checked || fastdotoggle.Checked)
            {
                parametr p = new parametr();
                Task t = new Task(() =>
                {
                    p.autoruns(autorunstoggle);
                    p.defender(deftoggle);
                    p.fastdo(fastdotoggle);
                    p.firewall(firewalltoggle);
                    p.fon(fonappstoggle);
                    p.gamebar(gamebartoggle);
                    p.message(messagetoggle);
                    p.mousespeed(accelltoggle);
                    p.smartscreen(smartsctoggle);
                    p.telemetry(telemetrytoggle);
                    p.updatewin(updatetoggle);
                    p.zalip(zaliptoggle);
                });
                t.Start();
                t.Wait();
                MessageBox.Show(@"     Успешно применено
Не забудьте перезагрузить ПК
  для применения твиков");
                autorunstoggle.Checked = false;
                deftoggle.Checked = false;
                fastdotoggle.Checked = false;
                firewalltoggle.Checked = false;
                fonappstoggle.Checked = false;
                gamebartoggle.Checked = false;
                messagetoggle.Checked = false;
                accelltoggle.Checked = false;
                smartsctoggle.Checked = false;
                telemetrytoggle.Checked = false;
                updatetoggle.Checked = false;
                zaliptoggle.Checked = false;
            }
            else
            {
                MessageBox.Show("Выберите твик");
            }
        }
    }
}
