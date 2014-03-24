using log4net;
using System.Windows.Forms;

namespace dottube
{
    public partial class formMainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public formMainForm()
        {
            InitializeComponent();
        }
    }
}
