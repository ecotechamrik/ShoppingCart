﻿using BAL.Entities;
using BAL.ViewModels.Product;
using System.Collections.Generic;

namespace Repository.Abstraction
{
    public interface IProductImageRepository : IRepository<ProductImage>
    {
        IEnumerable<ProductImageViewModel> GetProductImages();
        void DeleteByProductID(int ProductID);
        void UpdateOrder(int ProductImageID, int OrderNo);
        IEnumerable<ProductImageViewModel> SetDefaultImage(int ProductImageID, int ProductID);
    }
}
