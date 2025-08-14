using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_C_
{
    
    internal struct Point 
    {
        #region problem 1
        //public int x;
        //public int y;


        //public Point(int _x, int _y)
        //{
        //    x = _x;
        //    y = _y;
        //}

        //public override string ToString()
        //{
        //    return $"x : {x}, y : {y}";
        //}

        #endregion


        #region problem 4,5,6
        public int x;
        public int y;

        // Constructor to set X to a specific value and Y to 0
        public Point(int _x)
        {
            x= _x;
            y = 0;
        }

        // Constructor to set both X and Y
        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }

        // problem 5
        public override string ToString()
        {
            return $"Point: ({x}, {y})";
        }

        #endregion

    }

}
