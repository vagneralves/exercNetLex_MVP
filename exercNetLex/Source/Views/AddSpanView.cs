using exercNetLex.Source.Views;
using System;
using System.Windows.Forms;
using WinFormsMvp;
using WinFormsMvp.Forms;

namespace exercNetLex
{
	public partial class AddSpanView : MvpForm, IAddSpanView
	{
		public AddSpanView()
		{
			InitializeComponent();
		}

		public event EventHandler AddSpan;
		public event EventHandler CloseFormAddSpan;


		public string ExpressionSpan
		{
			get
			{
				return TxtAddSpan.Text;
			}

			set
			{
				TxtAddSpan.Text = value;
			}
		}

		private void BntAddSpanCancel_Click(object sender, EventArgs e)
		{
			CloseFormAddSpan(sender, e);
		}

		private void BntAddSpanOk_Click(object sender, EventArgs e)
		{
			AddSpan(sender, e);
			CloseFormAddSpan(sender, e);
		}

		public void FecharTelaAddSpan()
		{
			this.Close();
		}

		public void MostrarMsgSpan(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
