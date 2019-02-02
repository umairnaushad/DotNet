using DesktopAPI;
using System.Windows.Forms;

namespace DesktopGUI
{
    public partial class GUI : Form
    {
        private API apiObj;

        public GUI()
        {
            apiObj = new API();
            apiObj.Title = "Desktop Application Form";
            apiObj.Version = "V1.00.000";
            InitializeComponent();

        }

        private void GUI_Load(object sender, System.EventArgs e)
        {
            this.Text = apiObj.Title;
            label1.Text = apiObj.Version;
        }
    }
}
