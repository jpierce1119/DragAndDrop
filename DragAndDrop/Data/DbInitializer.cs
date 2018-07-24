using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DragAndDrop.Data
{
    public class DbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            for (int i = 0; i < 15; i++)
            {
                context.Tasks.Add(new Models.Task { Name = "Task " + (i + 1)});
            }

            for (int i = 0; i < 3; i++)
            {
                context.Users.Add(new Models.User { Name = "User " + (i + 1)});
            }

            context.SaveChanges();
        }
    }
}