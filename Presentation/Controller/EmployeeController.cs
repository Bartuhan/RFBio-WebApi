using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contrats;

namespace Presentation.Controller
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public EmployeeController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public ActionResult GetAllEmployee()
        {
            var employee = _manager.EmployeeManager.GetAllService(false);
            return Ok(employee);
        }

        [HttpGet("{id:int}")]
        public ActionResult GetEmployeeByID(int id)
        {
            try
            {
                var employee = _manager.EmployeeManager.GetByIDService(id, false);
                if (employee == null)
                    return NotFound();

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertEmployee(Employee employee)
        {
            try
            {
                if (employee is null)
                {
                    return BadRequest("Eklenecek Kayıt Bulunamadı . .");
                }
                _manager.EmployeeManager.CreateService(employee);

                return StatusCode(201, employee);
            }
            catch (Exception ex)
            {
                return BadRequest("Kayıt Eklenirken Bir Hata Oluştu . . . " + ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateEmployee(Employee employee, int id)
        {
            try
            {
                if (employee is null)
                    return BadRequest("Güncellenecek Kayıt Bulunamadı . .");

                _manager.EmployeeManager.UpdateService(employee, id, true);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest("Kayıt Güncellenirken Bir Hata Oluştu . . . " + ex.Message);
            }
        }

        [HttpDelete("${id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                if (id == null)
                    return BadRequest("Silinecek Kayıt Bulunamadı . .");

                _manager.EmployeeManager.DeleteService(id, false);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Kayıt Silinirken Bir Hata Oluştu . . ." + ex.Message);
            }
        }
    }
}