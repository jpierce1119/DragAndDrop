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
            var context = new Data.AppContext();
            return context.Tasks.AsEnumerable();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}