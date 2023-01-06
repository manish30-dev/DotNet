using BulkyBookRepo.Data;
using BulkyBookRepo.IRepo;
using BulkyBookRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBookRepo.Repo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ApplicationDbContext _db;



        public CategoryRepo(ApplicationDbContext db)
        {
            _db = db;
        }
         
        public Category Find(int id)
        {
            return _db.Categories.FirstOrDefault(c=>c.Id==id);
        }

        public void Create(Category category)
        {
            category.CreatedDate = DateTime.Now;
            _db.Categories.Add(category);
            _db.SaveChanges();
        }

        public IEnumerable<Category> Getall()
        {
            return _db.Categories.ToList();

        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            var category = Find(id);
            if(category != null) {_db.Categories.Remove(category); _db.SaveChanges(); }
        }
    }
}
