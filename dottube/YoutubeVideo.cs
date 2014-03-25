using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json;

namespace dottube
{
    class YoutubeVideo : Video
    {
        public string VideoURL {get; set;}

        public YoutubeVideo(string strUrl)
        {
            this.VideoURL = strUrl;
            JsonConvert.DeserializeObject<YoutubeVideo>(Wrapper.YoutubeDl("--dump-json ", this.VideoURL));
        }

        
    }
}
