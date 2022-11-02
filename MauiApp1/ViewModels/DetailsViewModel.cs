using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    [QueryProperty(nameof(ToDoItem), "ToDoItem")]
    public partial class DetailsViewModel : ViewModelBase
    {
        public DetailsViewModel()
        {

        }

        [ObservableProperty]
        ToDoItem toDoItem;
    }
}
