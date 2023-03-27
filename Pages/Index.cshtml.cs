using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProAgricaTest.Data;
using ProAgricaTest.DTO;
using ProAgricaTest.Models;
using ProAgricaTest.Services;
using System.Runtime.InteropServices;

namespace ProAgricaTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IVisitorsService _service;        

        //To Do :  add DTO models and map that to the DB models and pass to UI
        public IEnumerable<UKVisitor> UKVisitors { get; set; } = Enumerable.Empty<UKVisitor>();

        public IndexModel(IVisitorsService service)
        {
            _service = service;
        }

        public async Task OnGet()
        {            
            UKVisitors = _service.GetUkVisitorList();
        }
    }
}