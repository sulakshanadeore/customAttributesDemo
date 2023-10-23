using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customAttributesDemo
{
    [Developer("1", Devid = 102, DevName = "nikhil")]
    [Developer("1",Devid =103,DevName ="Sunil")]
    public class Books
    {

    }


    [Developer("1", Devid = 102, DevName = "nikhil")]
    public class Products
    {
        [Developer("1",Devid =101,DevName ="Arti")]
        int _price;
        [Developer("1", Devid = 101, DevName = "Arti")]
        int _qty;

        public int Prodid { get; set; }
        public string Prodname { get; set; }
    }
}
