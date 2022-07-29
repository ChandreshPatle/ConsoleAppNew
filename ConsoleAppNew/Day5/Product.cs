using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day5
{
    internal class Product
    {
        int _ProductId;
        string _Name;
        string _Brand;
       // int _Quantity;
        float _Price;


        //property defination
        public int ProductId
        {
            set
            {
                //some logic
                _ProductId = value;//write operation
            }
            get
            {
                //some logic
                return _ProductId;//read operation
            }
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public string Brand
        {
            set { _Brand = value; }
            get { return _Brand; }
        }
        public float Price
        {
            set { _Price = value; }
            get { return _Price; }
        }
        public override string ToString()
        {
            return $"Product:{_ProductId},{_Name},{_Brand},{Price}";
        }
    }
}
