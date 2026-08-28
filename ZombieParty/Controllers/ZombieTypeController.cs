using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        // GET: ZombieTypeController
        public ActionResult Index()
        {
		this.ViewBag.MaListe = new List<ZombieType>()
    		{
   	     		new ZombieType(){TypeName= "Virus", Id=1},
        		new ZombieType(){TypeName= "Contact", Id=2}
    		};
        	return View();
        }

	public IActionResult Create()
	{
    		return View();
	}

	[HttpPost]
	public IActionResult Create(Models.ZombieType zombieType)
	{
		if (ModelState.IsValid)
		{
			// ajouter a db
		}

		return this.View(zombieType);
	}

    }
}
