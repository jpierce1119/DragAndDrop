using DragAndDrop.Data;
using DragAndDrop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DragAndDrop.Controllers
{
    public class TasksController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Task> Get()
        {
            var context = new AppDbContext();
            var list = context.Tasks.ToList();
            return list;
        }

        // POST api/<controller>
        public void Post([FromBody]PostData data)
        {
            if (Int32.TryParse(data.TaskID, out int taskID) && (Int32.TryParse(data.UserID, out int userID) || string.IsNullOrEmpty(data.UserID)))
            {
                var context = new AppDbContext();
                var task = context.Tasks.Where(x => x.ID == taskID).FirstOrDefault();

                if (task != null)
                {
                    if (string.IsNullOrEmpty(data.UserID))
                    {
                        task.UserID = null;
                    }
                    else
                    {
                        task.UserID = userID;
                    }
                    context.SaveChanges();
                }
            }
        }
    }

    public class PostData
    {
        public string UserID { get; set; }
        public string TaskID { get; set; }
    }
}