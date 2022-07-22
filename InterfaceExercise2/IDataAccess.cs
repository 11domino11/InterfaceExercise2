using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise2
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData();
    }
}
