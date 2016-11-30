namespace PMS.Harrier.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model2 : DbContext
    {
        // Your context has been configured to use a 'Model2' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PMS.Harrier.DataAccessLayer.Model2' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model2' 
        // connection string in the application configuration file.
        public Model2()
            : base("name=Model2")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}