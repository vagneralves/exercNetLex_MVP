using System;
using System.Windows.Forms;

namespace exercNetLex
{
	public partial class FindPanel : UserControl
	{
		FindPanelPresenter FindPanelPresent;

		public FindPanel()
		{
			InitializeComponent();
		}

		private void BntFindNext_Click(object sender, EventArgs e)
		{
			FindPanelPresent = new FindPanelPresenter();

			FindPanelPresent.FindNext(TxFind.Text, checkFind.Checked);
		}

		private void BntReplaceNext_Click(object sender, EventArgs e)
		{
			FindPanelPresent = new FindPanelPresenter();

			FindPanelPresent.ReplaceNext(TxFind.Text, TxReplace.Text, checkFind.Checked);
		}

		private void BntReplaceAll_Click(object sender, EventArgs e)
		{
			FindPanelPresent = new FindPanelPresenter();

			FindPanelPresent.ReplaceAll(TxFind.Text, TxReplace.Text, checkFind.Checked);
		}

		private void TxFind_TextChanged(object sender, EventArgs e)
		{
			if (TxFind.Text.Length > 0)
			{
				TxReplace.Enabled = true;
				BntFindNext.Enabled = true;
				checkFind.Enabled = true;
			}
			else
			{
				TxReplace.Enabled = false;
				BntFindNext.Enabled = false;
				checkFind.Enabled = false;
			}
		}

		private void TxReplace_TextChanged(object sender, EventArgs e)
		{
			if (TxReplace.Text.Length > 0)
			{
				BntReplaceNext.Enabled = true;
				BntReplaceAll.Enabled = true;
				checkFind.Enabled = true;
			}
			else
			{
				BntReplaceNext.Enabled = false;
				BntReplaceAll.Enabled = false;
				checkFind.Enabled = false;
			}
		}
	}
}
