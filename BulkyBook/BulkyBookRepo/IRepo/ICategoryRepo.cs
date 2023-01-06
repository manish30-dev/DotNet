using BulkyBookRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBookRepo.IRepo
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> Getall();
        void Create(Category category);
        void Update(Category category);
        Category Find(int id);
        void Delete(int id);



    }
}
