using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_9
{
    public class House
    {
        public static int COUNT_WORKER { get; set; } = 4;

        public Basement Basement { get; set; } = null;

        public Walls[] Walls { get; set; } = new Walls[COUNT_WORKER];

        public Window[] Windows { get; set; } = new Window[COUNT_WORKER];

        public Door Door { get; set; } = null;

        public Roof Roof { get; set; } = null;
    }
}
