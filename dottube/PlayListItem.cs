using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dottube
{
    public class PlayListItem
    {
        public string title { get; set; }
        public string id { get; set; }
        public string duration { get; set; }
        public string uploader { get; set; }

        public PlayListItem(Video obj)
        {
            title = obj.title;
            id = obj.id;
            duration = TimeSpan.FromSeconds((int)obj.duration).ToString("mm':'ss");
            uploader = obj.uploader;
        }
    }
}
