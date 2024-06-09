using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListPract
{
    public class PractList
    {
        public void Demo(){
            List<int> list=new List<int>();
            //adding new object
            list.Add(12);
            list.Add(21);
            list.Add(34);
            list.Add(625);

            //adding range of elements
            List<int> optList=new List<int>(){12,32,43,910};

            //insert at 
            //optList.Insert(3,12);
            list.Clear();

           // list.AddRange(optList);
            foreach(int i in list){
                System.Console.WriteLine(i);
            }

        }
    }
}