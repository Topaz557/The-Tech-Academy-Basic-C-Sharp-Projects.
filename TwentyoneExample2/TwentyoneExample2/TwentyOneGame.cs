using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyoneExample2
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
