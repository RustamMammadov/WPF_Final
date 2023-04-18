using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace Job.az_yeni_.Models
{
    public class CV : ViewModelBase
    {
        private ObservableCollection<string> skills = new();
        private ObservableCollection<string> companies = new();
        private ObservableCollection
            <string> languages = new();

        //public CV(string ıxtisas, List<string> skills, List<string> companies, List<string> languages, string gitLink, string linkedin)
        //{
        //    Ixtisas = ıxtisas;
        //    Skills = skills;
        //    Companies = companies;
        //    Languages = languages;
        //    GitLink = gitLink;
        //    Linkedin = linkedin;
        //}

        public string Ixtisas { get; set; }

        public ObservableCollection<string> Skills { get => skills; set => Set(ref skills, value); }
        public ObservableCollection<string> Companies { get => companies; set => Set(ref companies, value); }
        public ObservableCollection<string> Languages { get => languages; set => Set(ref languages, value); }
        public string GitLink { get; set; }
        public string Linkedin { get; set; }

    }
}
