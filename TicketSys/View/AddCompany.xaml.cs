using System;
using System.IO;
using System.Collections.Generic;

using Xamarin.Forms;
using SQLite;

namespace TicketSys.View
{
    public partial class AddCompany : ContentPage
    {

        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"companyDB.db3");


        public AddCompany()
        {
            InitializeComponent();
        }

        async void Button_Add(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Model.Company>();

            var pKey = db.Table<Model.Company>().OrderByDescending(c => c.ID).FirstOrDefault();

            Model.Company com = new Model.Company
            {
                ID = pKey == null ? 1 : pKey.ID + 1,
                Name = comName.Text,
                Address = comAddress.Text,
            };

            db.Insert(com);

            await DisplayAlert(null,com.Name + " " + "Added", "OK");
            await Navigation.PopAsync();

        }
    }
}
