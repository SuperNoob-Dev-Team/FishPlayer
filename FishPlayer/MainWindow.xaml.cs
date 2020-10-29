using Panuon.UI.Silver;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FishPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowX, IComponentConnector
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowX_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void WindowX_Loaded(object sender, RoutedEventArgs e)
        {
            midia.Open(new Uri(@"E:\Project\CyrusVideoDownloader\CyrusVideoDownloader\bin\Debug\download\漂♂移.flv"));
            midia.Volume = 0.2;
        }

    }
}
