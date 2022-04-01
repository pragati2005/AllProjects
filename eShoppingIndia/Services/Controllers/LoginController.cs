using Entities;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Repository.Abstraction;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IUnitOfWork _unitofwork;
        public LoginController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        
        // GET: api/<ValuesController>
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
            // GET api/<ValuesController>/5
           [HttpPost]
            public async Task AddRoles(Roles item)
            {
        await _unitofwork.RolesRepository.Add(item);
            }

            // POST api/<ValuesController>
            [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(model.Username==null)
            {
                return NotFound("username does not exist");
            }

            else if (model.Password== null)
            {
                return NotFound("Null Password does");
            }
            else
            {
                var userobj= _unitofwork.AuthenticateRepository.ValidateUser(model);
                return Ok(userobj);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
