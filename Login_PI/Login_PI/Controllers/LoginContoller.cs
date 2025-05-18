using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Login_PI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        // Lista simulada de usuários (em memória)
        private static readonly List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario { Username = "admin", Password = "1234" },
            new Usuario { Username = "user1", Password = "senha1" },
            new Usuario { Username = "user2", Password = "senha2" }
        };

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var usuarioValido = Usuarios.FirstOrDefault(u =>
                u.Username == request.Username && u.Password == request.Password);

            if (usuarioValido != null)
            {
                return Ok(new { message = $"Login bem-sucedido. Bem-vindo, {usuarioValido.Username}!" });
            }

            return Unauthorized(new { message = "Usuário ou senha inválidos." });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
