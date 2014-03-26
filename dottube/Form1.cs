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

        private void buttonGetInfo_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != null)
            {
                string VideoURL = textBox1.Text;
                YoutubeVideo video = Video.GetInstance<YoutubeVideo>(VideoURL);
                labelShowDuration.Text = video.duration.ToString();
                labelShowVideoID.Text = video.display_id.ToString();
                labelShowVideoTitle.Text = video.title.ToString();
                labelShowVideoURL.Text = video.url.ToString();
                richTextBoxDescription.Text = video.description.ToString();
                propertyGrid1.SelectedObject = video;
            }
        }

    }
}
