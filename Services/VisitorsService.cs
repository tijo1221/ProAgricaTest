using ProAgricaTest.Data;
using ProAgricaTest.DTO;
using ProAgricaTest.Models;

namespace ProAgricaTest.Services
{
    public class VisitorsService : IVisitorsService
    {
        private readonly UKVisitorsDBContext _context;        

        public VisitorsService(UKVisitorsDBContext context)
        {
            _context = context;
        }

        public IEnumerable<UKVisitor> GetUkVisitorList()
        {
            return _context.UKVisitors.OrderByDescending(i => i.EntryDate).ToList();          
        }

        public bool SaveUKVisitorDetails(UKVisitor ukVisitor)
        {
            ukVisitor.Id = new Guid();
            ukVisitor.EntryApproved = true;

            try
            {
                _context.UKVisitors.Add(ukVisitor);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

    public interface IVisitorsService
    {
        IEnumerable<UKVisitor> GetUkVisitorList();

        bool SaveUKVisitorDetails(UKVisitor ukVisitor);
    }
}
