using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace TicketSys.View
{
    public partial class UpdateCompany : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "companyDB.db3");

        Model.Company com = new Model.Company();

        public UpdateCompany()
        {
            InitializeComponent();

            var db = new SQLiteConnection(dbPath);

            listCom.ItemsSource = db.Table<Model.Company>().OrderBy(c => c.Name).ToList();

            listCom.ItemSelected += Listview_ItemSelected;
        }

        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            com = (Model.Company) e.SelectedItem;
            comID.Text = com.ID.ToString();
            comName.Text = com.Name;
            comAddress.Text = com.Address;

        }

        void Button_Update(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            Model.Company com = new Model.Company
            {
                ID = Convert.ToInt32(comID.Text),

            };
        }
    }
}
