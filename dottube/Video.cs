
namespace dottube
{
    public abstract class Video
    {
        public string Title 
        {
            get
            {
                return Wrapper.YoutubeDl("--get-title", VideoURL);
            }
        }

        public string ID
        {
            get
            {
                return Wrapper.YoutubeDl("--get-id", VideoURL);
            }
        }

        public string FileName
        {
            get
            {
                return Wrapper.YoutubeDl("--get-filename", VideoURL);
            }
        }

        public string URL
        {
            get
            {
                return Wrapper.YoutubeDl("--get-url", VideoURL);
            }
        }

        public string Description
        {
            get
            {
                return Wrapper.YoutubeDl("--get-description", VideoURL);
            }
        }

        public string ThumbNail
        {
            get
            {
                return Wrapper.YoutubeDl("--get-thumbnail", VideoURL);
            }
        }

        public string Duration
        {
            get
            {
                return Wrapper.YoutubeDl("--get-duration", VideoURL);
            }
        }
        
        public string Format
        {
            get
            {
                return Wrapper.YoutubeDl("--get-format", VideoURL);
            }
        }

        public string VideoURL { get; set; }
    }
}
