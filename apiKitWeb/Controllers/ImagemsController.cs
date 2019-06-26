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
    public class ImagemsController : ControllerBase
    {
        // GET api/imagems
        [HttpGet]
        public ActionResult Get([FromServices]KitWebsDbContext context)
        {
            return Ok(context.Imagems);
        }

        // GET api/imagems/5
        [HttpGet("{id}")]
        public ActionResult Get([FromServices]KitWebsDbContext context, int id)
        {
            var imagem = context.Imagems.Where(x => x.ImagemId == id);
            return Ok(imagem);
        }

        // POST api/imagems
        [HttpPost]
        public IActionResult Post([FromServices]KitWebsDbContext context, [FromBody] Imagem imagem)
        {
            context.Imagems.Add(imagem);
            context.SaveChanges();
            return Ok(new { message = "Imagem Cadastrada com sucesso" });
        }



        // PUT api/imagems/5
        [HttpPut]
        public IActionResult Put([FromServices]KitWebsDbContext context, [FromBody] Imagem imagem)
        {
            context.Entry<Imagem>(imagem).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Ok(new { message = "Alterado com sucesso" });
        }

        // DELETE api/imagems/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices]KitWebsDbContext context, int id)
        {
            var imagem = context.Imagems.First(x => x.ImagemId == id);

            context.Entry<Imagem>(imagem).State =
                Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return Ok(new { message = "Excluido com sucesso" });
        }
    }
}