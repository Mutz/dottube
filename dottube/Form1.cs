using log4net;
using System;
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
                YoutubeVideo video = Video.GetInstance<YoutubeVideo>(textBox1.Text);
                
                //Build the Items for Listing
                ListViewItem listVideo = new ListViewItem(video.title);
                listVideo.SubItems.Add(TimeSpan.FromSeconds(video.duration).ToString("mm':'ss"));
                listVideo.SubItems.Add(video.uploader);
                listVideo.SubItems.Add(video.description);

                // Add the Item to the Listview
                listView1.Items.Add(listVideo);
                


                /**
                 * Start Debugging Stuff
                 **/
                // Debugging display Information
                labelShowFileName.Text = video._filename;
                labelShowDuration.Text = duration;
                labelShowVideoID.Text = video.display_id.ToString();
                labelShowVideoTitle.Text = video.title.ToString();
                labelShowVideoURL.Text = video.url.ToString();
                richTextBoxDescription.Text = video.description.ToString();
                pictureBoxThumbnail.LoadAsync(video.thumbnail);
                
                //PropertyGrid for Debugging Purpose
                propertyGrid1.SelectedObject = video;
            }
        }

    }
}
