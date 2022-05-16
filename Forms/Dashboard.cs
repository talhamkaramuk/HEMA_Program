using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEMA_Program.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            VerticalProgressBarColor.SetState(pbarLoad, 1);
            VerticalProgressBarColor.SetState(pbarTemp, 2);
            valRev.Text = (gaugeRev.Value * 1000).ToString();
            valSpeed.Text = gaugeSpeed.Value.ToString();
        }
    }
}
