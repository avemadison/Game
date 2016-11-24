using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespase Snake {
    class Program 
    {
        {
          static void Main (string[] args)
          {

             List<int> numList = new List <int>();
             numList.Add(0);
             numList.Add(1);
             numList.Add(2);
            
            int x = numList [0];
            int y = numList [1];
            int z = numList [2];
            
            foreach (int i in numList){
                Console.WriteLine (i);
            }
              numList = RemoveAt[0];
              
              List<char> charList = new List<char>();
              charList.Add('*');
              charList.Add('#');
              charList.Add('@');
              charList.Add('$');
              
              foreach (char r in charList) {
                  Console.WriteLine (r);
              }
              
             Point p1 = new Point(1, 3, '*');
             Point p2 = new Point(4, 5, '#');
             Point p3 = new Point(6, 1, '@');
             Point p4 = new Point(7, 2, '$');
             
             List<Point> pList = new List<Point>();
             pList.Add(p1);
             pList.Add(p2);
             pList.Add(p3);
             pList.Add(p4);
              
              foreach (Point p in pList){
                  p.Draw();
              }
              
              Console.RedLine();
          }
      }
 }
            
            Console.RedLine();
        }
    }
}
