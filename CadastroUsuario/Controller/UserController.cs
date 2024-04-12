using cadastro.itf.users;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/v1/api/users/")]
public class UserController : ControllerBase {

    private readonly IUsers _user;

    public UserController(IUsers users) {
        this._user = users;
    }
    
    [HttpGet]
    public IActionResult Get() {
        return Ok(_user.GetUsers());
    }
    
    [HttpPost]
    public IActionResult Post() {
        return Ok();
    }

    [HttpPut]
    public IActionResult Put() {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete() {
        return Ok();
    }

}