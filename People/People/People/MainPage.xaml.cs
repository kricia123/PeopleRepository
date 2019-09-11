using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using People.Model;
using static People.PersonReporsitoryCRUD;

namespace People
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       void OnNewButtonClicked(object sender, EventArgs e)
        {
            string dpath = Path.Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "dbpeople.db");

            PersonRepositoryCRUD PersonRepo = new PersonRepositoryCRUD(dpath);

            string name = EntPersonName.Text;

            Person newPerson = new Person();
            newPerson.Name = name;

            PersonRepo.CreatePerson(newPerson);

            labelStatusMassage.Text = PersonRepo.StatusMessage;

                
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
