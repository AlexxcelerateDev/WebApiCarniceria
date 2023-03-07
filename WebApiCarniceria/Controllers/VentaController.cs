using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCarniceria.Carniceria;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/venta")]
    public class VentaController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public VentaController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Venta>>> Get()
        {
            return await dbContext.Ventas.Include(x => x.cliente).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Venta>> GetById(int id)
        {
            return await dbContext.Ventas.FirstOrDefaultAsync(x => x.Id_venta == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Venta venta)
        {
            var existeCliente = await dbContext.Clientes.AnyAsync(x => x.Id_cliente == venta.Id_cliente);

            if (!existeCliente)
            {
                return BadRequest($"No existe el Cliente con el id: {venta.Id_cliente}");
            }

            dbContext.Add(venta);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] //api/ventas/1
        public async Task<ActionResult> Put(Venta venta, int id)
        {
            var exist = await dbContext.Ventas.AnyAsync(x => x.Id_venta == id);

            if(!exist)
            {
                return NotFound("La venta especificada no existe. ");
            }

            if (venta.Id_venta != id)
            {
                return BadRequest("El id del cliente no coincide con el establecido en la url. ");
            }
            dbContext.Update(venta);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Ventas.AnyAsync(x => x.Id_venta == id);
            if (!exist)
            {
                return NotFound("El recurso no fue encontrado. ");
            }
            dbContext.Remove(new Venta()
            {
                Id_venta = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
