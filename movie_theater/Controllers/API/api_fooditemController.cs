using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie_theater.iRepository;
using movie_theater.Models;

namespace movie_theater.Controllers.api_controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class api_fooditemController : ControllerBase
    {
        private readonly IfoodRepository _food;

        public api_fooditemController(IfoodRepository ifood)
        {
            _food = ifood;
        }

        //// GET: api/api_fooditem
        [HttpGet]
        public async Task<IEnumerable<FoodItem>> GetFood()
        {

            return await _food.GetFoodItems();
        }
        #region
        //// GET: api/api_fooditem/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<FoodItem>> GetFoodItem(int id)
        //{
        //    var foodItem = await _context.FoodItem.FindAsync(id);

        //    if (foodItem == null)
        //    {
        //        return NotFound();
        //    }

        //    return foodItem;
        //}

        //// PUT: api/api_fooditem/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFoodItem(int id, FoodItem foodItem)
        //{
        //    if (id != foodItem.FoodId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(foodItem).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FoodItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/api_fooditem
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<FoodItem>> PostFoodItem(FoodItem foodItem)
        //{
        //    _context.FoodItem.Add(foodItem);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (FoodItemExists(foodItem.FoodId))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetFoodItem", new { id = foodItem.FoodId }, foodItem);
        //}

        //// DELETE: api/api_fooditem/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<FoodItem>> DeleteFoodItem(int id)
        //{
        //    var foodItem = await _context.FoodItem.FindAsync(id);
        //    if (foodItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.FoodItem.Remove(foodItem);
        //    await _context.SaveChangesAsync();

        //    return foodItem;
        //}

        //private bool FoodItemExists(int id)
        //{
        //    return _context.FoodItem.Any(e => e.FoodId == id);
        //}
        #endregion
    }
}
