using Lol.Locations;
using Lol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.Object
{
    public class Tower : Location
    {
        public int Number { get; set; }

        public override void Attack(Champion champion)
        {
            throw new NotImplementedException();
        }
    }
}
