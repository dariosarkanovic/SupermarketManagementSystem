using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    internal interface IDataConnection
    {
        void DisplayDataFromDB(string name);
    }
}
