using escola.model.aluno;
namespace escola.context.aluno;
public class AlunoContext : IAluno {

    Connection _connection = new Connection();

    public void add(AlunoModel AlunoModel)
    {
        _connection.alunoModels.Add(AlunoModel);
        _connection.SaveChanges();
    }

    public void atualizar(AlunoModel AlunoModel)
    {
        _connection.alunoModels.Update(AlunoModel);
        _connection.SaveChanges();
    }

    public void deletar(AlunoModel AlunoModel)
    {
        _connection.alunoModels.Remove(AlunoModel);
        _connection.SaveChanges();
    }

    public List<AlunoModel> get()
    {
        return _connection.alunoModels.ToList();
    }
}