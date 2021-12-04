using System.Windows.Media;
using System.Windows;

namespace Frontend.Infra
{
    public class UIAttachedDecoration
    {
        public static Brush GetMouseOverBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(MouseOverBackgroundProperty);
        }

        public static void SetMouseOverBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(MouseOverBackgroundProperty, value);
        }
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.RegisterAttached("MouseOverBackground", typeof(Brush), typeof(UIAttachedDecoration), new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));



        public static Brush GetPressedBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(PressedBackgroundProperty);
        }

        public static void SetPressedBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(PressedBackgroundProperty, value);
        }
        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.RegisterAttached("PressedBackground", typeof(Brush), typeof(UIAttachedDecoration), new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));



        public static Color GetDropShadowBitmapEffectColor(DependencyObject obj)
        {
            return (Color)obj.GetValue(DropShadowBitmapEffectColorProperty);
        }

        public static void SetDropShadowBitmapEffectColor(DependencyObject obj, Color value)
        {
            obj.SetValue(DropShadowBitmapEffectColorProperty, value);
        }

        public static readonly DependencyProperty DropShadowBitmapEffectColorProperty =
            DependencyProperty.RegisterAttached("DropShadowBitmapEffectColor", typeof(Color), typeof(UIAttachedDecoration), new UIPropertyMetadata(Colors.Gray));




        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(UIAttachedDecoration), new UIPropertyMetadata(new CornerRadius(0, 0, 0, 0)));


    }
}
