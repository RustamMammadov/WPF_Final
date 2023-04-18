using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using Job.az_yeni_.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Job.az_yeni_.ViewModels
{
    public class VacanciesPageViewModel : ViewModelBase
    {
        private int appliers;

        public ObservableCollection<Models.Vacancy> Vacancies { get; set; }

        public Models.Vacancy Vacancy { get; set; }

        public Employer Employer { get; set; }

        public MainViewModel MainViewModel { get; set; }

        public VacanciesPageViewModel(Employer emp,MainViewModel model)
        {
            this.Employer = emp;
            Vacancies = emp.Vacancies;
            MainViewModel = model;
        }

        public RelayCommand OpenAppliersCommand
        {
            get => new RelayCommand(() =>
        {
            if (Vacancy == null)
            {
                MessageBox.Show("Please double click on vacancy");
            }
            else
            {
                Window window = App.Container.GetInstance<Views.Vacancy>();
                window.DataContext = new VacancyWindowViewModel(Vacancy.Workers);
                window.ShowDialog();
            }
        });
        }

        public RelayCommand AddVacancyCommand
        {
            get => new RelayCommand(() =>
            {
                Window window = App.Container.GetInstance<AddVacancyView>();
                window.DataContext = new AddVacancyViewModel(Employer, window,MainViewModel);
                window.ShowDialog();
            });
        }
    }
}
