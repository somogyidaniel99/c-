using System.ComponentModel;

namespace SquareProject.Client.Pages.BaseClass
{
    public interface IViewModelBase
    {
        public bool IsBusy { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
