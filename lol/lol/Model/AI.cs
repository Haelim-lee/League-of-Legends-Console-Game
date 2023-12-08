using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Model
{
    public class AI
    {
        public List<Champion> Champions { get; set; }
        public HashSet<Champion> _champions { get; set; }

        public bool TryGet(out Champion ai)
        {
            ai = null;

            if (_champions.Count == Champions.Count)
                return false;

            var randomAi = Random(Champions.Except(_champions));

            _champions.Add(randomAi);

            ai = randomAi;
            return true;
        }

        public Champion Random(IEnumerable<Champion> champoins)
        {
            var random = new Random();
            var index = random.Next(0, champoins.Count() - 1);

            return champoins.ElementAt(index);
        }
    }
}
