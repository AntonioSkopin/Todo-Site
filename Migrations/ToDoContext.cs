﻿using Microsoft.EntityFrameworkCore;
using ToDo_App.Models;

namespace ToDo_App.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
