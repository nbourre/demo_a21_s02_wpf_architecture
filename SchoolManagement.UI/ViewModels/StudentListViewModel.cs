using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SchoolManagement.UI.ViewModels
{
    public class StudentListViewModel : BaseViewModel
    {
        StudentDataService data = new StudentDataService();

        ObservableCollection<Student> students;

        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }

        public StudentListViewModel()
        {
            Students = new ObservableCollection<Student>(data.GetAll());
        }

    }
}
