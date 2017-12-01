namespace Assignment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AssignmentContext context)
        {
            context.Events.Add(new Models.Event { Name = "Name_1", Description = "Some Description", Status = Models.Enums.Status.Active, FromDate = DateTime.Now, ToDate = new DateTime(2017, 11, 30) });
            context.Events.Add(new Models.Event { Name = "Name_2", Description = "Some Description_1", Status = Models.Enums.Status.Active, FromDate = DateTime.Now, ToDate = new DateTime(2018, 2, 15) });
            context.Events.Add(new Models.Event { Name = "Name_3", Description = "Some Description_2", Status = Models.Enums.Status.Active, FromDate = DateTime.Now, ToDate = new DateTime(2017, 1, 5) });
            context.Events.Add(new Models.Event { Name = "Name_4", Description = "Some Description_3", Status = Models.Enums.Status.Active, FromDate = DateTime.Now, ToDate = new DateTime(2018, 2, 1) });
            context.Events.Add(new Models.Event { Name = "Name_5", Description = "Some Description_4", Status = Models.Enums.Status.Inactive, FromDate = DateTime.Now, ToDate = new DateTime(2017, 12, 15) });
            context.Events.Add(new Models.Event { Name = "Name_6", Description = "Some Description_5", Status = Models.Enums.Status.Inactive, FromDate = DateTime.Now, ToDate = new DateTime(2017, 12, 27) });
            context.Events.Add(new Models.Event { Name = "Name_7", Description = "Some Description_6", Status = Models.Enums.Status.Active, FromDate = DateTime.Now, ToDate = new DateTime(2017, 11, 30) });
        }
    }
}
