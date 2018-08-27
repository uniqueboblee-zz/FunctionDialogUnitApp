using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FunctionDialogUnitApp
{
    public sealed partial class ShowFunctionDialog : ContentDialog
    {
        public ShowFunctionDialog()
        {
            this.InitializeComponent();
        }

        public string Command{ get; set; }
        private void OK_ButtonClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
