using Microsoft.AspNetCore.Mvc;
using personnel_department_DB.Interfaces;

namespace personnel_department_course_work.Controllers
{
    public class PositionController : Controller
    {
        private IPositionsStorage positionsStorage;
        public PositionController(IPositionsStorage positionsStorage)
        {
            this.positionsStorage = positionsStorage;
        }
        public IActionResult Index()
        {
            var positions = positionsStorage.GetAll();
            return View(positions);
        }
    }
}
