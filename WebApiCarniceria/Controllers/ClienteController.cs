using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCarniceria.Carniceria;

namespace WebApiCarniceria.Controllers

{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public ClienteController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Cliente>>> Get() 
        {
            return await dbContext.Clientes.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(Cliente cliente)
        {
            dbContext.Add(cliente);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] //api/clientes/1

        public async Task <ActionResult> Put(Cliente cliente,int id)
        {
            if(cliente.Id_cliente != id)
            {
                return BadRequest("El id del cliente no coincide con el establecido en la url");
            }
            dbContext.Update(cliente);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Clientes.AnyAsync(x => x.Id_cliente == id);
            if(!exist)
            {
                return NotFound("El recurso no fue encontrado. ");
            }
            dbContext.Remove(new Cliente()
            {
                Id_cliente = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
        /*
        public ActionResult<List<Cliente>> delete(int id)
        {
            return NoContent();
        }*/
    }
}
