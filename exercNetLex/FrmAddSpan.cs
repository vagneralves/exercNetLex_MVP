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
	public partial class FrmAddSpan : Form
	{
		//RibbonPresenter RibbonPresenter;

		public FrmAddSpan()
		{
			InitializeComponent();
		}

		private void BntAddSpanCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BntAddSpanOk_Click(object sender, EventArgs e)
		{
			/*RibbonPresenter = new RibbonPresenter();
			// Testa se o campo foi preenchido
			if (TxtAddSpan.Text != null && TxtAddSpan.Text != "")
			{
				RibbonPresenter.AddSpan(TxtAddSpan.Text);
				this.Close();
			}
			else
			{
				MessageBox.Show("Campo vazio! Você deve inserir uma expressão!");
			}*/
		}
	}
}
