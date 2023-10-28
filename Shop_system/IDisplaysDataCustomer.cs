using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system
{
    // Gridviews are the primary way this application displays data in the customer role
    // This inherited interface ensures a configuration method for the grid view is implemented.
    internal interface IDisplaysDataCustomer
    {
        public void ConfigureGridView<T>(List<T> items);
    }
}
