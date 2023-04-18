using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Job.az_yeni_.Models;
using Job.az_yeni_.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Job.az_yeni_.ViewModels
{
    public class SignUpPageWorkerViewModel : ViewModelBase
    {
        private string skill;
        private string language;
        private string company;

        public string Skill { get => skill; set => Set(ref skill, value); }

        public string Language { get => language; set => Set(ref language, value); }

        public string Company { get => company; set => Set(ref company, value); }

        public MainViewModel MainViewModel { get; set; }
        public Worker Worker { get; set; }
        public SignUpPageWorkerViewModel(Worker worker,MainViewModel model)
        {
            Worker = worker;
            MainViewModel = model;

        }

        public RelayCommand AddToSkillsCommand
        {
            get => new RelayCommand(() =>
            {
                Worker.Cv.Skills.Add(Skill);
                Skill = string.Empty;
            }
            );
        }

        public RelayCommand AddToCompaniesCommand
        {
            get => new RelayCommand(() =>
            {
                Worker.Cv.Companies.Add(Company);
                Company = string.Empty;
            }
            );
        }

        public RelayCommand AddToLanguagesCommand
        {
            get => new RelayCommand(() =>
            {
                Worker.Cv.Languages.Add(Language);
                Language = string.Empty;
            }
            );
        }

        public RelayCommand SaveCommand
        {
            get => new RelayCommand(() =>
            {
                MessageBox.Show("User Created");
                MainViewModel.CurrentPage = App.Container.GetInstance<WorkerMainPage>();
                MainViewModel.CurrentPage.DataContext = new WorkerMainPageViewModel(Worker,MainViewModel);
            }
            );
        }


    }
}
