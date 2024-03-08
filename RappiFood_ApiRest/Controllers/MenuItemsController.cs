using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RappiFood_ApiRest.Data;
using RappiFood_ApiRest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RappiFood_ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly RappiFoodDbContext _context;

        public MenuItemsController(RappiFoodDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuRappiFood>>> GetMenuItems()
        {
            return await _context.MenuRappiFoods.ToListAsync();
        }

        // POST: api/MenuItems
        [HttpPost]
        public async Task<ActionResult<MenuRappiFood>> PostMenuItem(MenuRappiFood menuItem)
        {
            _context.MenuRappiFoods.Add(menuItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuItem", new { id = menuItem.IdFood }, menuItem);
        }
    }
}