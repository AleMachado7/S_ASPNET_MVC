﻿using Microsoft.EntityFrameworkCore;
using SalesMVC.Data;
using SalesMVC.Models;

namespace SalesMVC.Services.Sellers
{
    public class SellerService : ISellerService
    {
        private readonly SalesMVCContext _context;
        public SellerService(SalesMVCContext context)
        {
            _context = context;
        }

        public Seller FindById(Guid id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
