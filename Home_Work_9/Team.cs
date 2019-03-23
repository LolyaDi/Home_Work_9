using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_9
{
    public class Team
    {
        public static int CountWorker { get; set; } = 4;

        public Worker[] TeamWorker { get; set; } = new Worker[CountWorker];

        public Team()
        {
            for (int i = 0; i < TeamWorker.Length; i++)
            {
                TeamWorker[i] = new Worker
                {
                    BuilderPosition = $"Строитель"
                };
            }
        }

        public Worker this[int index]
        {
            get
            {
                if (index >= 0 && index < CountWorker)
                {
                    return TeamWorker[index];
                }
                    
                return null;
            }
            set
            {
                TeamWorker[index] = value;
            }
        }
    }
}
