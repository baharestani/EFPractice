using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFPractice.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly MyContext myContext;

        public ValuesController(MyContext myContext)
        {
            this.myContext = myContext ?? throw new ArgumentNullException(nameof(myContext));
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var books = await myContext.Book.Select(b => b.Title).ToListAsync();

            return books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
