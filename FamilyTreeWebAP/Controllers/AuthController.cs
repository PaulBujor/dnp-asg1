using System;
using System.Threading.Tasks;
using FamilyTree.Data.Models;
using FamilyTreeWebAP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FamilyTreeWebAP.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController: ControllerBase
    {


        private readonly ILogger<AuthController> _logger;
        private IFileStorage _fileStorage = new FileStorage();
        private IAuthorize _authorize = new Authorize();


        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
     
        [HttpGet("/{username}/{password}")]
        
        public async Task<ActionResult<User>> Get(string username, string password)
        {
            User user = await _authorize.ValidateUser(username, password);
            if (user != null)
            {
                return user;
            }

            return BadRequest();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("/{username}/{password}")]
        public async Task<ActionResult<User>> Register(string username, string password)
        {
            try
            {
                 _authorize.RegisterUser(username, password);
                
            }
            catch (ArgumentException e)
            {
                
                return BadRequest();
            }
            return Ok();
        }
      
    }
}