using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace exercNetLex.Views
{
	public interface ITableConfigView : IView
	{
		event EventHandler CreateTable;
	}
}
