using escola.model.aluno;
using Microsoft.EntityFrameworkCore;

public class Connection : DbContext {

    public DbSet<AlunoModel> alunoModels { get; set; }
    public DbSet<SalaModel> salaModels { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured) {
            optionsBuilder.UseMySql("Server=localhost; User Id=root; Database=db_escola; Password=;", new MySqlServerVersion( new Version(10,4,32)));
        }
    }

}