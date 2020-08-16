using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace DefiLinkEmulator_GtkSharp
{
    class MainWindow : Window
    {
        [UI] private Entry comPortNameEntry = null;
        [UI] private Scale boostScale = null;
        [UI] private Scale engRevScale = null;
        [UI] private Scale oilPresScale = null;
        [UI] private Scale fuelPresScale = null;
        [UI] private Scale extTempScale = null;
        [UI] private Scale oilTempScale = null;
        [UI] private Scale waterTempScale = null;
        [UI] private Button startButton = null;


        private int _counter;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            //_button1.Clicked += Button1_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }
/*
        private void Button1_Clicked(object sender, EventArgs a)
        {
            _counter++;
            _label1.Text = "Hello World! This button has been clicked " + _counter + " time(s).";
        }
*/
    }
}
