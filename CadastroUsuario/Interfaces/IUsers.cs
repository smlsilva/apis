using cadastro.model.UserModel;
using cadastro.viewmodal.userview;
namespace cadastro.itf.users;
public interface IUsers {

    // GET
    List<UserModel> GetUsers();
    // POST
    void PostUser(UserModel userModel);
    // PUT
    void UpdateUser(UserModel userModel);
    // DELETE
    void DeleteUser(UserModel userModel);

}