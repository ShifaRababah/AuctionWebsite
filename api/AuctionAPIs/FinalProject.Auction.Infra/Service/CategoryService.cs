using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository _categoryRepository)
        {

            categoryRepository = _categoryRepository;



        }
       public bool CreateCategory(Category category)
        { return categoryRepository.CreateCategory(category); }

        public List<Category> GetAllCategory()
        { return categoryRepository.GetAllCategory(); }

        public bool DeleteCategory(int id)
        { return categoryRepository.DeleteCategory(id); }

        public bool UpdateCategory(Category category)
        { return categoryRepository.UpdateCategory(category); }


    }
}

