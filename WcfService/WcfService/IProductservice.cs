using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductservice" in both code and config file together.
    [ServiceContract]
    public interface IProductservice
    {
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        Product GetByID(int id);
        [OperationContract]
        void AddProduct(Product p);
        [OperationContract]
        void UpdateProduct(Product p);
        [OperationContract]
        void DeleteProduct(int id);
    }
}
