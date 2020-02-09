using System.Collections.Generic;
using api.ejercicio.DAO;
using api.ejercicio.DAO.DTO;
using Microsoft.AspNetCore.Mvc;

namespace api.ejercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<DriverDTO> Get()
        {
            var dao = new DriverDAO();
            return dao.GetAll();
        }
        
        [HttpPost]
        public void Create(DriverDTO driver)
        {
            var dao = new DriverDAO();
            dao.Save(driver);
        }

        [HttpDelete]
        public ActionResult Delete(DriverDTO driver)
        {
            var dao = new DriverDAO();
            var PudoEliminarElregistro = dao.Delete(driver);

            if (PudoEliminarElregistro)
                return Ok();
            else
                return BadRequest("todo mal");
        }

    }
}