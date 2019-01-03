using System.Windows;
using VkNet;
using VkNet.Model;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;

namespace Heute
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToggleSwitch.TurnOff();
        }
        private void Token()
        {
            var api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                AccessToken = ""
            });
        }

        // Работа слайдера
        private async void Switch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (!this.ToggleSwitch.Toggled)
            {
                //this._cancellationGetUpdates?.Cancel();
                return;
            }

            if (this.ToggleSwitch.Toggled == true)
            {
                await Task.Factory.StartNew(() =>
                {                    
                    while (true)
                    {

                    Thread.Sleep(1000);
                        
                    if ((System.DateTime.Now.Hour == 17) && (System.DateTime.Now.Minute == 42) && (System.DateTime.Now.Second == 00))
                    {
                            // отправка сообщения
                            var api = new VkApi();
                            api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
                            {
                                PeerId = 112853315,
                                Message = "СИВОДНЯ" //пример сообщения
                            });
                        }
                }
                });
            }
        }

        private void Switch_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
