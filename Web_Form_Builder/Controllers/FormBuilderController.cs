using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

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
            return View(_UnitOfWork.FormBuilder.GetAll());
        } 
        public IActionResult Create () 
        {
            return RedirectToAction(nameof(Index));
        }
        //Create paragraph Question and Ans
        [HttpPost]
        public IActionResult Create(FormBuilder form)  
      {      
            _UnitOfWork.FormBuilder.Add(form);         
            _UnitOfWork.Save();
            TempData["AlertMessage"] = "Questions Successfully Added";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        //Display all the Question at Ans. page
        public IActionResult Answer()
        {
            var formdata = _UnitOfWork.FormBuilder.GetAll();
            foreach(FormBuilder form in formdata)
            {
                form.Answer = "";
                form.Answer1 = "false";
                form.Answer2 = "false";
                form.Answer3 = "false";
                form.Answer4 = "false";
                form.Answer5 = "false";
                _UnitOfWork.FormBuilder.Update(form);
            }
            return View(formdata);
        }
        [HttpPost]
        //Update All the Selected Checkbox
        public IActionResult Answer(List<FormBuilder> formData)
            {
            foreach (FormBuilder form in formData)
            {
                FormBuilder forms = new FormBuilder();
                forms = form;
                if(form.Answer1 != "false")
                {
                    forms.Answer1 = form.Option1;
                }
                if (form.Answer2 != "false")
                {
                    forms.Answer2 = form.Option2;
                }
                if (form.Answer3 != "false")
                {
                    forms.Answer3 = form.Option3;
                }
                if (form.Answer4 != "false")
                {
                    forms.Answer4 = form.Option4;
                }
                if (form.Answer5 != "false")
                {
                    forms.Answer5 = form.Option4;
                }
                _UnitOfWork.FormBuilder.Update(forms);            
            }
            _UnitOfWork.Save();
            TempData["AlertMessage"] = "Questions Successfully Added";
            return RedirectToAction(nameof(Answer));
        }
        public IActionResult Review()
        {
            var reviews = _UnitOfWork.FormBuilder.GetAll();
            return View(reviews);
        }
    }
}




