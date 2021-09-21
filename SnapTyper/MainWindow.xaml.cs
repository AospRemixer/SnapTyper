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

        private void StrtBtn_Click(object sender, RoutedEventArgs e)
        {
            typeTxt();
        }

        public async void typeTxt()
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
            }
        }

    }
}
