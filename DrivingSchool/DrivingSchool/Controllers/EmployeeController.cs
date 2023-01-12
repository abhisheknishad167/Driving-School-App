using EmployeeCRUD.Models;
using InstructorCRUD.Data;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchool.Controllers
{
    public class EmployeeController : Controller

    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> objCatlist = _context.Employee;
            return View(objCatlist);
        }
        public IActionResult CARS()
        {
            return View();
        }

        public IActionResult Student()
        {
            IEnumerable<Employee> objCatlist = _context.Employee;
            return View(objCatlist);
        }
        public IActionResult rating()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Employee.Add(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Employee.Find(id);

            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Employee.Update(empobj);
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
            var empfromdb = _context.Employee.Find(id);

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
            var deleterecord = _context.Employee.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.Employee.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully !";
            return RedirectToAction("Index");
        }
    }
}
