using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastro.model.UserModel;

[Table("tb_users")]
public class UserModel {

    [Key]
    public int id { get; set; }
    public string? nome { get; private set; }
    public string? email { get; private set; }

    public UserModel(int id, string? nome, string? email) {
        this.id = id;
        this.nome = nome;
        this.email = email;
    }
}