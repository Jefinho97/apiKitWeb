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
    public class KitNetsController : ControllerBase
    {
        // GET api/kitnets
        [HttpGet]
        public ActionResult Get([FromServices]KitWebsDbContext context)
        {
            return Ok(context.KitNets);
        }

        // GET api/kitnets/5
        [HttpGet("{id}")]
        public ActionResult Get([FromServices]KitWebsDbContext context, int id)
        {
            var kitnet = context.KitNets.Where(x => x.KitNetId == id);
            return Ok(kitnet);
        }

        // POST api/kitnets
        [HttpPost]
        public IActionResult Post([FromServices]KitWebsDbContext context, [FromBody] KitNet kitNet)
        {
            context.KitNets.Add(kitNet);
            context.SaveChanges();
            return Ok(new { message = "KitNet Cadastrada com sucesso" });
        }



        // PUT api/kitnets/5
        [HttpPut]
        public IActionResult Put([FromServices]KitWebsDbContext context, [FromBody] KitNet kitNet)
        {
            context.Entry<KitNet>(kitNet).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Ok(new { message = "Alterado com sucesso" });
        }

        // DELETE api/kitnets/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices]KitWebsDbContext context, int id)
        {
            var kitNet = context.KitNets.First(x => x.KitNetId == id);

            context.Entry<KitNet>(kitNet).State =
                Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return Ok(new { message = "Excluido com sucesso" });
        }
    }
}