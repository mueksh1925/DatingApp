using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoOne.Data;
using Microsoft.EntityFrameworkCore;

namespace demoOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valueController:ControllerBase
    {
        private readonly DataContext _context;
        public valueController(DataContext _context)
        {
            this._context=_context;
           // return 0
        }
        //Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValuesAsync()
        {
            var value=await _context.Values.ToListAsync();
            return Ok(value);
            //return new string[] {"value1","value2"};
        }
        //Public Get api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValuesAsync(int id)
        {
            var value=await _context.Values.FirstOrDefaultAsync(x=>x.id==id);
            return Ok(value);
           // return "value";
        }

        //Post api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        //Public Put api/values/5
        [HttpPut]
        public void Put(int id,[FromBody] string value)
        {

        }
        //public Delete api/values/5
        public void Delete(int id)
        {
            
        }
    }
}