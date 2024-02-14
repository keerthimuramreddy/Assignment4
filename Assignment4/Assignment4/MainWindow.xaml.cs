using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Assignment4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainWindow : ContentPage
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label1.Text = "Font Size: " + Math.Truncate(e.NewValue);
            Label2.FontSize = e.NewValue;

        }
    }
}