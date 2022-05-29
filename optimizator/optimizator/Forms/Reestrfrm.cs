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
    public partial class Reestrfrm : Form
    {
        public Reestrfrm()
        {
            InitializeComponent();
        }
        labelv v = new labelv();
        private void gybertoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(gybertoggle, label7);
        }

        private void UACtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(UACtoggle, label8);
        }

        private void AutoUptoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(AutoUptoggle, label9);
        }

        private void FSOtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(FSOtoggle, label10);
        }

        private void LANEnertoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(LANEnertoggle, label11);
        }

        private void SMTtoggle_CheckedChanged(object sender, EventArgs e)
        {
            v.LabelVisible(SMTtoggle, label12);
        }

        private void Reestrfrm_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.AutoPopDelay = 10000;
            t.SetToolTip(label1, @"Функция гибернации заменяет кнопку завершения работы.
При работе работе гибернации не очищается память ОЗУ, а также
не завершают работу процессы системы.
Рекомендуется отключить.");
            t.SetToolTip(label4, @"Компонент запрашивает подтверждение действий, требующих прав администратора, 
в целях защиты от несанкционированного использования компьютера.
Рекомендуется отключить.");
            t.SetToolTip(label6, @"Автообновление компонентов либо самой системы может начаться самое неудобное время(во время игры,
скачивания важных атрибутов и т.д.), это приведет к снижению производительности.
Рекомендуется отключить.");
            t.SetToolTip(label18, @"Полноэкранная оптимизация - режим экрана в играх, которая разрешает накладывать оверлеи поверх игр,
но при использовании её плохо чувствуется мышь.
Рекомендуется отключить.");
            t.SetToolTip(label16, @"При долгом отсутствии от компьютера сетевой адаптер входит в энергосберегающий режим,
который после не может дать работать корректно интернету.
Рекомендуется отключить.");
            t.SetToolTip(label14, @"Патчи Spectre и Meltdown защищают ПК от аппаратных уязвимостей,
но снижающие производительность на 30%.
Рекомендуется отключить, если вы уверенно пользуетесь интернетом, не захватите вирус.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gybertoggle.Checked || UACtoggle.Checked || AutoUptoggle.Checked || FSOtoggle.Checked || LANEnertoggle.Checked || SMTtoggle.Checked)
            {
                reestr r = new reestr();
                Task t = new Task(() =>
                {
                    r.gyber(gybertoggle);
                    r.uac(UACtoggle);
                    r.AutoUp(AutoUptoggle);
                    r.FSO(FSOtoggle);
                    r.LANEner(LANEnertoggle);
                    r.SMT(SMTtoggle);
                });
                t.Start();
                t.Wait();
                MessageBox.Show(@"     Успешно применено
Не забудьте перезагрузить ПК
  для применения твиков");
                gybertoggle.Checked = false;
                UACtoggle.Checked = false;
                AutoUptoggle.Checked = false;
                FSOtoggle.Checked = false;
                LANEnertoggle.Checked = false;
                SMTtoggle.Checked = false;
            }
            else
            {
                MessageBox.Show("Выберите твик", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
