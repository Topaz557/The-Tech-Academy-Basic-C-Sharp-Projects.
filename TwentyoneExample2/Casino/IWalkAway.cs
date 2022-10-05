using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway // cam only inherit one base class but can also inherit as many interfaces as you want
    {
        void WalkAway(Player player); //Already public when in an interface, do not need to specify public
    }
}
