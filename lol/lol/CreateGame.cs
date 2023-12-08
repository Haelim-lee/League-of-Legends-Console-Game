using lol.Helper;
using lol.Model;
using Lol.Model;
using System;
using System.Linq;

namespace Lol
{
    public class CreateGame : LolSystem
    {
        public CreateGame()
        {
            GameCreate();

            if (Player.Champion != null)
                CreateTeam();

            SpeakHelper.CreateBillBoard(RedTeam, BlueTeam);
        }

        private void CreateTeam()
        {
            var random = new Random();
            var ai = new AI();

            var color = random.Next(1, 2);
            ai._champions.Add(Player.Champion);

            if (color == 1)
                RedTeam.Champions.Add(Player.Champion);
            else
                BlueTeam.Champions.Add(Player.Champion);

            while (RedTeam.Champions.Count == 5)
            {
                if (ai.TryGet(out Champion champion))
                    RedTeam.Champions.Add(champion);
            }

            while (BlueTeam.Champions.Count == 5)
            {
                if (ai.TryGet(out Champion champion))
                    BlueTeam.Champions.Add(champion);
            }
        }

        private void GameCreate()
        {
            var positions = Champions.Select(c => c.Position).Distinct();

            SpeakHelper.CreateWord("게임을 시작합니다.");
            SpeakHelper.CreateWord("닉네임을 입력하세요.");

            Player.Name = Console.ReadLine();
            Player.Position = CreatePosition(Player);

            foreach (var position in positions)
                Player.Champion = Pick();
        }

        private Champion Pick()
        {
            var position = Player.Position;
            int number = 1;

            var pickChampions = Champions.Where(c => c.Position == position);
            var array = pickChampions.ToArray();

            foreach (var champion in pickChampions)
            {
                if (position == champion.Position)
                    SpeakHelper.CreateWord(number++ + "." + champion.Name);
            }

            if (int.TryParse(Console.ReadLine(), out int pickNumber))
                return array[pickNumber -1];
            else
            {
                SpeakHelper.CreateWord("다시 선택해주세요");
                Console.ReadLine();
            }

            return null;
        }
        public ePosition CreatePosition(Summoner player)
        {
            SpeakHelper.CreateWord("라인을 선택하세요.");
            SpeakHelper.CreateWord("1.미드 2.원딜 3.서포터 4.탑 5.정글");

            switch (Console.ReadLine())
            {
                case "1":
                    player.Position = ePosition.MIDLINER;
                    break;
                case "2":
                    player.Position = ePosition.MARKSMAN;
                    break;
                case "3":
                    player.Position = ePosition.SUPPORTER;
                    break;
                case "4":
                    player.Position = ePosition.TANKER;
                    break;
                case "5":
                    player.Position = ePosition.JUNGLEER;
                    break;
                default:
                    {
                        SpeakHelper.CreateWord("다시 선택해주세요.");
                        CreatePosition(player);
                        break;
                    }
            }

            SpeakHelper.CreateWord(player.Position + "을 선택하셨습니다.");
            return player.Position;
        }
    }
}