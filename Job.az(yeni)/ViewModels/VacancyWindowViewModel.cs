using GalaSoft.MvvmLight;
using Job.az_yeni_.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.az_yeni_.ViewModels
{
    public class VacancyWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Worker> Workers { get; set; }

        public VacancyWindowViewModel(ObservableCollection<Worker> workers)
        {
            Workers = workers;
        }
    }
}
