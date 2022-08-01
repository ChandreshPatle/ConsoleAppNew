//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.Day7
//{
//    internal class ProductMain
//    {

//        public static void Main()
//        {
//            Product[] products = new Product[5]
//                            {
//                                new Product(){PId=101,PName="Soap",Brand="Detol",Price=25},
//                                new Product(){PId=137,PName="Biscuit",Brand="ParleG",Price=5},
//                                new Product(){PId=140,PName="Toothpaste",Brand="Colgate",Price=75},
//                                new Product(){PId=115,PName="Shampoo",Brand="Dove",Price=120},
//                                new Product(){PId=124,PName="Pen",Brand="cello",Price=10},
//                            };
//            Console.WriteLine("Prodct List");
//            foreach ( var product in products)
//            {
//                Console.WriteLine(product);
//            }

//            Array.Sort(products);
//            Console.WriteLine("Sorted Product List by ID:");
//            foreach (var product in products)
//            {
//                Console.WriteLine(product);
//            }
//            Array.Sort(products,new SortByNameComparer());
//            Console.WriteLine("Sorted Product List by Name:");
//            foreach (var product in products)
//            {
//                Console.WriteLine(product);
//            }
//        }
//    }
//}
