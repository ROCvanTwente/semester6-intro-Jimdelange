using CSHARP2;
using Microsoft.AspNetCore.Mvc;

namespace csharp_mvc.Controllers
{
    public class ShapeController : Controller
    {
        private static List<IShapes> shapes = new List<IShapes>
        {
            new Rectangle(0, 0), // Voorbeeld van een rechthoek
            new Circle(50)       // Voorbeeld van een cirkel met een oppervlakte van 50
        };

        public IActionResult Index()
        {
            return View(shapes);
        }

        public IActionResult VeranderGrootte(int id)
        {
            if (id < 0 || id >= shapes.Count)
                return NotFound();

            shapes[id].VeranderGrootte(1);
            return RedirectToAction("Index");
        }

        public IActionResult VeranderKleiner(int id)
        {
            if (id < 0 || id >= shapes.Count)
                return NotFound();

            shapes[id].VeranderKleiner(1);
            return RedirectToAction("Index");
        }

        public IActionResult ShowOppervlakte(int id)
        {
            if (id < 0 || id >= shapes.Count)
                return NotFound();

            ViewBag.Message = shapes[id].OppervlakteWeergeven();
            return View("Index", shapes);
        }

        public IActionResult ShowOmtrek(int id)
        {
            if (id < 0 || id >= shapes.Count)
                return NotFound();

            var omtrek = shapes[id].BerekenOmtrek();
            ViewBag.OmtrekMessage = $"De omtrek is {omtrek}";
            return View("Index", shapes);
        }
    }
}
