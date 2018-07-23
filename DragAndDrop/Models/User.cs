using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragAndDrop.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }
    }
}