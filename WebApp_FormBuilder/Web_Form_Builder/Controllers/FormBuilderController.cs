using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
namespace Web_Form_Builder.Controllers
{
    public class FormBuilderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _UnitOfWork;
        public FormBuilderController(IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
           _UnitOfWork= unitOfWork;
            _context= context;
        }
        public IActionResult Index()
        {
           
            return View();
        } 
        public IActionResult Create () 
        {
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FormBuilder form)
        {
            if (ModelState.IsValid)
            {
                _UnitOfWork.FormBuilder.Add(form);
            }
            _UnitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult Answer()
        {
            return View(_UnitOfWork.FormBuilder.GetAll());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Answer(FormBuilder formData)
        {
            FormBuilder form = new FormBuilder();
            form = formData;
            _UnitOfWork.FormBuilder.Update(form);
            _UnitOfWork.Save();
            return RedirectToAction(nameof(Answer));
        }
        public IActionResult Review()
        {
            var reviews = _UnitOfWork.FormBuilder.GetAll();
            return View(reviews);
        }


    }
}




