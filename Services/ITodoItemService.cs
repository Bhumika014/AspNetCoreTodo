using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService1
    {
        Task<bool> AddItemAsync(TodoItem newItem);
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }

    public interface ITodoItemService2
    {
        Task<bool> AddItemAsync(TodoItem newItem);
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }

    public interface ITodoItemService3
    {
        Task<bool> AddItemAsync(TodoItem newItem);
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }

    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
        Task<bool> AddItemAsync(TodoItem newItem);
        Task MarkDoneAsync(Guid id);
    }
}