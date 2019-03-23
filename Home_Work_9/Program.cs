using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT_WORKER = 4;
            House house = new House();
            Team team = new Team();
            TeamLeader teamLeader = new TeamLeader();

            for (int i = 0, j = 0; house.Roof == null; i++, j++)
            {
                if (j == COUNT_WORKER)
                {
                    j = 0;
                }
                team[j].BuildHouse(house);
            }
            teamLeader.Report(house);

            Console.Write(@"       
                    ___________________      
                   /\        ______    \    
                  //_\       \    /\    \  
                 //___\       \__/  \    \
                //_____\       \ |[]|     \
               //_______\       \|__|      \
              /XXXXXXXXXX\                  \
             /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadKey();
        }
    }
}
