using log4net;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace dottube
{
    public partial class formMainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected PlayList liste = new PlayList();

        public formMainForm()
        {
            InitializeComponent();
            
            
        }

        private void buttonGetInfo_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != null)
            {
                // Get the Information for the Video from URL in textBox1
                YoutubeVideo video = Video.GetInstance<YoutubeVideo>(textBox1.Text);
                liste.Add(new PlayListItem(video));
                liste.UpdatePlaylist(listViewPlayList);
                /**
                 * Start Debugging Stuff
                 **/
                // Debugging display Information
                labelShowFileName.Text = video._filename;
                labelShowVideoID.Text = video.display_id;
                labelShowVideoTitle.Text = video.title;
                labelShowVideoURL.Text = video.url;
                labelShowDuration.Text = TimeSpan.FromSeconds((int)video.duration).ToString("mm':'ss");
                richTextBoxDescription.Text = video.description.ToString();
                pictureBoxThumbnail.LoadAsync(video.thumbnail);
                propertyGrid1.SelectedObject = video;
            }
        }

        private void buttonUpdateExe_Click(object sender, EventArgs e)
        {
            Wrapper.UpdateExe();
        }

        private void buttonUpdateList_Click(object sender, EventArgs e)
        {
            
        }

    }
}
