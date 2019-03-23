using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_9
{
    public class Walls : IPart
    {
        public bool CheckConstruction { get; set; } = false;

        public void PartOfTheHouse()
        {
            CheckConstruction = true;
        }
    }
}
