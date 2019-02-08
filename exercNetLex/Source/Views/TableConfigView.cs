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
		//RibbonPresenter Rp;

		public TableConfigView()
		{
			InitializeComponent();
		}

		public event EventHandler CreateTable;

		private void BntAddTableOK_Click(object sender, EventArgs e)
		{
			/*Rp = new RibbonPresenter();

			//Seta as variáveis INT com os valores inseridos na tela de configuração da tabela
			int numLinhas = (int)NudNumLinhas.Value;
			int numColunas = (int)NudNumColunas.Value;

			//Fecha a tela de configuração após extrair os valores digitados
			ActiveForm.Close();

			//Chama a função de criar tabela passando os valores extraidos
			Rp.CriarTabela(numLinhas, numColunas);*/

			CreateTable(sender, e);


		}

		private void BntAddTableCancel_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}
	}
}
