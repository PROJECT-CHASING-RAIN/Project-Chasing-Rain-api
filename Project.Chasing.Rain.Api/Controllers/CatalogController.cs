using Microsoft.AspNetCore.Mvc;
using Project.Chasing.Rain.Domain.Catalog;
using Project.Chasing.Rain.Data;
using Microsoft.EntityFrameworkCore;

namespace Project.Chasing.Rain.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        // Constructor to initialize the database context
        public CatalogController(StoreContext db)
        {
            _db = db;
        }

        // GET: /catalog
        // Retrieves all items from the database
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_db.Items);
        }

        // GET: /catalog/{id}
        // Retrieves a specific item by its ID
        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: /catalog
        // Adds a new item to the catalog
        [HttpPost]
        public IActionResult Post(Item item)
        {
            // Example response with a hardcoded location (replace with actual logic)
            _db.Items.Add(item);
            _db.SaveChanges();
            return Created($"/catalog/{item.Id}", item);
        }

        // POST: /catalog/{id}/ratings
        // Adds a rating to a specific item
        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            item.AddRating(rating);
            _db.SaveChanges();

            return Ok(item);
        }

        // PUT: /catalog/{id}
        // Updates an existing item in the catalog
        [HttpPut("{id:int}")]
        public IActionResult PutItem(int id, Item item)
        {
            if(id != item.Id)
            {
                return BadRequest();
            }

            if (_db.Items.Find(id) == null)
            {
                return NotFound();
            }

            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();

            return NoContent();
        }

        // DELETE: /catalog/{id}
        // Deletes an item from the catalog
        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            _db.Items.Remove(item);
            _db.SaveChanges();

            return Ok();
        }
    }
}