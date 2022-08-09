//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace ConsoleAppNew.CollectionDemo
//{
//    internal class HashTableDemo
//    {
//        static void Main(string[] args)
//        {
//            //Hashtable users = new Hashtable();
//            SortedList users = new SortedList();
//            users.Add("user1", "user@123");
//            users.Add("admin", "admin@123");
//            users.Add("hari", "hari@123");
//            users.Add("anshu", "anshu@123");
//            users.Add("isha", "isha@123");
//            //users.Add("isha", "isha@123");//Duplicate key not allowed only key unique
//            //users.Add(null, "null@123");//key cannot be null
//            Console.WriteLine("User data:");
//            //Console.WriteLine(users["user1"]);
//            //using foreach
//            foreach (DictionaryEntry user in users)
//            {
//                Console.WriteLine(user.Key+"=>"+user.Value);
//            }
//            //using Enumerator
//            IDictionaryEnumerator itr = users.GetEnumerator();
//            Console.WriteLine("users data usingEnumerator");
//            while (itr.MoveNext())
//            {
//                Console.WriteLine(itr.Key+"\t"+itr.Value);
//            }

//            //getting all keys
//            ICollection keys= users.Keys;
//            //ArrayList userskeys = new ArrayList(keys);

//            IEnumerator keyitr= keys.GetEnumerator();
//            while (keyitr.MoveNext())
//            {
//                Console.WriteLine(keyitr.Current);
//            }

//            //password 
//            ICollection val = users.Values;
//            //ArrayList userskeys = new ArrayList(keys);

//            IEnumerator valu = val.GetEnumerator();
//            while (valu.MoveNext())
//            {
//                Console.WriteLine(valu.Current);
//            }
//        }
//    }
//}
