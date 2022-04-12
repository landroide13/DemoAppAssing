using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TicketSys.View
{
    public partial class homePage : ContentPage
    {
        public homePage()
        {
            InitializeComponent();
        }

       

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddCompany());
        }

        async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GetCompany());
        }

        async void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UpdateCompany());
        }
    }
}
