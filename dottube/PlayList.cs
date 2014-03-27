using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Windows.Forms;

namespace dottube
{
    public class PlayList : List<PlayListItem>
    {
        protected bool ItemExist(PlayList liste, PlayListItem video)
        {
            if (liste.Contains(video))
            {
                return true;
            }
            else
                return false;
        }

        public void UpdatePlaylist(ListView view)
        {
            foreach (PlayListItem video in this)
            {
                if (!ItemExist(this, video))
                {
                    ListViewItem playlistentry = new ListViewItem();
                    playlistentry.SubItems.Add(video.title.ToString());
                    playlistentry.SubItems.Add(video.uploader.ToString());
                    playlistentry.SubItems.Add(video.duration.ToString());
                    view.Items.Add(playlistentry);
                }
            }
        }
    }
}
