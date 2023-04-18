using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using Job.az_yeni_.Views;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Vacancy = Job.az_yeni_.Models.Vacancy;

namespace Job.az_yeni_.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Page currentPage;

        public ObservableCollection<Worker> Workers { get; set; } = new()
        {
            //new Worker("islam123", "islam")
            //{
            //    Name = "Islam",
            //    Surname = "Salamzade",
            //    BirthDate = DateTime.Now,
            //    Employers = new()
            //    {
            //        new Employer("islam123", "islam")
            //        {
            //            Name = "islam",
            //            Surname = "salamzade",
            //        },
            //        new Employer("islam123", "islam")
            //        {
            //            Name = "islam",
            //            Surname = "salamzade",
            //        },
            //        new Employer("islam123", "islam")
            //        {
            //            Name = "islam",
            //            Surname = "salamzade",
            //        },
            //        new Employer("islam123", "islam")
            //        {
            //            Name = "islam",
            //            Surname = "salamzade",
            //        }

            //    },
            //    Cv =new CV()
            //    {
            //        Ixtisas = "It",
            //    }
            //},
            //new Worker("islam123", "islam1")
            //{
            //    Name = "Islam",
            //    Surname = "Salamzade",
            //    BirthDate = DateTime.Now,
            //    Cv =new CV()
            //    {
            //        Ixtisas = "Armud",
            //    }
            //},
            //new Worker("islam123", "islam2")
            //{
            //    Name = "Islam",
            //    Surname = "Salamzade",
            //    BirthDate = DateTime.Now,
            //    Cv =new CV()
            //    {
            //        Ixtisas = "Qala",
            //    }
            //}
        };

        public ObservableCollection<Employer> Employers { get; set; } = new()
        {
            //new Employer("islam123", "islam")
            //{
            //    Vacancies = new()
            //    {
            //        new Vacancy("Elektrik",300,"sagol"),
            //        new Vacancy("Elektrik",300,"sagol"),
            //        new Vacancy("Elektrik",300,"sagol"),
            //        new Vacancy("Elektrik",300,"sagol")
            //    }
            //}
        };

        public bool isWorker { get; set; }

        public Page CurrentPage { get => currentPage; set => Set(ref currentPage, value); }

        public MainViewModel()
        {
            CurrentPage = new();
        }
        public RelayCommand IshCommand
        {
            get => new RelayCommand(() =>
            {
                isWorker = false;
                CurrentPage = App.Container.GetInstance<LoginPage>();
                CurrentPage.DataContext = new LoginPageViewModel(this);
            }
            );
        }

        public RelayCommand IshciCommand
        {
            get => new RelayCommand(() =>
            {
                isWorker = true;
                CurrentPage = App.Container.GetInstance<LoginPage>();
                CurrentPage.DataContext = new LoginPageViewModel(this);
            }
            );
        }

    }
}
