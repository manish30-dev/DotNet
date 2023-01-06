using BulkyBookRepo.IRepo;
using BulkyBookRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBookService
{
    public class CategoryServ : ICategoryServ
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryServ(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public void Create(Category category)
        {
           _categoryRepo.Create(category);
        }

        public Category Find(int id)
        {
            return _categoryRepo.Find(id);
        }

        public IEnumerable<Category> Getall()
        {
            return _categoryRepo.Getall();
        }


        public void Update(Category category)
        {
            _categoryRepo.Update(category);
        }
        public void Delete(int id)
        {
            _categoryRepo.Delete(id);   
        }
    }
}
