using System;
using Gtk;

namespace DefiLinkEmulator_GtkSharp
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.DefiLinkEmulator_GtkSharp.DefiLinkEmulator_GtkSharp", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
