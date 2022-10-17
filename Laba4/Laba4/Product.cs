using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Product
    {
        #region Fields
        string name;
        int cost;
        #endregion

        #region Constructor
        public Product(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get { return name; } 
        }

        public int Cost
        {
            get { return cost; }
        }
        #endregion
    }
}
