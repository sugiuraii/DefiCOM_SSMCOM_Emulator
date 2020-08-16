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

        private readonly DefiComOUT defiComOut = new DefiComOUT();
        private bool communicate_start = false;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += (sender, a) => 
            {
                defiComOut.communicate_realtime_stop();
                Application.Quit();
            };

            boostScale.ValueChanged += (sender, args) => defiComOut.Boost = (int)boostScale.Value;
            engRevScale.ValueChanged += (sender, args) => defiComOut.Tacho = (int)engRevScale.Value;
            oilPresScale.ValueChanged += (sender, args) => defiComOut.Oil_Pres = (int)oilPresScale.Value;
            fuelPresScale.ValueChanged += (sender, args) => defiComOut.Fuel_Pres = (int)fuelPresScale.Value;
            extTempScale.ValueChanged  += (sender, args) => defiComOut.Ext_Temp = (int)extTempScale.Value;
            oilPresScale.ValueChanged  += (sender, args) => defiComOut.Oil_Pres = (int)oilPresScale.Value;
            oilTempScale.ValueChanged  += (sender, args) => defiComOut.Oil_Temp = (int)oilTempScale.Value;
            waterTempScale.ValueChanged  += (sender, args) => defiComOut.Water_Temp = (int)waterTempScale.Value;

            startButton.Clicked += (sender, args) =>
            {
                if (!communicate_start)
                {
                    defiComOut.PortName = comPortNameEntry.Text;
                    communicate_start = true;
                    startButton.Label = "Stop";
                    defiComOut.communicate_realtime_start();
                }
                else
                {
                    startButton.Label = "Start";
                    communicate_start = false;
                    defiComOut.communicate_realtime_stop();
                }
            };

            defiComOut.COMOUTErrorOccured += (sender, args) => 
            {
                var senderobj = (DefiComOUT)sender;
                communicate_start = false;
                startButton.Label = "Start";
                var md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, args.Message);
                md.Show();
                md.Dispose();
            };
        }
    }
}
