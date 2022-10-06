using Microsoft.Xaml.Behaviors;
using System.Reflection;
using System.Windows.Controls.Primitives;
using Walkman.UI.Controls.CustomControls;

namespace Walkman.UI.Behavors
{
    public class SmoothScrollViewerBehavior : Behavior<CustomScrollViewer>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Loaded += ScrollViewerLoaded;
        }

        private void ScrollViewerLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var property = AssociatedObject.GetType().GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            property.SetValue(AssociatedObject, new ScrollInfoAdapter((IScrollInfo)property.GetValue(AssociatedObject)));
        }
    }
}
