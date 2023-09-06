using Microsoft.AspNetCore.Mvc;
using personnel_department_course_work.Models;
using personnel_department_DB.Interfaces;
using personnel_department_DB.Models;

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

        public IActionResult Add() { return View(); }
        [HttpPost]
        public IActionResult Add(PositionViewModel position)
        {
            
            positionsStorage.Add(new Position { Id=Guid.NewGuid(),Name=position.Name});
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Guid id)
        {
            var position= positionsStorage.GetById(id);
            return View(new PositionViewModel { Id=position.Id,Name=position.Name});
        }
        [HttpPost]
        public IActionResult Edit(PositionViewModel position) 
        {
            positionsStorage.Edit(new Position { Id = position.Id, Name = position.Name });
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            positionsStorage.Delete(id);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
