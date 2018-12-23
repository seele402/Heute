using System.Windows;
using VkNet;
using VkNet.Model;
using System.Windows.Media;
using System.Windows.Input;

namespace Heute
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Thickness LeftSide = new Thickness(-110.8, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, -110.8, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromArgb(100, 244, 244, 245));
        SolidColorBrush On = new SolidColorBrush(Color.FromArgb(100, 68, 148, 74));

        public bool Toggled1 { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();
            Back.Fill = Off;
            Toggled1 = false;
            Dot.Margin = LeftSide;
        }
        
        // Работа слайдера (нажатие на круг)
        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled1) // Слайдер активирован
            {
                Back.Fill = On;
                Toggled1 = true;
                Dot.Margin = RightSide;

                int Hour = 00;
                int Minute = 00;
                int Seconds = 00;
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);

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
            }
            else // Слайдер не активирован
            {
                Back.Fill = Off;
                Toggled1 = false;
                Dot.Margin = LeftSide;
            }
        }
        // Работа слайдера(нажатие на бекграунд слайдера)
        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled1) // Слайдер активирован
            {
                Back.Fill = On;
                Toggled1 = true;
                Dot.Margin = RightSide;

                int Hour = 00;
                int Minute = 00;
                int Seconds = 00;
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);

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
            }
            else // Слайдер не активирован
            {
                Back.Fill = Off;
                Toggled1 = false;
                Dot.Margin = LeftSide;
            }
        }
    }
}
