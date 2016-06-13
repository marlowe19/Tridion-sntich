using Tridion.Snitch.Application.library;
using System;
using System.Data.Entity;
using System.Linq;
namespace Tridion.Snitch.Application.communication
{
 

    public class SnitchDb : DbContext
    {
        // Your context has been configured to use a 'SnitchDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Tridion.Snitch.Application.communication.SnitchDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SnitchDb' 
        // connection string in the application configuration file.
        public SnitchDb()
            : base("name=SnitchDb.cs")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAction> UserAction { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

}