﻿using System.Collections.Generic;
using Walkman.UI.ViewModels.Base;

namespace Walkman.UI.ViewModels
{
    public class WindowViewModel : ViewModelBase
    {
        public List<TrackList> TrackList { get; set; } = new List<TrackList> 
        { 
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null
        };
    }

    public class TrackList
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Number { get; set; }
        public string Time { get; set; }
    }
}
