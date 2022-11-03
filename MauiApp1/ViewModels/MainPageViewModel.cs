using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class MainPageViewModel : ViewModelBase 
    {
        [ObservableProperty]
        int count;

        [ObservableProperty]
        string counterBtnText;

        public MainPageViewModel()
        {
            CounterBtnText = "Click me";
        }

        [RelayCommand]
        void CounterClicked()
        {
            Count++;

            if (Count == 1)
                CounterBtnText = $"Clicked {Count} time";
            else
                CounterBtnText = $"Clicked {Count} times";

        }
    }
}
