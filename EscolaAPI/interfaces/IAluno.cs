using escola.model.aluno;

public interface IAluno {

    List<AlunoModel> get();
    void add(AlunoModel AlunoModel);
    void deletar(AlunoModel AlunoModel);
    void atualizar(AlunoModel AlunoModel);

}