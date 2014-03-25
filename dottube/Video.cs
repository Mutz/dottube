using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace dottube
{
    public abstract class Video
    {

        public string display_id { get; set; }
        public string upload_date { get; set; }
        public string description { get; set; }
        public string uploader_id { get; set; }
        public string extractor { get; set; }
        public int height { get; set; }
        public int like_count { get; set; }
        public string uploader { get; set; }
        public int duration { get; set; }
        public string format_id { get; set; }
        public object player_url { get; set; }
        public string id { get; set; }
        public object subtitles { get; set; }
        public string stitle { get; set; }
        public int view_count { get; set; }
        public object playlist { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string extractor_key { get; set; }
        public string format { get; set; }
        public object playlist_index { get; set; }
        public int dislike_count { get; set; }
        public int width { get; set; }
        public string ext { get; set; }
        public object annotations { get; set; }
        public string webpage_url { get; set; }
        public Format[] formats { get; set; }
        public string fulltitle { get; set; }
        public int age_limit { get; set; }
        public string thumbnail { get; set; }
        public string webpage_url_basename { get; set; }

        public class Format
        {
            public string format { get; set; }
            public string url { get; set; }
            public string vcodec { get; set; }
            public string format_note { get; set; }
            public int abr { get; set; }
            public object player_url { get; set; }
            public string ext { get; set; }
            public int preference { get; set; }
            public string format_id { get; set; }
            public int height { get; set; }
            public string resolution { get; set; }
            public int width { get; set; }
        }

    }
}
