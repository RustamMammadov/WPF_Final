using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using MaterialDesignColors;
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
    public class WorkersPageViewModel : ViewModelBase
    {
        private string search;
        private Worker worker;

        public string Search { get => search; set => Set(ref search, value); }

        public ObservableCollection<Worker> TempWorkers { get; set; } = new();
        public ObservableCollection<Worker> Workers { get; set; }

        public Worker Worker { get => worker; set => Set(ref worker,value); }

        public Employer Employer { get; set; }

        public MainViewModel MainViewModel { get; set; }    

        public WorkersPageViewModel(ObservableCollection<Worker> workers,Employer emp,MainViewModel viewmodel)
        {
            Workers = workers;
            foreach (var item in workers)
            {
                TempWorkers.Add(item);
            }
            Employer = emp;
            MainViewModel = viewmodel;
        }

        public RelayCommand SearchCommand
        {
            get => new RelayCommand(() =>
            {
                if (Search != null)
                {
                    TempWorkers.Clear();
                    foreach (var item in Workers)
                    {
                        if (item.Cv.Ixtisas.ToLower().StartsWith(Search.ToLower()))
                        {

                            TempWorkers.Add(item);
                        }
                    }
                }
                else
                {
                    TempWorkers.Clear();
                    for (int i = 0; i < Workers.Count; i++)
                    {
                        TempWorkers.Add(Workers[i]);
                    }
                }
            });
        }

        public RelayCommand InviteCommand
        {
            get => new RelayCommand(() =>
            {
                bool cond = true;
                foreach (var vacancy in Employer.Vacancies)
                {
                    foreach (var worker in vacancy.Workers)
                    {
                        if(Worker.Username == worker.Username)
                        {
                            cond = false;
                        }
                    }
                }
                foreach (var worker in Employer.Workers)
                {
                    if(worker.Username == Worker.Username)
                    {
                        cond = false;
                    }
                }
                if (cond)
                {
                    Employer.Workers.Add(Worker);
                    Worker.Employers.Add(Employer);
                    var json = JsonSerializer.Serialize(MainViewModel.Workers, new JsonSerializerOptions() { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles }) ;
                    File.WriteAllText("Workers.json", json);
                    json = JsonSerializer.Serialize(MainViewModel.Employers, new JsonSerializerOptions() { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles });
                    File.WriteAllText("Employers.json", json);
                }
                else
                {
                    MessageBox.Show("You already invited this worker");
                }

            });
        }
    }
}
