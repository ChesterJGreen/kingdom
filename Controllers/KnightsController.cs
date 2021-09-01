using System;
using System.Collections.Generic;
using kingdom.Models;
using kingdom.Services;
using Microsoft.AspNetCore.Mvc;
namespace kingdom.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class KnightsController : ControllerBase
    {
        private readonly KnightsService _knightsService;
        public KnightsController(KnightsService knightsService)
        {
            _knightsService = knightsService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Knight>> Get()
        {
            try
            {
                 IEnumberable<Knight> knights = _knightsService.Get();
                 return Ok(knights);
            }
            catch (Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
    }
}