using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolAPIEntegrasyon
{
    internal class APIEndpoint
    {
        public string endpoint_cat = "/sapigw/product-categories";

        public string endpoint_brand = "/sapigw/brands";

        //use string format to enter categoryid on attribute endpoint
        public string endpoint_attribute = "/sapigw/product-categories/categoryid/attributes";
    }
}
