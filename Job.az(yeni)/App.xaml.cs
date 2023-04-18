using GalaSoft.MvvmLight;
using Job.az_yeni_.Models;
using Job.az_yeni_.ViewModels;
using Job.az_yeni_.Views;
using MaterialDesignThemes.Wpf;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Job.az_yeni_
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container;
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            var window = Container.GetInstance<MainView>();
            var viewmodel = new MainViewModel();
            var sechim = new SechimPage()
            {
                DataContext = viewmodel
            };
            viewmodel.CurrentPage = sechim;
            try
            {
                var file = File.ReadAllText("Employers.json");
                viewmodel.Employers = JsonSerializer.Deserialize<ObservableCollection<Employer>>(file);
                file = File.ReadAllText("Workers.json");
                viewmodel.Workers = JsonSerializer.Deserialize<ObservableCollection<Worker>>(file);
            }
            catch (Exception ex)
            {

            }
            window.DataContext = viewmodel;
            window.VerticalAlignment = VerticalAlignment.Center;
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.ShowDialog();
            var json = JsonSerializer.Serialize(viewmodel.Workers, new JsonSerializerOptions() { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles });
            File.WriteAllText("Workers.json", json);
            json = JsonSerializer.Serialize(viewmodel.Employers, new JsonSerializerOptions() { ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles });
            File.WriteAllText("Employers.json", json);
            Current.Shutdown();
        }

        private void Register()
        {
            Container = new();
            Container.RegisterSingleton<MainView>();
            Container.RegisterSingleton<SechimPage>();
            Container.RegisterSingleton<LoginPage>();
            Container.RegisterSingleton<WorkerSignUpPage>();
            Container.RegisterSingleton<EmployerSignUpPage>();
            Container.RegisterSingleton<EmployerPage>();
            Container.RegisterSingleton<VacanciesPage>();
            Container.RegisterSingleton<WorkersPage>();
            Container.Register<Views.Vacancy>();
            Container.Register<AddVacancyView>();
            Container.RegisterSingleton<WorkerMainPage>();
            Container.Register<NotificationView>();
        }
    }
}
