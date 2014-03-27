using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;
using System.Windows.Forms;

namespace dottube
{
    public class PlayList : List<PlayListItem>
    {
        public void AddVideo(Video video)
        {
            if (!this.Any(item => item.id == video.id))
            {
                var newitem = new PlayListItem(video);
                this.Add(newitem);
            }
        }

        public void UpdatePlaylist(ListView view)
        {
            view.Items.Clear();
            foreach (PlayListItem video in this)
            {
                    ListViewItem playlistentry = new ListViewItem();
                    playlistentry.SubItems.Add(video.title.ToString());
                    playlistentry.SubItems.Add(video.uploader.ToString());
                    playlistentry.SubItems.Add(video.duration.ToString());
                    playlistentry.SubItems.Add(video.url.ToString());
                    view.Items.Add(playlistentry);
             
            }
        }
    }
}
