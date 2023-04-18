using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using Job.az_yeni_.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Job.az_yeni_.ViewModels
{
    public class EmployerPageViewModel : ViewModelBase
    {
        private Page currentPage;

        public Page CurrentPage { get => currentPage; set => Set(ref currentPage, value); }

        public MainViewModel ViewModel { get; set; }

        public Employer Employer { get; set; }

        public EmployerPageViewModel(MainViewModel viewmodel, Employer emp)
        {
            ViewModel = viewmodel;
            Employer = emp;
        }

        public RelayCommand VacancyPageCommand
        {
            get => new RelayCommand(() =>
        {
            CurrentPage = App.Container.GetInstance<VacanciesPage>();
            CurrentPage.DataContext = new VacanciesPageViewModel(Employer,ViewModel);
        });
        }

        public RelayCommand WorkersPageCommand
        {
            get => new RelayCommand(() =>
            {
                CurrentPage = App.Container.GetInstance<WorkersPage>();
                CurrentPage.DataContext = new WorkersPageViewModel(ViewModel.Workers,Employer,ViewModel);
            });
        }
    }
}
