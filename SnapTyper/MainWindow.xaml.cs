using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Forms;

namespace SnapTyper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool isClicked = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private async void StrtBtn_Click(object sender, RoutedEventArgs e)
        {
            string txt = mainTxt.Text;
            await Task.Delay(3000);
            SendKeys.SendWait(txt);
        }


        private void TxtEnterMouse(object sender, RoutedEventArgs e)
        {
            if (isClicked)
            {

            }
            else
            {
                isClicked = true;
                mainTxt.Text = "";
                mainTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#61a1ff"));
            }
        }

    }
}
