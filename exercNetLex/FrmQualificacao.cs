using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercNetLex
{
	public partial class FrmQualificacao : Form
	{
		//RibbonPresenter RibbonPresenter;

		public FrmQualificacao()
		{
			InitializeComponent();
		}

		private void BntQualificacaoCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BntQualificacaoOK_Click(object sender, EventArgs e)
		{
			/*RibbonPresenter = new RibbonPresenter();
			if ((TxtContatoPJ.Text != null && TxtContatoPJ.Text != "") && (TxtContatoRep.Text != null && TxtContatoRep.Text != ""))
			{
				if (RibbonPresenter.Selecao.Text != null && RibbonPresenter.Selecao.Text != "")
				{
					RibbonPresenter.Selecao.Delete();
				}
				RibbonPresenter.AddQualificacao(TxtContatoPJ.Text, TxtContatoRep.Text);
					this.Close();
			}
			else
			{
				if ((TxtContatoPJ.Text == null || TxtContatoPJ.Text == "") && (TxtContatoRep.Text == null || TxtContatoRep.Text == ""))
				{
					MessageBox.Show("Campos vazios! Você deve inserir nomes para os Contatos!");
				}
				else
				{
					if ((TxtContatoPJ.Text == null || TxtContatoPJ.Text == ""))
					{
						MessageBox.Show("Campo vazio! Você deve inserir um nome para o Contato PJ!");
					}
					if (TxtContatoRep.Text == null || TxtContatoRep.Text == "")
					{
						MessageBox.Show("Campo vazio! Você deve inserir um nome para o Contato Rep!");
					}
				}
			}*/
		}
	}
}
