using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolAPIEntegrasyon
{
    internal interface APICall
    {
        public void GetCategories();
        public void GetBrands();
        public void GetAttributes();
    }
}
