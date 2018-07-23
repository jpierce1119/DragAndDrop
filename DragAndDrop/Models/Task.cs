using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragAndDrop.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}