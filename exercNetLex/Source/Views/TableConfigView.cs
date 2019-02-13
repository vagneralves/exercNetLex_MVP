using exercNetLex.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp.Forms;

namespace exercNetLex
{
	public partial class TableConfigView : MvpForm, ITableConfigView
	{

		public TableConfigView()
		{
			InitializeComponent();
		}

		public event EventHandler CreateTable;
		public event EventHandler CloseFormTableConfig;

		public int NumeroLinhas
		{
			get
			{
				return (int)NudNumLinhas.Value;
			}

			set { }

		}
		public int NumeroColunas
		{
			get
			{
				return (int)NudNumColunas.Value;
			}
			
			set { }
		}

		private void BntAddTableOK_Click(object sender, EventArgs e)
		{
			CreateTable(sender, e);
			CloseFormTableConfig(sender, e);
		}

		private void BntAddTableCancel_Click(object sender, EventArgs e)
		{
			CloseFormTableConfig(sender, e);
		}

		public void FecharTelaTableConfig()
		{
			this.Close();
		}
	}
}
