using System.Windows;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;

namespace Heute
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToggleSwitch.TurnOff();
            APIwk.Token();
        }
        
        // Работа свитча
        private async void Switch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (!this.ToggleSwitch.Toggled)
            {
                return;
            }

            if (this.ToggleSwitch.Toggled == true)
            {
                await Task.Factory.StartNew(() =>
                {                    
                    while (true)
                    {
                    Thread.Sleep(1000);                   
                    if ((System.DateTime.Now.Hour == 00) && (System.DateTime.Now.Minute == 00) && (System.DateTime.Now.Second == 00))
                    {
                            APIwk.Messg(); // Отправка сообщения
                        }
                }
                });
            }
        }
    }
}
