﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
   public interface IBuyer
    {
        int Food { get; }
        int buyFood();
    }
}
