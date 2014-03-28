using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dottube
{
    public class PlayListItem
    {
        /// <summary>
        /// String title
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// String id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// String duration
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// String uploader
        /// </summary>
        public string uploader { get; set; }
        /// <summary>
        /// String url
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Generates a new PlayListItem
        /// </summary>
        /// <param name="obj">The Video-Object to create a PlayListItem for</param>
        public PlayListItem(Video obj)
        {
            /// Assign the title of Video to the title of the PlayListItem
            title = obj.title;
            /// Assign the id of Video to the id of the PlayListItem
            id = obj.id;
            /// Assign the duration of Video to the dusration of the PlayListItem and convert it
            duration = TimeSpan.FromSeconds((int)obj.duration).ToString("mm':'ss");
            /// Assign the uploader of Video to the uploader of the PlayListItem
            uploader = obj.uploader;
            /// Assign the url of Video to the url of the PlayListItem
            url = obj.webpage_url;
        }
    }
}
