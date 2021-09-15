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
    [ApiController, Authorize]
    public class ClientsTelephonesController : ControllerBase
    {
        private readonly ITelephoneService telephoneService;

        public ClientsTelephonesController(ITelephoneService telephoneService)
        {
            this.telephoneService = telephoneService;
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(this.telephoneService.Get());
        //}

        [HttpGet("/api/clientstelephones")]
        public IActionResult GetById(string id)
        {
            return Ok(this.telephoneService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(TelephonesViewModel telephonesViewModel)
        {
            return Ok(this.telephoneService.Post(telephonesViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(this.telephoneService.Delete(id));
        }
    }
}
