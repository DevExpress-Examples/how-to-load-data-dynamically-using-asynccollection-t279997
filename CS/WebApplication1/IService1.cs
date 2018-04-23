using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication1 {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 {
        [OperationContract]
        [ServiceKnownType(typeof(Item))]
        IEnumerable GetData(int skipCount, int takeCount);
        [OperationContract]
        int Count();
    }
    public interface IItem {
        int Id { get; set; }
        string Name { get; set; }
    }
}