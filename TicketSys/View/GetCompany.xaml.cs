using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace TicketSys.View
{
    public partial class GetCompany : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "companyDB.db3");


        public GetCompany()
        {
            InitializeComponent();

            var db = new SQLiteConnection(dbPath);

            listCom.ItemsSource = db.Table<Model.Company>().OrderBy(c => c.Name).ToList();
        }
    }
}
