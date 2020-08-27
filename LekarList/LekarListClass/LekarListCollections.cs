using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace LekarClass
{
	public class LekarListCollection
	{
		internal List<LekarListClass> _list;
		internal LekarListClass _owner;
		internal LekarListCollection(LekarListClass owner)
		{
			this._owner = owner;
			this._list = new List<LekarListClass>();
		}
	}
	
}
