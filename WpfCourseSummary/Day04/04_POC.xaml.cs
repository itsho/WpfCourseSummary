using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication01.Day04
{
    public partial class _04_POC : Page
    {
        private static readonly Random m_objRandomGen = new Random(200);

        private  LinearGradientBrush m_objBrush1 = new LinearGradientBrush(RandomColor(), RandomColor(), 90);
        private  RadialGradientBrush m_objBrush2 = new RadialGradientBrush(RandomColor(), RandomColor());

        public _04_POC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (objRect.Fill == m_objBrush1)
            {
                m_objBrush2 = new RadialGradientBrush(RandomColor(), RandomColor());
                objRect.Fill = m_objBrush2;
            }
            else
            {
                m_objBrush1 = new LinearGradientBrush(RandomColor(), RandomColor(), 90);
                objRect.Fill = m_objBrush1;
            }
        }

        private static Color RandomColor()
        {
            Color randomColor = Color.FromArgb(128, (byte)m_objRandomGen.Next(255), (byte)m_objRandomGen.Next(255), (byte)m_objRandomGen.Next(255));
            return randomColor;
        }
    }
}