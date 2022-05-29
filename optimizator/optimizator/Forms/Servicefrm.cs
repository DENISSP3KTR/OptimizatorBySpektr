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
    public partial class Servicefrm : Form
    {
        public Servicefrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void KARTYtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(KARTYtoggle, label7);
        }

        private void XBOXtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(XBOXtoggle, label8);
        }

        private void Printtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Printtoggle, label9);
        }

        private void Bluetoothtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Bluetoothtoggle, label10);
        }

        private void Sysmaintoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Sysmaintoggle, label11);
        }

        private void Storetoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(Storetoggle, label12);
        }

        private void Servicefrm_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.AutoPopDelay = 10000;
            t.SetToolTip(label1, @"Служба, необходимая для встроенного приложения Карты, 
чтобы отображать карты, которые скачивает пользователь.
Рекомендуется отключить, если вы не пользуетесь Картами Windows");
            t.SetToolTip(label4, @"Служба, работающая с компонентами XBOX.
Рекомендуется отключить, если вы не пользуетесь XBOX через ПК");
            t.SetToolTip(label6, @"Служба, необходимая для уведомления о событиях принтера. Это касается начала печати, нехватки чернил и прочих событий.
Рекомендуется отключить, если вы не пользуетесь принтером");
            t.SetToolTip(label18, @"Служба, позволяющая использовать звуковые шлюзы, например, телефонный разговор, через Bluetooth.
Рекомендуется отключить, если вы не пользуетесь BlueTooth на ПК");
            t.SetToolTip(label16, @"Призвана повысить скорость работы Windows за счёт кэширования данных, которые использует пользователь.
Если у вас слабый ПК с небольшим объёмом оперативной памяти, вы не играете в игры (на HDD) и выполняете лишь однотипные рутинные задачи рабочего ПК – вам нужна служба.
Если у вас достаточно мощный ПК с объёмом оперативной памяти выше 8 ГБ, у вас SSD, и сценарий использования Windows может меняться – вам не нужна эта служба.");
            t.SetToolTip(label14, @"Служба, отвечающая за соединение Магазина Windows с серверами Microsoft.
Рекомендуется отключить, если вы не пользуетесь Магазином Windows");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KARTYtoggle.Checked || XBOXtoggle.Checked || Printtoggle.Checked || Bluetoothtoggle.Checked || Sysmaintoggle.Checked || Storetoggle.Checked)
            {
                Service sr = new Service();
                Task t = new Task(() =>
                {
                    sr.Sysmain(Sysmaintoggle);
                    sr.Cart(KARTYtoggle);
                    sr.Bluetooth(Bluetoothtoggle);
                    sr.MStore(Storetoggle);
                    sr.Printer(Printtoggle);
                    sr.Xbox(XBOXtoggle);
                });
                t.Start();
                Form1 frm = new Form1();
                frm.Show();
                t.Wait();
                frm.Close();
                MessageBox.Show(@"     Успешно применено
Не забудьте перезагрузить ПК
  для применения твиков");
                KARTYtoggle.Checked = false;
                XBOXtoggle.Checked = false;
                Printtoggle.Checked = false;
                Bluetoothtoggle.Checked = false;
                Sysmaintoggle.Checked = false;
                Storetoggle.Checked = false;
            }
            else
            {
                MessageBox.Show("Выберите службу/ы", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
