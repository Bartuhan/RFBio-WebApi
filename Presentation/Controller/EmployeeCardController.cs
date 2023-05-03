using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.EF_Core;
using Services.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    [ApiController]
    [Route("api/employeeCard")]
    public class EmployeeCardController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public EmployeeCardController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllEmployeeCard()
        {
            var employeeCard = _manager.EmployeeCardService.GetAllService(false);
            return Ok(employeeCard);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetEmployeeCardByID(int id)
        {
            try
            {
                var employeeCard = _manager.EmployeeCardService.GetByIDService(id,false);

                if (employeeCard is null)
                    return NotFound();

                return Ok(employeeCard);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertEmployeeCard(EmployeeCard employeeCard)
        {
            try
            {
                if (employeeCard is null)
                    return NotFound();

                _manager.EmployeeCardService.CreateService(employeeCard);
                return StatusCode(201 , employeeCard);
            }
            catch (Exception ex )
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateEmployeeCard(EmployeeCard employee, int id)
        {
            if (employee is null)
                return NotFound();

            _manager.EmployeeCardService.UpdateService(employee, id, true);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployeeCard( int id)
        {
            try
            {
                _manager.EmployeeCardService.DeleteService(id, false);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
