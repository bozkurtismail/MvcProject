using Business.Abstract;
using DataAccess.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        GenericRepository<Category> genericRepository = new GenericRepository<Category>();
        public void Add(Category category)
        {
            if(category.CategoryName==""||category.CategoryName.Length<=3||category.CategoryDescription==""||category.CategoryName.Length>51)
            {
                //hata mesajı
            }
            else
            {
                genericRepository.Insert(category);
            }
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return genericRepository.List();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
