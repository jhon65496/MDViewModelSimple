using MDViewModelSimple.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDViewModelSimple.Data
{
    public class DataContextApp
    {
        public DataContextApp()
        {            
            GenerateDataProviders();
            
        }

        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            { 
                _students = value; 
            }
        }

        

        // ---- --- --- --- --- --- --- --- --- --- --- ---
        public void GenerateDataProviders()
        {
            Students = new ObservableCollection<Student>();
            for (int i = 1; i < 101; i++)
            {
                var provider = new Student()
                {
                    Id = i,
                    Name = $"NameStudent-{i}"
        
                };
                Students.Add(provider);
            }
        }
    }
}
