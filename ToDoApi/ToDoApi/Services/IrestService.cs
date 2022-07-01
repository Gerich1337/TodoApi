using ToDoApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApi.Services
{
    public interface IRestService
    {
        Task<List<TodoItemModel>> GetTodoItemAsync();
        Task SaveTodoItemAsync(TodoItemModel item, bool isNewItem);
        Task DeleteTodoItemAsync(TodoItemModel item);
    }
}
