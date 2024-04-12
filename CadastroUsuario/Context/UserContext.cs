using cadastro.connection;
using cadastro.itf.users;
using cadastro.model.UserModel;
using cadastro.viewmodal.userview;

public class UserContext : IUsers {

    ConnectionContext _connection = new ConnectionContext();

    public void DeleteUser(UserModel userModel)
    {
        _connection.UserModal.Remove(userModel);
        _connection.SaveChanges();
    }

    public List<UserModel> GetUsers()
    {
        return _connection.UserModal.ToList();
    }

    public void PostUser(UserModel userModel)
    {
        _connection.UserModal.Add(userModel);
    }

    public void UpdateUser(UserModel userModel)
    {
        _connection.UserModal.Update(userModel);
    }
}