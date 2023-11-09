using MDViewModelSimple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDViewModelSimple.ViewModels;
using System.Diagnostics;
using MDViewModelSimple.Models;

namespace MDViewModelSimple.ViewModels
{
    class MainWindowViewModel : BaseVM
    {
        public DataContextApp dc;
        
        StudentsViewModel studentsViewModel;

        public MainWindowViewModel()
        {
            this.dc = new DataContextApp();

            studentsViewModel = new StudentsViewModel(dc);                        
        }
    }
}
