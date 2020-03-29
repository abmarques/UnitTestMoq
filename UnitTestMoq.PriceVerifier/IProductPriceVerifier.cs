using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestMoq.PriceVerifier
{
    public interface IProductPriceVerifier
    {
        string VerifyProductPrice(Product p);
    }
}
