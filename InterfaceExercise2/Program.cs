using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of interface to store your data? List, SQL, or Mongo?");
            string userInput = Console.ReadLine();
            var myData = DataAccessFactory.GetDataAcessType(userInput);
            myData.LoadData();
            myData.SaveData();
            Console.ReadLine();
        }
    }
}
