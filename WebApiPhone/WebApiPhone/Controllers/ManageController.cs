using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPhone.Models;
using WebApiPhone.Services;
using WebApiPhone.Services.Interface;

namespace WebApiPhone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageController : ControllerBase
    {
        private readonly IProvider _provider;
        public ManageController(IProvider context)
        {
            _provider = context;
        }

        [HttpGet]
        public async Task<ActionResult<Dictionary<int, Phone>>> Get()
        {
            return await Task.Run(() => _provider.Get());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Phone>> Get(int id)
        {
            var phone = await Task.Run(() => _provider.Get(id));
            if (phone == null)
            {
                return NotFound();
            }

            return new ObjectResult(phone);
        }

        [HttpPost]
        public async Task<ActionResult<Phone>> Post([FromBody] Phone phone)
        {
            if (phone == null)
            {
                return BadRequest();
            }

            await Task.Run(() => _provider.Post(phone));
            return Ok(phone);
        }

        [HttpPut]
        public async Task<ActionResult<Phone>> Put(int id, Phone phone)
        {
            if (phone == null)
            {
                return BadRequest();
            }

            await Task.Run(() => _provider.Put(id, phone));
            return Ok(phone);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Phone>> Delete(int id)
        {
            var phone = _provider.Get().Keys.Any(x => x == id);
            if (!phone)
            {
                return NotFound();
            }

            await Task.Run(() => _provider.Delete(id));
            return Ok(phone);
        }
    }
}
