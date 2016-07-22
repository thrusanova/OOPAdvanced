using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borderControl
{
   public interface IBuyer
    {
        int Food { get; }
        int buyFood();
    }
}
