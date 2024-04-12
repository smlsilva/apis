using cadastro.model.UserModel;
using Microsoft.EntityFrameworkCore;

namespace cadastro.connection;

class ConnectionContext : DbContext {

    public DbSet<UserModel> UserModal { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured) {
            optionsBuilder.UseMySql("Server=localhost; User Id=root; Database=db_cad; Password=;", new MySqlServerVersion( new Version(10, 4, 32)));
        }
    }

}