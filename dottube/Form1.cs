﻿using log4net;
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
                YoutubeVideo Video = new YoutubeVideo(VideoURL);
                labelShowDuration.Text = Video.duration.ToString();
                labelShowVideoID.Text = Video.display_id.ToString();
                labelShowVideoTitle.Text = Video.title.ToString();
                labelShowVideoURL.Text = Video.url.ToString();
                richTextBoxDescription.Text = Video.description.ToString();
            }
        }
    }
}
