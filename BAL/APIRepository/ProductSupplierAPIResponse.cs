﻿#region [ Namespace ]
using BAL.ViewModels.Product;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace BAL
{
    public class ProductSupplierAPIResponse: GenerateAPIResponse<ProductSupplierViewModel>, IProductSupplierAPIResponse
    {
        #region [ Local Variables ]
        // Get API URL from appsettings.json
        IConfiguration config;

        // HttpClient Variable to access the Web APIs
        HttpClient client;
        #endregion

        #region [ Default Constructor  ]
        public ProductSupplierAPIResponse(IConfiguration _config) : base(_config)
        {
            client = new HttpClient();
            config = _config;
            client.BaseAddress = new Uri(config["URL:API"]);
        }
        #endregion

        #region [ Save Entity ]
        /// <summary>
        /// Save Entity Record into DB
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <returns></returns>
        public async Task<ProductSupplierViewModel> SaveModel(String apiMethod, ProductSupplierViewModel entity)
        {
            string entitydata = JsonConvert.SerializeObject(entity);
            StringContent content = new StringContent(entitydata, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(client.BaseAddress + apiMethod, content);

            ProductSupplierViewModel model = new ProductSupplierViewModel();
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<ProductSupplierViewModel>(data);
            }

            return model;
        }
        #endregion
    }
}