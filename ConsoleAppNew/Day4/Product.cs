using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1-By making all data fields public
2-Constructor
3-Methods

 */


namespace ConsoleAppNew.Day4
{
    internal class Product
    {
        //data fields..
        int _ProductId;
        string _Name;
        string _Brand;
        int _Quantity;
        float _Price;

        //Settter
        public void SetProductId(int _ProductId)
        {
            this._ProductId = _ProductId;
        }

        //Getter
        public int GetProductId()
        {
            return this._ProductId;
        }

        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.SetProductId(20);
            p1.GetProductId();//Properties 
        }
    }
}
