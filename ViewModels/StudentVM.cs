using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ETYUTB_Orai_Jelenlet_beadando.Commands;
using ETYUTB_Orai_Jelenlet_beadando.Models;


namespace ETYUTB_Orai_Jelenlet_beadando.ViewModels
{
    public class StudentVM : ViewModelBase
    {
        private Student _student;
        private ObservableCollection<Student> _students;
        private ICommand _SubmitCommand;
        private ICommand _DeleteCommand;

        public Student Student
        {
            get => _student;
            
            set{
                _student = value;
                OnPropertyChanged("Student");
            }
        }
        public ObservableCollection<Student> Students
        {
            get=>_students;
            
            set
            {
                _students = value;
                OnPropertyChanged("Students");
            }
        }
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.Submit()
                    , (_student) => { return ((Student != null)&&(Student as Student).Name != null) && ((Student as Student).Neptun != null); });
                }
                return _SubmitCommand;
            }
        }
        public StudentVM(List<Student> students = null)
        {
            Student = new Student();
            if(students!=null)
            Students = new ObservableCollection<Student>(students);
            Students.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Students_CollectionChanged);
        }
       
        void Students_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("Students");
        }
        private void Submit()
        {
            Student.JoiningDate = DateTime.Now;
            Students.Add(Student);
            Student = new Student();
        }
    }
}