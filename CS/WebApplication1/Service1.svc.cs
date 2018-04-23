using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WebApplication1 {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [KnownType(typeof(Item))]
    public class Service1: IService1 {
        public IEnumerable GetData(int skipCount, int takeCount) {
            int endIndex = skipCount + takeCount;
            Debug.WriteLine(string.Format("skipCount={0}, takeCount={1}", skipCount, takeCount));
            List<Item> items = new List<Item>();
            for(int i = skipCount; i < endIndex; i++)
                items.Add(new Item { Id = i, Name = "Name" + i });
            return items;
        }
        public int Count() {
            return 1000;
        }
    }
    public class Item: IItem {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}