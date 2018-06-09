using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfApplication01
{
    public partial class _03_Animation3 : Page
    {
        public _03_Animation3()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();
            DoubleAnimation doubleAnimation = new DoubleAnimation(0.0, 0.5, new Duration(new TimeSpan(0, 0, 0, 1)));
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;

            Storyboard.SetTarget(sb, btnTest);
            //Storyboard.SetTargetName(sb, "btnTest");
            Storyboard.SetTargetProperty(sb, new PropertyPath("Opacity"));

            sb.Children.Add(doubleAnimation);
            sb.Begin();
        }

        private void objRect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Storyboard sb = new Storyboard();

            ColorAnimation colorAnimation = new ColorAnimation(Colors.Blue, Colors.YellowGreen, new Duration(TimeSpan.FromSeconds(1)));
            colorAnimation.RepeatBehavior = RepeatBehavior.Forever;
            colorAnimation.Duration = TimeSpan.FromSeconds(5);
            colorAnimation.AutoReverse = true;

            Storyboard.SetTargetName(colorAnimation, "objInnerColor");
            Storyboard.SetTargetProperty(colorAnimation, new PropertyPath(SolidColorBrush.ColorProperty));

            sb.Children.Add(colorAnimation);
            sb.Begin(this);
        }
    }
}