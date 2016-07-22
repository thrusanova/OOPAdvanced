using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty.Interfaces
{
  public  interface ILeutenantGeneral
    {
        List<Private>Privates { get; }
        void addPrivates(String id, List<IPrivate> allPrivates);
    }
}
