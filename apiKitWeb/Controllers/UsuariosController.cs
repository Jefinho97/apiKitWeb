using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiKitWeb.Context;
using apiKitWeb.Entity;

namespace apiKitWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // GET api/kitnets
        [HttpGet]
        public ActionResult Get([FromServices]KitWebsDbContext context)
        {
            return Ok(context.Usuarios);
        }

        // GET api/usuarios/5
        [HttpGet("{id}")]
        public ActionResult Get([FromServices]KitWebsDbContext context, int id)
        {
            var usuario = context.Usuarios.Where(x => x.UsuarioId == id);
            return Ok(usuario);
        }

        // POST api/usuarios
        [HttpPost]
        public IActionResult Post([FromServices]KitWebsDbContext context, [FromBody] Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            return Ok(new { message = "Usuario Cadastrado com sucesso" });
        }

        // PUT api/usuarios/5
        [HttpPut]
        public IActionResult Put([FromServices]KitWebsDbContext context, [FromBody] Usuario usuario)
        {
            context.Entry<Usuario>(usuario).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Ok(new { message = "Alterado com sucesso" });
        }

        // DELETE api/usuarios/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices]KitWebsDbContext context, int id)
        {
            var usuario = context.Usuarios.First(x => x.UsuarioId == id);

            context.Entry<Usuario>(usuario).State =
                Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return Ok(new { message = "Excluido com sucesso" });
        }
    }
}