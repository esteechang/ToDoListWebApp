﻿using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Services
{
    public class ToDoService
    {
        private readonly ToDoContext context;

        public ToDoService(ToDoContext context)
        {
            this.context = context;
        }
        public async Task<List<ToDo>> GetToDosAsync()
        {
            return await context.ToDoSet.ToListAsync();
        }

        public async Task AddAsync(ToDo toDo)
        {
            await context.ToDoSet.AddAsync(toDo);
            await context.SaveChangesAsync();

        }
    }
}
