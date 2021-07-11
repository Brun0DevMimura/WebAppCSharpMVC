using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFirst.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }

    }
}
