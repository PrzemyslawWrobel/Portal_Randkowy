using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortalRandkowy.API.Data;
using PortalRandkowy.API.Models;

namespace PortalRandkowy.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }

        // Get api/values
        [HttpGet]
        public IActionResult Get()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }

        // Get api/values/6
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(value);
        }

        //Post api/values
        [HttpPost]
        public IActionResult AddValue([FromBody] Value value)
        {
            this._context.Values.Add(value);
            this._context.SaveChanges();
            return Ok(value);
        }

        // Put api/value/6
        [HttpPut("{id}")]
        public IActionResult EditValue(int id, [FromBody] Value value)
        {
            var data = this._context.Values.Find(id);
            data.Name = value.Name;
            this._context.Update(data);
            this._context.SaveChanges();
            return Ok(data);
        }

        // Delete api/value/6
        [HttpDelete("{id}")]
        public IActionResult DeleteValue(int id)
        {
            var data = this._context.Values.Find(id);
            this._context.Remove(data);
            this._context.SaveChanges();
            return Ok(data);

        }

        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        // private readonly ILogger<ValuesController> _logger;

        // public ValuesController(ILogger<ValuesController> logger)
        // {
        //     _logger = logger;
        // }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }
    }
}