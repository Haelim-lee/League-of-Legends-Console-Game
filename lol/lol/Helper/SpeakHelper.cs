using Lol.Model;
using Lol.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.Helper
{
    public static class SpeakHelper
    {
        public static void CreateWord(string Str)
        {
            Console.WriteLine(Str);
            Thread.Sleep(300);
        }

        public static void CreateBillBoard(RedTeam redTeam, BlueTeam blueTeam)
        {
            Console.Clear();

            Console.WriteLine("RED TEAM");
            foreach (var mamber in redTeam.Champions)
                ChampionBillBoard(mamber);

            Console.WriteLine("BLUE TEAM");
            foreach (var mamber in blueTeam.Champions)
                ChampionBillBoard(mamber);

            Thread.Sleep(1500);
        }

        private static void ChampionBillBoard(Champion mamber)
           => Console.WriteLine($"{mamber.Position} ---- Name :{mamber.Name} ----Kill :{mamber.Kill} " +
               $"----Die : {mamber.Die} ----Help : {mamber.Help}");
    }
}
