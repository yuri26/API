using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Efectura.Data.Model;
using Efectura.Data.DataContext;
using Efectura.API.Helper;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Efectura.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EfectraContext _context;
        public UserController(EfectraContext context)
        {
            _context = context;
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<Consumer>> Get()
        {
            var consumer = _context.Consumers.ToList();
            return await Task.FromResult(consumer);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<Consumer> Get(int id)
        {
            var consumer = _context.Consumers.FirstOrDefault(x => x.TCKN == id);
            return await Task.FromResult(consumer);

        }

        // POST api/<UserController>
        [HttpPost]
        public string Post(Consumer model)
        {
            try
            {
                TCKNGenerator creator = new TCKNGenerator();
                Consumer consumer = new Consumer();
                consumer.Name = model.Name;
                consumer.SurName = model.SurName;
                consumer.Adress = model.Adress;
                consumer.BirthDate = model.BirthDate;
                consumer.TCKN = creator.Creator();
                _context.Consumers.Add(consumer);
                _context.SaveChanges();
                return consumer.TCKN.ToString() + " Saved";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(Consumer model,int id)
        {
            var consumer = _context.Consumers.FirstOrDefault(x => x.TCKN == id);
            if (consumer != null)
            {
                consumer.Name = model.Name;
                consumer.SurName = model.SurName;
                consumer.BirthDate = model.BirthDate;
                consumer.Adress = model.Adress;
                consumer.ChangeDate = model.ChangeDate;
                _context.Consumers.Update(consumer);
                _context.SaveChanges();
            }

           

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<Consumer> Delete(int id)
        {        
            try
            {
                var consumer = _context.Consumers.FirstOrDefault(x => x.TCKN == id);
                if (consumer == null)
                {
                    return NotFound($"User with TCKN = {id} not found");
                }
                _context.Consumers.Remove(consumer);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK,
                    "record deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}
