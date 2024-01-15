using CommunityToolkit.Mvvm.ComponentModel;
using StudentMVVMProjekt.Models;
using System.Collections.Generic;

namespace StudentMVVMProjekt.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        private List<string> _educationLevel=new EducationLevels().AllEducationLevel;

        [ObservableProperty]
        private Student student;

        [ObservableProperty]
        private string selectedEducationLevel;

        [ObservableProperty]
        private List<string> educationLevel;

        public StudentViewModel()
        {
           this.student = new Student();
           SelectedEducationLevel = string.Empty;
           EducationLevel=_educationLevel;
        }

    }
}
