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
        }
    }
}
