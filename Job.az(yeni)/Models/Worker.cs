using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Job.az_yeni_.Models
{
    public class Worker : ViewModelBase
    {
        private string name;
        private string surname;
        private string city;
        private string phone;
        private DateTime birthDate;

        public Worker(string password, string username)
        {
            Password = password;
            Username = username;
        }
        public string Password { get; set; }
        public string Username { get; set; }

        public int Id { get; set; }

        public string Name { get => name; set => Set(ref name, value); }

        public string Surname { get => surname; set => Set(ref surname, value); }

        public string City { get => city; set => Set(ref city, value); }

        public string Phone { get => phone; set => Set(ref phone, value); }

        public DateTime BirthDate { get => birthDate; set => Set(ref birthDate, value); }

        public int InvitationCount { get; set; }

        public CV Cv { get; set; } = new();

        public ObservableCollection<Employer> Employers { get; set; } = new();

    }
}
