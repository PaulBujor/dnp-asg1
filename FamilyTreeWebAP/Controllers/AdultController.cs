using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyTreeWebAP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace FamilyTreeWebAP.Controllers
{
    [ApiController]
    [Route("api/Adults")]
    public class AdultController: ControllerBase
    
    {
        private readonly ILogger<AdultController> _logger;
        private IFileStorage _fileStorage = new FileStorage();

      
        public AdultController(ILogger<AdultController> logger)
        {
            _logger = logger;
          
        }

        //Gets adults from file on https://localhost:8081/api/adults
        [HttpGet]
        public async Task<ActionResult<List<Adult>>> Get()
        {
            try
            {
                List<Adult> adults = await _fileStorage.GetAdultsAsync();
                return adults;
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //Posts an adult on https://localhost:8081/api/adults/post
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("post")]
        public async Task<ActionResult<Adult>> AddAdult(Adult adult)
        {

            try
            {
                await _fileStorage.AddAdult(adult);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpDelete("{id}")]
       
        public IActionResult Delete([FromRoute] int id)
        {

            var cena = _fileStorage.Delete(id);
            
            if (cena)
            {
                return Ok();
            }else
            {
                return NotFound();
            }
        }

    }
}