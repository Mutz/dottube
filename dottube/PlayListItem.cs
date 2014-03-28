//-----------------------------------------------------------------------
// <copyright file="PlayListItem.cs" company="mutz.it">
//  Copyright (c) mutz.it. All Rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Dottube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class PlayListItem
    /// </summary>
    public class PlayListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayListItem"/> class
        /// </summary>
        /// <param name="obj">The Video-Object to create a PlayListItem for</param>
        public PlayListItem(Video obj)
        {
            // Assign the Title of Video to the Title of the PlayListItem
            this.Title = obj.title;
            
            // Assign the Id of Video to the Id of the PlayListItem
            this.Id = obj.id;
            
            // Assign the Duration of Video to the dusration of the PlayListItem and convert it
            this.Duration = TimeSpan.FromSeconds((int)obj.duration).ToString("mm':'ss");
            
            // Assign the Uploader of Video to the Uploader of the PlayListItem
            this.Uploader = obj.uploader;
            
            // Assign the Url of Video to the Url of the PlayListItem
            this.Url = obj.webpage_url;
        }

        /// <summary>
        /// Gets or sets Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Duration
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets Uploader
        /// </summary>
        public string Uploader { get; set; }

        /// <summary>
        /// Gets or sets Url
        /// </summary>
        public string Url { get; set; }
    }
}
