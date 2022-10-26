using System.ComponentModel;
using System.Windows;
using Walkman.UI.ViewModels.Base;

namespace Walkman.UI.ViewModels
{
    public class TrackBarViewModel : ViewModelBase
    {
        private readonly DataTemplate _playIconTemplate = (DataTemplate)Application.Current.TryFindResource("Play");
        private readonly DataTemplate _stopIconTemplate = (DataTemplate)Application.Current.TryFindResource("Stop");
        private bool _isPlay;
        public bool IsPlay 
        {
            get
            {
                return _isPlay;
            }
            set
            {
                _isPlay = value;
                PlayStopIcon = _isPlay ? _playIconTemplate : _stopIconTemplate;
            } 
        }
        public DataTemplate PlayStopIcon { get; set; }
        public TrackBarViewModel()
        {
            IsPlay = true;
        }
    }
}
