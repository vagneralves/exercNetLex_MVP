using exercNetLex.Source.Views;
using System;
using System.Windows.Forms;
using WinFormsMvp;
using WinFormsMvp.Forms;

namespace exercNetLex
{
	public partial class QualificationView : MvpForm, IQualificationView
	{
		public QualificationView()
		{
			InitializeComponent();
		}

		public event EventHandler AddQualificacao;
		public event EventHandler CloseFormAddQualificacao;

		public string NomeContatoPJ
		{
			get
			{
				return TxtContatoPJ.Text;
			}

			set
			{
				TxtContatoPJ.Text = value;
			}
		}
		public string NomeContatoRep
		{
			get
			{
				return TxtContatoRep.Text;
			}

			set
			{
				TxtContatoRep.Text = value;
			}
		}

		private void BntQualificacaoCancel_Click(object sender, EventArgs e)
		{
			CloseFormAddQualificacao(sender, e);
		}

		private void BntQualificacaoOK_Click(object sender, EventArgs e)
		{
			AddQualificacao(sender, e);
			CloseFormAddQualificacao(sender, e);
		}

		public void FecharTelaAddQualificacao()
		{
			this.Close();
		}

		public void MostrarMsgQualificacao(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
