using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyTreeWebAP.Data;
using FamilyTreeWebAP.Data.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace FamilyTreeWebAP.Controllers
{
    [ApiController]
    [Route("api/Adults")]
    public class AdultController : ControllerBase

    {
        private readonly ILogger<AdultController> _logger;
        private IFileStorage _fileStorage = new FileStorage();
        private IAdultRepo _adultRepo;


        public AdultController(ILogger<AdultController> logger, IAdultRepo adultRepo)
        {
            _logger = logger;
            _adultRepo = adultRepo;

        }

        //Gets adults from file on https://localhost:8081/api/adults
        //Get adults from API now
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> Get()
        {
            try
            {
                List<Adult> adults = await _fileStorage.GetAdultsAsync();
                IList<Adult> _adults = (List<Adult>)await _adultRepo.GetAllAdultsAsync();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _fileStorage.AddAdult(adult);
                await _adultRepo.CreateAdultAsync(adult);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            try
            {
                await _adultRepo.DeleteAdultAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }

            var cena = _fileStorage.Delete(id);

            if (cena)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}