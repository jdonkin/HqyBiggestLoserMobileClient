using System;

using Xamarin.Forms;

namespace BigLMobileClient
{
    public class PointsPage : ContentPage
    {
        public PointsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

