using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementSystem.Forms;

namespace SupermarketManagementSystem
{
    internal interface IDataConnection
    {
        void DisplayDataFromDB(string name);
    }
}
