using log4net;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

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
                Task.Factory.StartNew<YoutubeVideo>(() => { return Video.GetInstance<YoutubeVideo>(textBox1.Text); }).ContinueWith(gettask =>
                {
                    YoutubeVideo video = gettask.Result;
                    liste.AddVideo(video);
                    liste.UpdatePlaylist(listViewPlayList);
                    /**
                     * Show Information
                     **/

                    labelShowFileName.Text = video._filename;
                    labelShowVideoTitle.Text = video.title;
                    labelShowDuration.Text = TimeSpan.FromSeconds((int)video.duration).ToString("mm':'ss");
                    richTextBoxDescription.Text = video.description.ToString();
                    pictureBoxThumbNail.LoadAsync(video.thumbnail);

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private void buttonUpdateExe_Click(object sender, EventArgs e)
        {
            Wrapper.UpdateExe();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (listViewPlayList.CheckedItems.Count > 0)
            {
                buttonDownload.Enabled = false;
                progressBarDownload.Visible = true;
                var urls = new List<string>();
                foreach (ListViewItem item in listViewPlayList.CheckedItems)
                {
                    urls.Add(item.SubItems[4].Text);
                    item.Checked = false;
                }

                Task.Factory.StartNew(() =>
                {
                    foreach (string url in urls)
                    {
                        Wrapper.YoutubeDl("--output %(uploader)s/%(title)s-%(id)s.%(ext)s", url);

                    }
                }).ContinueWith(task =>
                {
                    MessageBox.Show("Finished!");
                    buttonDownload.Enabled = true;
                    progressBarDownload.Visible = false;
                }, TaskScheduler.FromCurrentSynchronizationContext()); 
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listViewPlayList.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewPlayList.CheckedItems)
                {
                    listViewPlayList.Items.Remove(item);
                    
                }
            }
        }
    }
}
