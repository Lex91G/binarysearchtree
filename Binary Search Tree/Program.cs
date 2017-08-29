using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
  
        class Program
        {
            static void Main(string[] args)
            {
                Tree b = new Tree();
                
                b.insert(3);
                b.insert(6);
                b.insert(2);
                b.insert(4);
                b.insert(1);
                b.insert(5);

                b.display();

                Console.ReadLine();
            }
         }
      }
    

