using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from {this}");
        }
        public void SaveData()
        {
            Console.WriteLine($"Data has been saved to {this}");
        }
    }
}
