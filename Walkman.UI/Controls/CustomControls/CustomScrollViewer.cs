using System.Windows;
using System.Windows.Controls;

namespace Walkman.UI.Controls.CustomControls
{
    public class CustomScrollViewer : ScrollViewer
    {
        public CustomScrollViewer()
        {
            Loaded += ScrollViewer_Loaded;
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            ScrollInfo = new ScrollInfoAdapter(ScrollInfo);
        }
    }
}
