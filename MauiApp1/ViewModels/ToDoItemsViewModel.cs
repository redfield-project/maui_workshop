using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class ToDoItemsViewModel : ViewModelBase
    {
        private readonly ToDoItemsService _itemsService;

        [ObservableProperty]
        string labelText;

        public ObservableCollection<ToDoItem> ToDoItems { get; } = new();

        public ToDoItemsViewModel(ToDoItemsService itemsService)
        {
            _itemsService = itemsService;

            LabelText = "Hello from view model";
        }

        [RelayCommand]
        async Task GetItemsAsync()
        {
            try
            {
                var items = await _itemsService.GetToDoItems();

                if (ToDoItems.Any())
                    ToDoItems.Clear();

                foreach (var item in items)
                    ToDoItems.Add(item);

            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
        }

        [RelayCommand]
        async Task GoToDetails(ToDoItem item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync(nameof(DetailsView), true, new Dictionary<string, object>
        {
            {"ToDoItem", item }
        });
        }
    }
}
