using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //User Defined DataType 
    class Program
    {

        static void Main_old(string[] args)
        {
            StudentInfo _instance = new StudentInfo(); //Instance / space 
            _instance.SetId("S100");
            _instance.SetName("Tom");
            _instance.SetMarks(60);

            string idValue=  _instance.GetId();
            System.Console.WriteLine(idValue);
        }
    }
}
