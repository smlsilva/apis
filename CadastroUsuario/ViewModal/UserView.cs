namespace cadastro.viewmodal.userview;
public class UserView {

    public int id { get; set; }
    public string? nome { get; private set; }
    public string? email { get; private set; }

    public UserView(int id, string? nome, string? email) {
        this.id = id;
        this.nome = nome;
        this.email = email;
    }
}