using exercNetLex.Source.Views;
using System.Windows.Forms;
using System;
using WinFormsMvp.Forms;

namespace exercNetLex
{
	public partial class FindPanelView : MvpUserControl, IFindPanelView
	{
		public FindPanelView()
		{
			InitializeComponent();
		}

		public event EventHandler FindNext;
		public event EventHandler ReplaceNext;
		public event EventHandler ReplaceAll;
		public event EventHandler EnableComponetsTextFind;
		public event EventHandler EnableComponetsTextReplace;

		public bool TxReplaceEnable { set => TxReplace.Enabled = value; }
		public bool BntFindNextEnable { set => BntFindNext.Enabled = value; }
		public bool CheckFindEnable { set => checkFind.Enabled = value; }
		public bool BntReplaceNextEnable { set => BntReplaceNext.Enabled = value; }
		public bool BntReplaceAllEnable { set => BntReplaceAll.Enabled = value; }

		public string TextFind
		{
			get
			{
				return TxFind.Text;
			}
			set
			{
				TxFind.Text = value;
			}
		}
		public string TextReplace
		{
			get
			{
				return TxReplace.Text;
			}
			set
			{
				TxReplace.Text = value;
			}
		}
		public bool CheckFindCase
		{
			get
			{
				return checkFind.Checked;
			}
			set
			{
				checkFind.Checked = value;
			}
		}

		private void BntFindNext_Click(object sender, EventArgs e)
		{
			FindNext(sender, e);
		}

		private void BntReplaceNext_Click(object sender, EventArgs e)
		{
			ReplaceNext(sender, e);
		}

		private void BntReplaceAll_Click(object sender, EventArgs e)
		{
			ReplaceAll(sender, e);
		}

		private void TxFind_TextChanged(object sender, EventArgs e)
		{
			EnableComponetsTextFind(sender, e);
		}

		private void TxReplace_TextChanged(object sender, EventArgs e)
		{
			EnableComponetsTextReplace(sender, e);
		}

		public void MostrarMsgNotFound()
		{
			MessageBox.Show("Não foram encontradas ocorrências!");
		}

	}
}
