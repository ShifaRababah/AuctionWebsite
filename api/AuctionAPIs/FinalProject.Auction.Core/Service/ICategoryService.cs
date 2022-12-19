using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
    public interface ICategoryService
    {
        bool CreateCategory(Category category);
         List<Category> GetAllCategory();
         bool DeleteCategory(int id);
         bool UpdateCategory(Category category);




    }
}
