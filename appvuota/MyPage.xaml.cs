using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace appvuota
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

        }
        public void MioClick2(object seder, EventArgs e)
        {
            Navigation.PushAsync(new Terza());
        }
    }
}
