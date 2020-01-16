using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestRestAPI3.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public int PercentCompleted { get; set; }
    }
}
