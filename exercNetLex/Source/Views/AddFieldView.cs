using exercNetLex.Source.Views;
using System;
using System.Windows.Forms;
using WinFormsMvp;
using WinFormsMvp.Forms;

namespace exercNetLex.Views
{
	public partial class AddFieldView : MvpForm, IAddFieldView
	{
		public AddFieldView()
		{
			InitializeComponent();
		}

		public event EventHandler AddField;
		public event EventHandler CloseFormAddField;


		public string ExpressionField
		{
			get
			{
				return TxtAddField.Text;
			}

			set
			{
				TxtAddField.Text = value;
			}
		}

		private void BntAddFieldCancel_Click(object sender, EventArgs e)
		{
			CloseFormAddField(sender, e);
		}

		private void BntAddFieldOk_Click(object sender, EventArgs e)
		{
			AddField(sender, e);
			CloseFormAddField(sender, e);
		}

		public void FecharTelaAddField()
		{
			this.Close();
		}

		public void MostrarMsgField(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
