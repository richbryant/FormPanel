using System;
using System.Security.Cryptography.X509Certificates;
using Prism.Mvvm;

namespace WpfTestApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Test FormControl";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {
           
        }

        public Person Person { get; set; } = new Person
        {
            FirstName = "John", LastName = "Smith", DateOfBirth = Convert.ToDateTime("25/12/1980"),
            Email = "joh.smith@fake.com"
        };
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
