//-----------------------------------------------------------------------
// <copyright file="Video.cs" company="mutz.it">
//  Copyright (c) mutz.it. All Rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Dottube
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Video
    /// </summary>
    public abstract class Video
    {
        /// <summary>
        /// Gets or sets
        /// </summary>
        public string display_id { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string upload_date { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string _filename { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string uploader_id { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string extractor { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int like_count { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string uploader { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string format_id { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public object player_url { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public object subtitles { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string stitle { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int view_count { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public object playlist { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string extractor_key { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public object playlist_index { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int dislike_count { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string ext { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public object annotations { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string webpage_url { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public Format[] formats { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string fulltitle { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int age_limit { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string thumbnail { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string webpage_url_basename { get; set; }

        /// <summary>
        /// Gets an Instance of T with the url 
        /// </summary>
        /// <typeparam name="T">The Type of the Instance to be retrieved</typeparam>
        /// <param name="url">The url for which to retrieve the Information</param>
        /// <returns>A Instance of </returns>
        public static T GetInstance<T>(string url) where T : Video
        {
            var instance = JsonConvert.DeserializeObject<T>(Wrapper.YoutubeDl("--dump-json ", url));
            instance.Init();
            return instance;
        }

        /// <summary>
        /// Initialize a Instance
        /// </summary>
        protected virtual void Init()
        {
        }
    }
}
