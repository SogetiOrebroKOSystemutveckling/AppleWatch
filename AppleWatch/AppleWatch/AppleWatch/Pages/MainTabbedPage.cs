using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using AppleWatch.ViewModels;
using Xamarin.Forms;

namespace AppleWatch.Pages
{
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            Children.Add(
                new PlayerPage
                {
                    BindingContext = new PlayerViewModel
                    {
                        Name = "Köket", 
                        Song = new SongViewModel("Queen", "Champions"),
                        NextSong = new SongViewModel("Queen", "Bohemian Rapsody")
                    }
                }
            );

            Children.Add(
                new PlayerPage
                {
                    BindingContext = new PlayerViewModel
                    {
                        Name = "Vardagsrummet",
                        Song = new SongViewModel("Pearl Jam", "Alive"),
                        PreviousSong = new SongViewModel("Pearl Jam", "Even flow"),
                        NextSong = new SongViewModel("Pearl Jam", "Just breathe")
                    }
                }
            );
        }
    }
}
