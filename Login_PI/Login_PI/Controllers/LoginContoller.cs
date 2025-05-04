using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Login_PI.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {   // Usuario defult por enquanto esperando o BD
            if(request.Username == "admin" && request.Password == "1234")
            {
                return Ok(new { message = "Login realizado com sucesso!" });

            }
            return Unauthorized(new { message = "Usuario ou senha inválidos." });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}