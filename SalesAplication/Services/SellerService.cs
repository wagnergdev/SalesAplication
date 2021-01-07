using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesAplication.Data;
using SalesAplication.Models;

namespace SalesAplication.SellerServices
{
    public class SellerService
    {
        private readonly SalesAplicationContext _context;

        public SellerService(SalesAplicationContext context)
        {
            _context = context;
        }
        
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
