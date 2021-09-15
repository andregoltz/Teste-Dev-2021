using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Application.Interfaces;
using Teste.Application.ViewModels;

namespace Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephonesController : ControllerBase
    {
        private readonly ITelephoneService telephoneService ;

        public TelephonesController(ITelephoneService telephoneService)
        {
            this.telephoneService = telephoneService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            this.telephoneService.Test();
            return Ok("Ok");
        }

        //[HttpPost]
        //public IActionResult Post(ClientViewModel clientViewModel)
        //{
        //    return Ok(this.clientService.Post(clientViewModel));
        //}

        //[HttpGet("/api/client")]
        //public IActionResult GetById(string id)
        //{
        //    return Ok(this.clientService.GetById(id));
        //}

        //[HttpPut]
        //public IActionResult Put(ClientViewModel clientViewModel)
        //{
        //    return Ok(this.clientService.Put(clientViewModel));
        //}


        //[HttpDelete("{id}")]
        //public IActionResult Delete(string id) 
        //{
        //    return Ok(this.clientService.Delete(id));
        //}
    }

}
