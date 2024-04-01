using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace escola.model.aluno;

[Table("tb_aluno")]
public class AlunoModel {

    [Key]
    public int? Id { get; private set; }
    public string? nome { get; private set; }
    public string? sobrenome { get; private set; }
    public int? idade { get; private set; }
    public decimal? nota { get; private set; }
    public string? turma { get; private set; }
    public AlunoModel(int? id, string? nome, string? sobrenome, int? idade, decimal? nota, string? turma) {

        this.Id = id;
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.idade = idade;
        this.nota = nota;
        this.turma = turma;

    }
}