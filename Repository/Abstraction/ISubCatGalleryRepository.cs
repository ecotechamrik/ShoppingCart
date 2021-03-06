﻿using BAL.Entities;
using BAL.ViewModels;
using BAL.ViewModels.Product;
using System.Collections.Generic;

namespace Repository.Abstraction
{
    public interface ISubCatGalleryRepository : IRepository<SubCatGallery>
    {
        IEnumerable<SubCatGalleryViewModel> GetSubCatGallery();
        void DeleteBySubCategoryID(int SubCategoryID);
        void UpdateOrder(int SubCatGalleryID, int OrderNo);
        IEnumerable<SubCatGalleryViewModel> SetDefaultImage(int SubCatGalleryID, int SubCategoryID);
    }
}
