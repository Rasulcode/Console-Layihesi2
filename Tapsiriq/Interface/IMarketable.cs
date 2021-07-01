using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriq
{
    interface IMarketable
    {
        List<Satish> Satishes { get; set; }
        List<SatishItem> SatishItems { get; set; }
        void AddOrder(Product product, int productcount);
        SatishItem ReturnOrder(Satish order);
        Satish ReturnOrder(string orderno, SatishItem orderitem);
        List<Satish> ReturnAllOrders(string ordertime,string ordertime2);
        List<Satish> ReturnOrders(string ordertime);
        List<Satish> ReturnValueOrders(double value);
        Satish ReturnNoOrder(string orderno);
        void AddOrderItem(string orderitemname,int orderitemno );
        void EditProduct(string productcode);
        List<Product> ReturnProducts(Category category);
        List<Product> ReturnValueProducts(double value1, double value2 );
        List<Product> SearchProducts(string productname);
    }
}
