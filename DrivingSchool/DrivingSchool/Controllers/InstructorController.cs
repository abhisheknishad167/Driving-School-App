
using InstructorCRUD.Models;
using InstructorCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using EmployeeCRUD.Models;

namespace InstructorCRUD.Controllers
{
    public class InstructorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InstructorController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Instructor> objCatlist = _context.Instructors;
            return View(objCatlist);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult rating()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Instructor empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Instructors.Add(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Instructor()
        {
            IEnumerable<Instructor> objCatlist = _context.Instructors;
            return View(objCatlist);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Instructors.Find(id);

            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instructor empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Instructors.Update(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Updated Successfully !";
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Instructors.Find(id);

            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(int? id)
        {
            var deleterecord = _context.Instructors.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.Instructors.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully !";
            return RedirectToAction("Index");
        }


    }
}