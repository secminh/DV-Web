using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        List<User> GetAll();
        [OperationContract]
        User GetByID(int id);
        [OperationContract]
        void AddUser(User u);
        [OperationContract]
        void UpdateUser(User u);
        [OperationContract]
        void DeleteUser(int id);
    }
}
