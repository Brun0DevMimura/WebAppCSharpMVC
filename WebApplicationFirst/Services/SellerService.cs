using System.Collections.Generic;
using System.Linq;
using WebApplicationFirst.Data;
using WebApplicationFirst.Models;

namespace WebApplicationFirst.Services
{
    public class SellerService
    {
        private readonly WebApplicationFirstContext _context;

        public SellerService(WebApplicationFirstContext context) 
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
