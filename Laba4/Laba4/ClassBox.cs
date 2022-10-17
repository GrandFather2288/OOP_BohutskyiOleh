using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class ClassBox
    {
        #region Fields
        float length;
        float width;
        float height;
        #endregion

        #region Constructors
        public ClassBox(float length, float width, float height)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("Length can`t be negative or zero");
            }

            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("Width can`t be negative or zero");
            }

            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("Height can`t be negative or zero");
            }
        }

        #endregion

        #region Methods
        public float SurfaceArea()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);
        }

        public float LateralSurfaceArea()
        {
            return (2 * length * height) + (2 * width * height);
        }

        public float Volume()
        {
            return length * width * height;
        }
        #endregion
    }
}
