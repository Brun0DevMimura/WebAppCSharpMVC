using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFirst.Data;
using WebApplicationFirst.Models;

namespace WebApplicationFirst.Services
{
    public class DepartamentService
    {
        private readonly WebApplicationFirstContext _context;

        public DepartamentService(WebApplicationFirstContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {

            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
