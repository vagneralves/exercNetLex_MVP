using System;
using WinFormsMvp;
using System.Windows.Forms;

namespace exercNetLex
{
	public interface IFindPanelView : IView
	{
		event EventHandler FindNext;
		event EventHandler ReplaceNext;
		event EventHandler ReplaceAll;
		event EventHandler EnableComponetsTextFind;
		event EventHandler EnableComponetsTextReplace;

		string TextFind { get; set; }
		string TextReplace { get; set; }
		bool CheckFindCase { get; set; }

		bool TxReplaceEnable { set; }
		bool BntFindNextEnable { set; }
		bool BntReplaceNextEnable { set; }
		bool BntReplaceAllEnable { set; }
		bool CheckFindEnable { set; }

		void MostrarMsgNotFound();


	}
}
