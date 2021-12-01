using System;
using System.Collections.Generic;
using System.Text;

namespace IX_Projects
{
    class OopsPractical
    {
    }
    public class Playlist 
    {
        public string playListName { get; set; }
        public string playListCategory { get; set; }
        public string playListDescription { get; set; }
    }
    public class Video : Playlist
    { 
        public string videoName { get; set; }
        public string videoThumbnail { get; set; }
        public string videoDescription { get; set; }
        public string videoTags { get; set; }

    }
    public class Youtuber : Video
    {
        public string name { get; set; }


        public string community { get; set; }
        public string channel { get; set; }
        public string about { get; set; }
        public string videoStats { get; set; }
        private string email { get; set; }
        private int income { get; set; }
        

    }
    public class Subscriber : Youtuber
    {
        public string Name { get; set; }
        public string subscribed { get; set; }
        public string playList { get; set; }
        private string email { get; set; }

    }
}
