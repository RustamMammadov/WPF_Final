using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Job.az_yeni_.ViewModels
{
    public class AddVacancyViewModel : ViewModelBase
    {
        public MainViewModel MainViewModel { get; set; }
        public AddVacancyViewModel(Employer employer,Window window,MainViewModel model)
        {
            Vacancy = new();
            Employer = employer;
            CurrentWindow = window;
            MainViewModel = model;
        }
        public Window CurrentWindow { get; set; }   
        public Models.Vacancy Vacancy { get; set; }

        public Employer Employer { get; set; }

        public RelayCommand SaveVacancyCommand
        {
            get => new RelayCommand(() =>
        {
            Employer.Vacancies.Add(Vacancy);
            var json = JsonSerializer.Serialize(MainViewModel.Workers);
            File.WriteAllText("Workers.json", json);
            json = JsonSerializer.Serialize(MainViewModel.Employers);
            File.WriteAllText("Employers.json", json);
            CurrentWindow.Close();
        });
        }
    }
}
