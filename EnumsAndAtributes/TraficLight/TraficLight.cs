using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficLight
{
   public class TraficLight
    {
        public TraficLight(Color color)
        {
            this.Color = color;
        }

        public Color Color { get;  set; }

        public override string ToString()
        {
            return this.Color.ToString();
        }
    }
}
