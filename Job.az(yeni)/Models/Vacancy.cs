using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.az_yeni_.Models
{
    public class Vacancy
    {
        public Vacancy() { }
        public Vacancy(string name, double salary, string description)
        {
            Name = name;
            Salary = salary;
            Description = description;
        }

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Description { get; set; }

        public int Appliers { get; set; }

        public ObservableCollection<Worker> Workers { get; set; } = new();

    }
}
