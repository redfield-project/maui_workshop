using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class AboutViewModel : ViewModelBase
    {
        public AboutViewModel()
        {

        }

        [RelayCommand]
        async Task Contact()
        {
            await Shell.Current.GoToAsync("/Author/Telephone");
        }
    }
}
