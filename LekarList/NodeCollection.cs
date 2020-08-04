using LekarClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList
{
   public class NodeCollection
    {
        internal System.Collections.Generic.List<LekarListClass> _list;
        internal LekarListClass _owner;
        internal NodeCollection(LekarListClass owner)
        {
            this._owner = owner;
            this._owner = new List<LekarListClass>();
        }
    }
}
