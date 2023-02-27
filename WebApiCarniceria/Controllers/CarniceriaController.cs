using Microsoft.AspNetCore.Mvc;
using WebApiCarniceria.Carniceria;

namespace WebApiCarniceria.Controllers

{
    [ApiController]
    [Route("api/carniceria")]
    public class CarniceriaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Cliente>> Get() 
        {
            return new List<Cliente>()
            {
                new Cliente() {Id_cliente=1,Nombre = "Alex"},
                new Cliente(){Id_cliente=2, Nombre = "Arthur"}
            };
        }       

        /*
        public ActionResult<List<Cliente>> delete(int id)
        {
            return NoContent();
        }*/
    }
}
