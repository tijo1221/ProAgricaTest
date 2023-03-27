using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProAgricaTest.Data;
using ProAgricaTest.Models;
using ProAgricaTest.Services;

namespace ProAgricaTest.Pages
{
    public class AddNewModel : PageModel
    {
        private readonly IVisitorsService _service;      

        public AddNewModel(IVisitorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPost()
        {
            //To Do :  add DTO models and map that to the DB models and pass to service

            bool result = _service.SaveUKVisitorDetails(UKVisitor);

            if (result)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return RedirectToPage("/Error");  
            }          
        }

        [BindProperty]
        public UKVisitor UKVisitor { get; set; }
    }
}