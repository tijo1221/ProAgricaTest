using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProAgricaTest.Data;
using ProAgricaTest.Models;

namespace ProAgricaTest.Pages
{
    public class AddNewModel : PageModel
    {
        private readonly UKVisitorsDBContext _context;

        public IEnumerable<UKVisitor> UKVisitors { get; set; } = Enumerable.Empty<UKVisitor>();

        public AddNewModel(UKVisitorsDBContext context) => _context = context;

        public async Task<IActionResult> OnPost()
        {
            //more structured way is to add this code part to service leyer

            UKVisitor.Id = new Guid();
            UKVisitor.EntryApproved = true;

            try
            {
                 _context.UKVisitors.Add(UKVisitor);
                 await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {

            }

            return RedirectToPage("/Index");
        }

        [BindProperty]
        public UKVisitor UKVisitor { get; set; }
    }
}