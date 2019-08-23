using Animal_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Animal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private Animal_APIContext _db = new Animal_APIContext();

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return _db.Animals.ToList();
        }

        // GET api/animals/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(x => x.AnimalId == id);
        }

        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            animal.Age = Math.Round((((DateTime.Now - animal.Birthdate).TotalDays) / 365), 1);
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }

        // PUT api/animals/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            animal.AnimalId = id;
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/animals/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animalToDelete = _db.Animals.FirstOrDefault(x => x.AnimalId == id);
            _db.Animals.Remove(animalToDelete);
            _db.SaveChanges();
        }
    }
}
