using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.az_yeni_.Models
{
    public class Employer : ViewModelBase
    {
        private string password;
        private string username;
        private string name;
        private string surname;
        private string phone;
        private DateTime birthDate;

        public Employer(string password, string username)
        {
            Password = password;
            Username = username;
        }
        public string Password { get => password; set => Set(ref password, value); }

        public string Username { get => username; set => Set(ref username, value); }

        public int Id { get; set; }

        public string Name { get => name; set => Set(ref name, value); }

        public string Surname { get => surname; set => Set(ref surname, value); }

        public string Phone { get => phone; set => Set(ref phone, value); }

        public DateTime BirthDate { get => birthDate; set => Set(ref birthDate, value); }

        public ObservableCollection<Vacancy> Vacancies { get; set; } = new();

        public ObservableCollection<Worker> Workers { get; set; } = new();
    }
}
