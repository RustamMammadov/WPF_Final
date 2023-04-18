using GalaSoft.MvvmLight;
using Job.az_yeni_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.az_yeni_.ViewModels
{
    public class NotificationViewModel : ViewModelBase
    {
        public NotificationViewModel(Worker worker)
        {
            Worker = worker;
        }

        public Models.Worker Worker { get; set; }


    }
}
