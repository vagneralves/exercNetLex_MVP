using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using exercNetLex.Views;

namespace exercNetLex.Presenters
{
	public class TableConfigPresenter : Presenter<ITableConfigView>
	{
		public TableConfigPresenter(ITableConfigView View) : base(View)
		{
			View.CreateTable += View_CreateTable;
		}

		private void View_CreateTable(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
