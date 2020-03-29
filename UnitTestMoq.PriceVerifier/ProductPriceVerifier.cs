using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestMoq.PriceVerifier
{
    public class ProductPriceVerifier : IProductPriceVerifier
    {
        public string VerifyProductPrice(Product p)
        {
            if (p.Price > 100)
            {
                return "Product expensive!";
            }
            else if(p.Price <= 100 && p.Price > 40)
            {
                return "Product at average price!";
            }
            else
            {
                return "Product cheap!";
            }
        }
    }
}
