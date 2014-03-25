using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace dottube
{
    class YoutubeVideo : Video
    {
        public YoutubeVideo(string strUrl)
        {
            VideoURL = strUrl;
        }
    }
}
