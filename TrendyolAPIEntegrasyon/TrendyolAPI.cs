﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolAPIEntegrasyon
{
    internal class TrendyolAPI : APICall
    {
        private HttpClient _httpClient;
        private string supplierId = "supplier Id";
        private string apiKey = "API_KEY";
        private string apiSecretKey = "API_SECRET_KEY";

        /// <summary>
        /// Constructor for API calls
        /// </summary>
        public TrendyolAPI()
        {
            TrendyolAuth trendyolAuth = new TrendyolAuth(apiKey, apiSecretKey, supplierId);
            _httpClient = trendyolAuth.Result();
        }

        /// <summary>
        /// Call for Trendyol category's attributes
        /// </summary>
        public void GetAttributes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call for Trendyol brands
        /// </summary>
        public void GetBrands()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call for Trendyol categories
        /// </summary>
        public void GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
