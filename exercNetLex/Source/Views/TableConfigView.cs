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
		public event EventHandler CloseForm;

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
			CloseForm(sender, e);
		}

		private void BntAddTableCancel_Click(object sender, EventArgs e)
		{
			CloseForm(sender, e);
		}

		private void TableConfigView_Load(object sender, EventArgs e)
		{

		}

		public void FecharTela()
		{
			ActiveForm.Close();
		}
	}
}
