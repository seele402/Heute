using System.Windows;
using VkNet;
using VkNet.Model;
using System.Windows.Media;
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
        }

        // Работа слайдера
        private async void Switch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int Hour = 0;
            int Minute = 0;
            int Seconds = 0;

            if (!this.Switch.Toggled)
            {
                //this._cancellationGetUpdates?.Cancel();
                return;
            }

            await Task.Factory.StartNew(() =>
            {                           
                while (true)
                {
                    Thread.Sleep(1000);

                    if ((Hour == System.DateTime.Now.Hour) && (Minute == System.DateTime.Now.Minute) && (Seconds == System.DateTime.Now.Second))
                    {
                        var api = new VkApi();
                        // авторизация
                        api.Authorize(new ApiAuthParams
                        {
                            AccessToken = "access_token"
                        });
                        // отправка сообщения
                        api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
                        {
                            PeerId = 2000000131,
                            Message = "а"
                        });
                    }
                }
            });
        }

        private void Switch_Loaded(object sender, RoutedEventArgs e)
        {
            Switch.TurnOff();
        }
    }
}
