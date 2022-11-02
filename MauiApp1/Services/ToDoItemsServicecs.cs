using MauiApp1.Models;
using System.Net.Http.Json;

namespace MauiApp1.Services;

public class ToDoItemsServicecs
{
    HttpClient httpClient;
    public ToDoItemsServicecs()
    {
        this.httpClient = new HttpClient();
    }

    List<ToDoItem> toDoItems;
    public async Task<List<ToDoItem>> GetToDoItems()
    {
        if (toDoItems?.Count > 0)
            return toDoItems;

        var response = await httpClient.GetAsync("https://raw.githubusercontent.com/redfield-project/app_data/master/data.json");
        if (response.IsSuccessStatusCode)
        {
            toDoItems = await response.Content.ReadFromJsonAsync<List<ToDoItem>>();
        }

        return toDoItems;
    }
}
