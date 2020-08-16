using System;
using DefiLinkEmulator.Common;
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

        private DefiComOUT defiComOut;
        private bool _communicate_start;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            boostScale.ValueChanged += (sender, args) => defiComOut.Boost = (int)boostScale.Value;
            engRevScale.ValueChanged += (sender, args) => defiComOut.Tacho = (int)engRevScale.Value;
            oilPresScale.ValueChanged += (sender, args) => defiComOut.Oil_Pres = (int)oilPresScale.Value;
            fuelPresScale.ValueChanged += (sender, args) => defiComOut.Fuel_Pres = (int)fuelPresScale.Value;
            extTempScale.ValueChanged  += (sender, args) => defiComOut.Ext_Temp = (int)extTempScale.Value;
            oilPresScale.ValueChanged  += (sender, args) => defiComOut.Oil_Pres = (int)oilPresScale.Value;
            oilTempScale.ValueChanged  += (sender, args) => defiComOut.Oil_Temp = (int)oilTempScale.Value;
            waterTempScale.ValueChanged  += (sender, args) => defiComOut.Water_Temp = (int)waterTempScale.Value;
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
