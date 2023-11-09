using MDViewModelSimple.Data;
using MDViewModelSimple.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MDViewModelSimple.ViewModels
{   
    class StudentsViewModel : BaseVM
    {

        DataContextApp dc;

        // ctor
        public StudentsViewModel(DataContextApp dc)
        {
            this.dc = dc;
            Students = this.dc.Students;
        }
        

        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set 
            { 
                _students = value;
                RaisePropertyChanged(nameof(Students));
            }
        }
    }
}
