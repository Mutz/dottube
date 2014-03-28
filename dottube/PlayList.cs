//-----------------------------------------------------------------------
// <copyright file="PlayList.cs" company="mutz.it">
//  Copyright (c) mutz.it. All Rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Dottube
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// public Class Playlist extends List<PlayListItems></PlayListItems>
    /// </summary>
    public class PlayList : List<PlayListItem>
    {
        /// <summary>
        /// Add a Video to the Playlist
        /// </summary>
        /// <param name="video">The Video Object to be added</param>
        public void AddVideo(Video video)
        {
            // Check if there is allready an entry with the Id, based on Lambda-Expression
            if (!this.Any(item => item.Id == video.id))
            {
                // Create new PlayListItem
                var newitem = new PlayListItem(video);
                
                // Add the PlayListItem to the Playlist
                this.Add(newitem);
            }
        }

        /// <summary>
        /// Remove an PlayListItem from the Playlist
        /// </summary>
        /// <param name="item">The PlayListItem to be removed</param>
        public void RemoveVideo(PlayListItem item)
        {
        }

        /// <summary>
        /// Generate the ListView
        /// </summary>
        /// <param name="view">The ListView-Control to be populated</param>
        public void UpdatePlaylist(ListView view)
        {
            // Delete all Items on the ListView Control
            view.Items.Clear();
            
            // Generate an ListViewItem for every PlayListItem
            foreach (PlayListItem video in this)
            {
                    ListViewItem playlistentry = new ListViewItem();
                    playlistentry.SubItems.Add(video.Title.ToString());
                    playlistentry.SubItems.Add(video.Uploader.ToString());
                    playlistentry.SubItems.Add(video.Duration.ToString());
                    playlistentry.SubItems.Add(video.Url.ToString());
                    view.Items.Add(playlistentry);             
            }
        }
    }
}
