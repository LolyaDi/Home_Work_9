using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_9
{
    public class Worker : IWorker
    {
        public string BuilderPosition { get; set; }

        public void BuildHouse(House house)
        {
            if (house.Basement == null)
            {
                house.Basement = new Basement();

                house.Basement.PartOfTheHouse();
                return;
            }

            for (int i = 0; i < house.Walls.Length; i++)
            {
                if (house.Walls[i] == null)
                {
                    house.Walls[i] = new Walls();

                    house.Walls[i].PartOfTheHouse();
                    return;
                }
            }

            if (house.Door == null)
            {
                house.Door = new Door();

                house.Door.PartOfTheHouse();
                return;
            }

            for (int i = 0; i < house.Windows.Length; i++)
            {
                if (house.Windows[i] == null)
                {
                    house.Windows[i] = new Window();

                    house.Windows[i].PartOfTheHouse();
                    return;
                }
            }

            if (house.Roof == null)
            {
                house.Roof = new Roof();

                house.Roof.PartOfTheHouse();
            }

        }
    }
}
