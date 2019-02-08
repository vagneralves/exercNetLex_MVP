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
	public partial class FrmAddField : Form
	{
		RibbonPresenter RibbonPresenter;
		
		public FrmAddField()
		{
			InitializeComponent();
		}

		private void BntAddFieldCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BntAddFieldOk_Click(object sender, EventArgs e)
		{
			RibbonPresenter = new RibbonPresenter();
			// Testa se o campo foi preenchido
			if (TxtAddField.Text != null && TxtAddField.Text != "")
			{
				RibbonPresenter.AddField(TxtAddField.Text);
				this.Close();
			}
			else
			{
				MessageBox.Show("Campo vazio! Você deve inserir uma expressão!");
			}
			
		}
	}
}
