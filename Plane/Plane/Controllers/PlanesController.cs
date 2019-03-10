using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Plane.Models;

namespace Plane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesController : ODataController
    {
        private readonly PlaneDbContext _planeDbContext;
        public PlanesController(PlaneDbContext planeDbContext)
        {
            _planeDbContext = planeDbContext;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_planeDbContext.Planes);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_planeDbContext.Planes.FirstOrDefault(c => c.Id == key));
        }

        [EnableQuery]
        public async Task<IActionResult> Post([FromBody]Plane plane)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _planeDbContext.Planes.Add(plane);
            await _planeDbContext.SaveChangesAsync();
            return Created(plane);
        }
    }
}


/*
 * // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
*/