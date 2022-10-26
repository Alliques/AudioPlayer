using System.Windows;
using System.Windows.Controls;

namespace Walkman.Wpf.CustomControls.Controls
{
    public class CustomizableButton : Button
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CustomizableButton), new PropertyMetadata(new CornerRadius(0,0,0,0)));



        public HorizontalAlignment ContentHorisontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(ContentHorisontalAlignmentProperty); }
            set { SetValue(ContentHorisontalAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ContentHorisontalAlignmentProperty =
            DependencyProperty.Register("ContentHorisontalAlignment", typeof(HorizontalAlignment), typeof(CustomizableButton), new PropertyMetadata(HorizontalAlignment.Stretch));



        public string TextContent
        {
            get { return (string)GetValue(TextContentProperty); }
            set { SetValue(TextContentProperty, value); }
        }

        public static readonly DependencyProperty TextContentProperty =
            DependencyProperty.Register("TextContent", typeof(string), typeof(CustomizableButton), new PropertyMetadata(string.Empty));



        public Thickness TextContentMargin
        {
            get { return (Thickness)GetValue(TextContentMarginProperty); }
            set { SetValue(TextContentMarginProperty, value); }
        }

        public static readonly DependencyProperty TextContentMarginProperty =
            DependencyProperty.Register("TextContentMargin", typeof(Thickness), typeof(CustomizableButton), new PropertyMetadata(new Thickness(0)));



        public FontWeight TextContentFontWeight
        {
            get { return (FontWeight)GetValue(TextContentFontWeightProperty); }
            set { SetValue(TextContentFontWeightProperty, value); }
        }

        public static readonly DependencyProperty TextContentFontWeightProperty =
            DependencyProperty.Register("TextContentFontWeight", typeof(FontWeight), typeof(CustomizableButton), new PropertyMetadata(FontWeights.Regular));



        public DataTemplate IconContent
        {
            get { return (DataTemplate)GetValue(IconContentProperty); }
            set { SetValue(IconContentProperty, value); }
        }

        public static readonly DependencyProperty IconContentProperty =
            DependencyProperty.Register("IconContent", typeof(DataTemplate), typeof(CustomizableButton), new PropertyMetadata(null));



        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(CustomizableButton), new PropertyMetadata(0.0));



        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(CustomizableButton), new PropertyMetadata(0.0));



        public HorizontalAlignment HorizontalTextAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalTextAlignmentProperty); }
            set { SetValue(HorizontalTextAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HorizontalTextAlignmentProperty =
            DependencyProperty.Register("HorizontalTextAlignment", typeof(HorizontalAlignment), typeof(CustomizableButton), new PropertyMetadata(HorizontalAlignment.Center));



        static CustomizableButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomizableButton), new FrameworkPropertyMetadata(typeof(CustomizableButton)));
        }
    }
}
