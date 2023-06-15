using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using UtilityLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private const string filePath = "menu.json";
        // GET: api/Menu
        [HttpGet]
        public ActionResult<List<Menu>> Get()
        {
            return MenuManager.GetMenus();
        }
        [HttpGet("{nama}")]
        public ActionResult<Menu> GetMenuByNama(string nama)
        {
            Menu m = MenuManager.getmenusbyNama(nama);
            if (m != null)
            {
                return m;
            }
            else
            {
                return NotFound();
            }
        }
        // POST: api/Menu
        [HttpPost]
        public ActionResult Post([FromBody] Menu menu)
        {
            Contract.Requires(menu != null, "Menu object is null.");
            MenuManager.addmenu(menu);
            MenuManager.Serialize();

            return CreatedAtAction(nameof(Get), null);
        }

        // PUT: api/Menu
        [HttpPut("{nama}")]
        public ActionResult Put(string nama, [FromBody] Menu menu)
        {
            Contract.Requires(menu != null, "Menu object is null.");
            MenuManager.UpdateMenu(nama, menu);
            MenuManager.Serialize();

            return NoContent();
        }

        // DELETE: api/Menu
        [HttpDelete("{nama}")]
        public ActionResult Delete(string nama)
        {
            MenuManager.DeleteMenu(nama);
            MenuManager.Serialize();

            return NoContent();
        }
    }
}
