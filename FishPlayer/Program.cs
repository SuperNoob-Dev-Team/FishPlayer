using System;
using System.IO;

namespace FishPlayer
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Unosquare.FFME.Library.FFmpegDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mlib");
            App app = new App();
            app.InitializeComponent();
            FrmEscrower.mainWindow = new MainWindow();
            app.MainWindow = FrmEscrower.mainWindow;
            app.Run();
        }
    }
}
