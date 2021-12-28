using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        //CategoryRepository categoryRepository = new CategoryRepository();
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            //if (category.CategoryName != "" && category.CategoryDescription != "" && category.CategoryName.Length >= 5 && category.CategorySatatus == true)
            //{
            //    categoryRepository.AddCategory(category);
            //}
            //else
            //{
            //    //Hata Mesajı
            //    //Fluent Validation
            //}
            efCategoryRepository.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            //categoryRepository.AddCategory(category);
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            //categoryRepository.UpdateCategory(category);
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            //categoryRepository.GetById(id);
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            //categoryRepository.ListAllCategory();
            return efCategoryRepository.GetListAll();
        }
    }
}
