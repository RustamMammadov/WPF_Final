using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using Job.az_yeni_.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.az_yeni_.ViewModels
{
    public class EmployerSignUpViewModel : ViewModelBase
    {
        public EmployerSignUpViewModel(Employer employer,MainViewModel model)
        {
            Employer = employer;
            Vacancy = new();
            Model = model;
        }

        public MainViewModel Model { get; set; }
        public Employer Employer { get; set; }

        public Models.Vacancy Vacancy { get; set; }

        public RelayCommand SaveCommand { get => new RelayCommand(() =>
        {
            Employer.Vacancies.Add(Vacancy);
            Model.CurrentPage = App.Container.GetInstance<EmployerPage>();
            Model.CurrentPage.DataContext = new EmployerPageViewModel(Model,Employer);
        });
        }


    }
}
