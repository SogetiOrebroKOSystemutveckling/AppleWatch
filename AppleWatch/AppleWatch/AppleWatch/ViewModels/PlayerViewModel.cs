using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleWatch.ViewModels
{
    public class PlayerViewModel
    {
        public string Name { get; set; }

        public SongViewModel Song { get; set; }

        public SongViewModel NextSong { get; set; }
        public SongViewModel PreviousSong { get; set; }
    }

    public class SongViewModel
    {
        public SongViewModel(string artist, string title)
        {
            Artist = artist;
            Title = title;
        }

        public string Title { get; set; }

        public string Artist { get; set; }
    }
}
