using AutoMapper;
using Logicathon.Migrations;
using Microsoft.AspNetCore.Mvc;
using Logicathon.Models.Domain;
using Logicathon.Repository;
using System;
using System.Threading.Tasks;
using Logicathon.Models.DTO;

namespace Logicathon.Controllers
{
    #region UserRegisteration
    [Route("api/[controller]")]
    [ApiController]
    
    public class RegisterController : ControllerBase
    {
        private IUser _user;
        private readonly IMapper mapper;

        public RegisterController(IUser user, IMapper mapper)
        {
          
            _user = user;
            this.mapper = mapper;
        }
       
        [HttpPost]
        public async Task<IActionResult> AddLoginDetails(User loginTableDTO)
        {
            try
            {
                var employeeDTO = mapper.Map<Models.Domain.Login>(loginTableDTO);
                await _user.AddLoginDetailsAsync(employeeDTO);
                if (employeeDTO != null)
                {
                    return Ok("Success");

                }
                return Ok("Failure");
            }
            catch (Exception e)
            {
                return BadRequest("Error in Controller method AddLoginDetails" + e);
            }
            //return Ok(employeeDTO);
        }
    }
    #endregion
}
