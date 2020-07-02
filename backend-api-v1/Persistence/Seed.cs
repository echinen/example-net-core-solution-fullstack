using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) 
        {
            if (!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Activity 1",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Descrip. of activity 1",
                        Category = "Category 1",
                        City = "Japan",
                        Venue = "Venue 1"
                    },
                    new Activity
                    {
                        Title = "Activity 2",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Descrip. of activity 2",
                        Category = "Category 2",
                        City = "China",
                        Venue = "Venue 2"
                    },
                    new Activity
                    {
                        Title = "Activity 3",
                        Date = DateTime.Now.AddMonths(-3),
                        Description = "Descrip. of activity 3",
                        Category = "Category 3",
                        City = "South Korea",
                        Venue = "Venue 3"
                    },
                    new Activity
                    {
                        Title = "Activity 4",
                        Date = DateTime.Now.AddMonths(-4),
                        Description = "Descrip. of activity 4",
                        Category = "Category 4",
                        City = "Singapore",
                        Venue = "Venue 4"
                    },
                    new Activity
                    {
                        Title = "Activity 5",
                        Date = DateTime.Now.AddMonths(-5),
                        Description = "Descrip. of activity 5",
                        Category = "Category 5",
                        City = "India",
                        Venue = "Venue 5"
                    },
                    new Activity
                    {
                        Title = "Activity 6",
                        Date = DateTime.Now.AddMonths(-6),
                        Description = "Descrip. of activity 6",
                        Category = "Category 6",
                        City = "Italy",
                        Venue = "Venue 6"
                    },
                    new Activity
                    {
                        Title = "Activity 7",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Descrip. of activity 7",
                        Category = "Category 7",
                        City = "Spain",
                        Venue = "Venue 7"
                    },
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}