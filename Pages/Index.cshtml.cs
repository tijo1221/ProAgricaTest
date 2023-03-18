using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProAgricaTest.Data;
using ProAgricaTest.Models;

namespace ProAgricaTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UKVisitorsDBContext _context;

        //should add DTO models and map that to the DB models and pass to UI (I have focused on to get functionality, so didn't get much time to do all of these)

        public IEnumerable<UKVisitor> UKVisitors { get; set; } = Enumerable.Empty<UKVisitor>();

        public IndexModel(UKVisitorsDBContext context) => _context = context;   
                
        public async Task OnGet()
        {
            //more structured way is to add this code part to service leyer
            UKVisitors = await _context.UKVisitors.OrderByDescending(i => i.EntryDate).ToListAsync();
        }
    }
}