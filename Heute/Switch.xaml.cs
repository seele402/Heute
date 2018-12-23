using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SIVODNA_wpf
{
    /// <summary>
    /// Логика взаимодействия для Switch.xaml
    /// </summary>
    public partial class Switch : UserControl
    {
        Thickness LeftSide = new Thickness(-210, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, 0, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromArgb(100, 244, 244, 245));
        SolidColorBrush On = new SolidColorBrush(Color.FromArgb(100, 68, 148, 74));

        public bool Toggled { get; set; } 

        public Switch()
        {
            this.InitializeComponent();
            this.TurnOff();
        }

        public void TurnOff()
        {
            this.Back.Fill = this.Off;
            this.Toggled = false;
            this.Dot.Margin = this.LeftSide;
        }

        public void TurnOn()
        {
            this.Back.Fill = this.On;
            this.Toggled = true;
            this.Dot.Margin = this.RightSide;
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!this.Toggled)
            {
                this.TurnOn();
            }
            else
            {
                this.TurnOff();
            }
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!this.Toggled)
            {
                this.TurnOn();
            }
            else
            {
                this.TurnOff();
            }
        }
    }
}
