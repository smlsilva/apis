
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tb_salas")]
public class SalaModel {

    [Key]
    public int? Id { get; set; }

    public string? turma { get; private set; }

    public SalaModel(int? Id, string? turma) {
        this.Id = Id;
        this.turma = turma;
    }
}