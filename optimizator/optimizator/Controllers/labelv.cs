using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace optimizator.Controllers
{
    public class labelv
    {
        public void LabelVisible(ToggleSwitch toggleSwitch, Label label)
        {
            if (toggleSwitch.Checked == true)
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }
    }
}
