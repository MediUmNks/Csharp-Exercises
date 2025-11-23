using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement.NewFolder
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
        int Amount { get; set; }
        bool IsAvalable { get; set; }

        void DisplayInfo();
    }
}
