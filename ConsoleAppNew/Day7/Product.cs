using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day7
{
    internal class Product : IComparable<Product>
    {
        int _PId;
        string _PName;
        float _Price;
        string _Brand;

        public int PId { get => _PId; set => _PId = value; }

        public string PName { get => _PName; set => _PName = value; }

        public float Price { get => _Price; set => _Price = value; }

        public string Brand { get => _Brand; set => _Brand = value; }

        public override string ToString()//method to display data
        {
            return $"PID:{_PId }\tName: {_PName}\tBrand:{_Brand}\tPrice: {_Price}";
        }

        //Overriding CompareTo method of IComprable Interface of Product object Comparision
        public int CompareTo(Product other)
        {
            //return this._PId>other._PId ? 1 : -1;
            //return 0;
           // return this._PId.CompareTo(other._PId);//1, -1, 0,ASC
            return other._PId.CompareTo(this._PId);//1,-1,0,DESC

        }
    }
    //IComparer interface we use to create custome comparators
    class SortByNameComparer:IComparer<Product>
    {
        public int Compare(Product obj1, Product obj2)
        {
           // return obj1.PName.CompareTo(obj2.PName);//Ascending order
            return obj2.PName.CompareTo(obj1.PName);//Descending order
        }
    }

    //Enum Type for sorting Field type
    enum SortBy { ID,Name,Brand,Price};
    
    //Custom Comparer Class
    class MyCustomComparer : IComparer<Product>
    {
        private bool _IsAscending;
        private SortBy _SortBy;
        public MyCustomComparer(bool _IsAscending=true, SortBy _SortBy=SortBy.ID)
        {
            this._IsAscending = _IsAscending;
            this._SortBy = _SortBy;
        }

        public int Compare(Product obj1, Product obj2)
        {
            int comResult = 0;

            switch (_SortBy)
            {
                case SortBy.ID:
                    if (_IsAscending)
                    {
                        comResult = obj1.PId.CompareTo(obj2.PId);
                    }
                    else
                        comResult = obj2.PId.CompareTo(obj1.PId);
                    break;
                case SortBy.Name:
                    if (_IsAscending)
                    {
                        comResult = obj1.PName.CompareTo(obj2.PName);
                    }
                    else
                        comResult = obj2.PName.CompareTo(obj1.PName);
                    break;
                case SortBy.Brand:
                    if (_IsAscending)
                    {
                        comResult = obj1.Brand.CompareTo(obj2.Brand);
                    }
                    else
                        comResult = obj2.Brand.CompareTo(obj1.Brand);
                    break;
                case SortBy.Price:
                    if (_IsAscending)
                    {
                        comResult = obj1.Price.CompareTo(obj2.Price);
                    }
                    else
                        comResult = obj2.Price.CompareTo(obj1.Price);
                    break;
                default:
                    break;
            }


            return comResult;
        }

    }






}
