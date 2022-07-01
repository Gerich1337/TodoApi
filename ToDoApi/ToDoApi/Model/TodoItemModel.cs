using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApi.Model
{
    public class TodoItemModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
