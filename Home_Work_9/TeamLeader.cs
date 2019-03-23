using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_9
{
    public class TeamLeader : IWorker
    {
        public string BuilderPosition { get; set; } = "Бригадир";

        public void Report(House house)
        {
            Console.WriteLine($"Отчет строителя с должностью - {BuilderPosition}:");

            if (house.Basement != null)
            {
                Console.WriteLine("Построен - фундамент");
                house.Basement.PartOfTheHouse();
            }

            for (int i = 0; i < house.Walls.Length; i++)
            {
                if (house.Walls[i] != null)
                {
                    Console.WriteLine($"Построенa - стена");
                    house.Walls[i].PartOfTheHouse();
                }
            }

            if (house.Door != null)
            {
                Console.WriteLine("Установлена - дверь");
                house.Door.PartOfTheHouse();
            }

            for (int i = 0; i < house.Windows.Length; i++)
            {
                if (house.Windows[i] != null)
                {
                    Console.WriteLine($"Установлено - окно");
                    house.Windows[i].PartOfTheHouse();
                }
            }

            if (house.Roof != null)
            {
                Console.WriteLine("Построена - крыша");
                house.Roof.PartOfTheHouse();
            }
        }

    }
}
