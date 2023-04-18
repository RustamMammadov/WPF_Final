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
using System.Windows.Controls;

namespace Job.az_yeni_.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public MainViewModel model;

        private string name;

        private string password;
        public string Name { get => name; set => Set(ref name, value); }
        public string Password { get => password; set => Set(ref password, value); }
        public ObservableCollection<Worker> Workers { get; set; }
        public ObservableCollection<Employer> Employers { get; set; }
        public LoginPageViewModel(MainViewModel viewmodel)
        {
            model = viewmodel;
            Workers = model.Workers;
            Employers = model.Employers;
        }
        public RelayCommand SignInCommand
        {
            get => new RelayCommand(() =>
            {
                if (model.isWorker)
                {
                    if (Workers.Count > 0)
                    {
                        bool cond = false;
                        foreach (var item in Workers)
                        {
                            if (Name == item.Username)
                            {
                                if (Password == item.Password)
                                {
                                    model.CurrentPage = App.Container.GetInstance<WorkerMainPage>();
                                    model.CurrentPage.DataContext = new WorkerMainPageViewModel(item, model);
                                    cond = true;
                                }
                                else
                                {
                                    MessageBox.Show("Your password is invalid");
                                    Name = string.Empty;
                                    Password = string.Empty;
                                }
                            }
                        }
                        if (!cond)
                        {
                            MessageBox.Show("Your username is invalid");
                            Name = string.Empty;
                            Password = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                        Password = string.Empty;
                        Name = string.Empty;
                    }
                }
                else
                {
                    if (Employers.Count > 0)
                    {
                        bool cond = false;
                        foreach (var item in Employers)
                        {
                            if (Name == item.Username)
                            {
                                if (Password == item.Password)
                                {
                                    model.CurrentPage = App.Container.GetInstance<EmployerPage>();
                                    model.CurrentPage.DataContext = new EmployerPageViewModel(model, item);
                                    cond = true;
                                }
                                else
                                {
                                    MessageBox.Show("Your password is invalid");
                                    Name = string.Empty;
                                    Password = string.Empty;
                                }
                            }
                        }
                        if (!cond)
                        {
                            MessageBox.Show("Your username is invalid");
                            Name = string.Empty;
                            Password = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                        Password = string.Empty;
                        Name = string.Empty;
                    }
                }
            }
            );
        }

    public RelayCommand SignUpCommand
    {
        get => new RelayCommand(() =>
        {
            bool cond = true;
            if (model.isWorker)
            {
                foreach (var item in Workers)
                {
                    if (Name == item.Username)
                    {
                        MessageBox.Show("This username is invalid");
                        Password = string.Empty;
                        Name = string.Empty;
                        cond = false;
                    }
                }
                if (cond)
                {
                    if (Name != null && Password != null)
                    {
                        var worker = new Worker(Password, Name);
                        model.CurrentPage = App.Container.GetInstance<WorkerSignUpPage>();
                        model.CurrentPage.DataContext = new SignUpPageWorkerViewModel(worker,model);
                        Workers.Add(worker);
                        string json = JsonSerializer.Serialize(Workers);
                        File.WriteAllText("Workers.json", json);
                    }
                    else
                        MessageBox.Show("error");
                }
            }
            else
            {
                foreach (var item in Employers)
                {
                    if (Name == item.Username)
                    {
                        MessageBox.Show("This username is invalid");
                        Password = string.Empty;
                        Name = string.Empty;
                        cond = false;
                    }
                }
                if (cond)
                {
                    if (Name != null && Password != null)
                    {
                        var emp = new Employer(Password, Name);
                        Employers.Add(emp);
                        model.CurrentPage = App.Container.GetInstance<EmployerSignUpPage>();
                        model.CurrentPage.DataContext = new EmployerSignUpViewModel(emp,model);
                        string json = JsonSerializer.Serialize(Employers);
                        File.WriteAllText("Employers.json", json);
                    }
                    else
                        MessageBox.Show("error");

                }
            }
        }
        );

    }
}
}
