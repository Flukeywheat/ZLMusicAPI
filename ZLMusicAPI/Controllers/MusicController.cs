using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZLMusicAPI.Controllers
{
    [Route("music")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        // GET: api/Music
        [HttpGet]
        public FileContentResult Get()
        {
            var bytes = System.IO.File.ReadAllBytes("testFiles/dru-01.wav");
            var test = Convert.ToBase64String(bytes);
            
            return File(bytes, "audio/wav");
        }

        // GET: api/Music/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Music
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Music/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
