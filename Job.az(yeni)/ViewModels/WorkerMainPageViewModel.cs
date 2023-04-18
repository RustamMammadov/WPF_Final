using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using Job.az_yeni_.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Job.az_yeni_.ViewModels
{
    public class WorkerMainPageViewModel : ViewModelBase
    {
        public WorkerMainPageViewModel(Worker worker,MainViewModel model)
        {
            MainViewModel = model;
            Worker = worker;
            NotificationCount = $"Notifications ({Worker.Employers.Count})";
            foreach (var employer in model.Employers) {
                foreach (var vacancy in employer.Vacancies)
                {
                    Vacancies.Add(vacancy);
                }
            }
            foreach (var item in Vacancies)
            {
                TempVacancies.Add(item);
            }
        }
        public MainViewModel MainViewModel { get; set; }

        public ObservableCollection<Models.Vacancy> Vacancies { get; set; } = new();

        public ObservableCollection<Models.Vacancy> TempVacancies { get; set; } = new();
        public Models.Vacancy Vacancy { get; set; }
        public string NotificationCount { get; set; }
        public Worker Worker { get; set; }

        public string Search { get; set; }

        public double MinSalary { get; set; }

        public double MaxSalary { get; set; }
        public RelayCommand ApplyCommand { get => new RelayCommand(() =>
        {
            bool cond = true;
            foreach (var worker in Vacancy.Workers)
            {
                if(worker.Username == Worker.Username)
                {
                    cond = false;
                    break;
                }
            }
            if (cond)
            {
                MessageBox.Show("You succesfully applied");
                Vacancy.Workers.Add(Worker);
                var json = JsonSerializer.Serialize(MainViewModel.Workers);
                File.WriteAllText("Workers.json", json);
                json = JsonSerializer.Serialize(MainViewModel.Employers);
                File.WriteAllText("Employers.json", json);
            }
            else
                MessageBox.Show("You have already applied this vacancy");
        }); 
        }
        public RelayCommand ShowNotificationsCommand
        {
            get => new RelayCommand(() =>
            {
                Window window = App.Container.GetInstance<NotificationView>();
                window.DataContext = new NotificationViewModel(Worker);
                window.Show();
            });
        }

        public RelayCommand SearchCommand
        {
            get => new RelayCommand(() =>
            {
                if (Search != null)
                {
                    TempVacancies.Clear();
                    foreach (var item in Vacancies)
                    {
                        if (item.Name.ToLower().StartsWith(Search.ToLower()))
                        {

                            TempVacancies.Add(item);
                        }
                    }
                }
                else
                {
                    TempVacancies.Clear();
                    for (int i = 0; i < Vacancies.Count; i++)
                    {
                        TempVacancies.Add(Vacancies[i]);
                    }
                }
                ObservableCollection<Models.Vacancy> TempMin = new();

                foreach (var vacancy in TempVacancies)
                {
                    if (vacancy.Salary >= MinSalary)
                    {
                        TempMin.Add(vacancy);
                    }
                }
                ObservableCollection<Models.Vacancy> TempMax = new();
                foreach (var vacancy in TempMin)
                {
                    if (vacancy.Salary <= MaxSalary)
                    {
                        TempMax.Add(vacancy);
                    }
                }
                TempVacancies.Clear();
                foreach (var item in TempMax)
                {
                    TempVacancies.Add(item);
                }
            });
        }


    }
}
