using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VLCPlayerDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VLCPlayerPage : ContentPage
    {
        public VLCPlayerPage()
        {
            InitializeComponent();
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            base.OnAppearing();
            ((VLCPlayerViewModel)BindingContext).OnAppearing();
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            base.OnDisappearing();
            ((VLCPlayerViewModel)BindingContext).OnDisappearing();
        }
    }
}