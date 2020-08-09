using System.Collections.Generic;
using Products;

namespace Catalog
{
    internal interface ICatalog
    {
        IReadOnlyList<Product> Products{ get; }
        void ProductOutPut();
    }
}