namespace exercNetLex
{
	partial class QualificationView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QualificationView));
			this.LblContatoPJ = new System.Windows.Forms.Label();
			this.TxtContatoPJ = new System.Windows.Forms.TextBox();
			this.TxtContatoRep = new System.Windows.Forms.TextBox();
			this.LblContatoRep = new System.Windows.Forms.Label();
			this.BntQualificacaoCancel = new System.Windows.Forms.Button();
			this.BntQualificacaoOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblContatoPJ
			// 
			this.LblContatoPJ.AutoSize = true;
			this.LblContatoPJ.Location = new System.Drawing.Point(9, 17);
			this.LblContatoPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblContatoPJ.Name = "LblContatoPJ";
			this.LblContatoPJ.Size = new System.Drawing.Size(144, 13);
			this.LblContatoPJ.TabIndex = 0;
			this.LblContatoPJ.Text = "Digite o nome do contato PJ:";
			// 
			// TxtContatoPJ
			// 
			this.TxtContatoPJ.Location = new System.Drawing.Point(11, 45);
			this.TxtContatoPJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TxtContatoPJ.Name = "TxtContatoPJ";
			this.TxtContatoPJ.Size = new System.Drawing.Size(231, 20);
			this.TxtContatoPJ.TabIndex = 1;
			// 
			// TxtContatoRep
			// 
			this.TxtContatoRep.Location = new System.Drawing.Point(11, 106);
			this.TxtContatoRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TxtContatoRep.Name = "TxtContatoRep";
			this.TxtContatoRep.Size = new System.Drawing.Size(231, 20);
			this.TxtContatoRep.TabIndex = 3;
			// 
			// LblContatoRep
			// 
			this.LblContatoRep.AutoSize = true;
			this.LblContatoRep.Location = new System.Drawing.Point(9, 78);
			this.LblContatoRep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblContatoRep.Name = "LblContatoRep";
			this.LblContatoRep.Size = new System.Drawing.Size(152, 13);
			this.LblContatoRep.TabIndex = 2;
			this.LblContatoRep.Text = "Digite o nome do contato Rep:";
			// 
			// BntQualificacaoCancel
			// 
			this.BntQualificacaoCancel.Location = new System.Drawing.Point(11, 157);
			this.BntQualificacaoCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BntQualificacaoCancel.Name = "BntQualificacaoCancel";
			this.BntQualificacaoCancel.Size = new System.Drawing.Size(56, 19);
			this.BntQualificacaoCancel.TabIndex = 4;
			this.BntQualificacaoCancel.Text = "Cancelar";
			this.BntQualificacaoCancel.UseVisualStyleBackColor = true;
			this.BntQualificacaoCancel.Click += new System.EventHandler(this.BntQualificacaoCancel_Click);
			// 
			// BntQualificacaoOK
			// 
			this.BntQualificacaoOK.Location = new System.Drawing.Point(185, 157);
			this.BntQualificacaoOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BntQualificacaoOK.Name = "BntQualificacaoOK";
			this.BntQualificacaoOK.Size = new System.Drawing.Size(56, 19);
			this.BntQualificacaoOK.TabIndex = 5;
			this.BntQualificacaoOK.Text = "OK";
			this.BntQualificacaoOK.UseVisualStyleBackColor = true;
			this.BntQualificacaoOK.Click += new System.EventHandler(this.BntQualificacaoOK_Click);
			// 
			// QualificationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 192);
			this.Controls.Add(this.BntQualificacaoOK);
			this.Controls.Add(this.BntQualificacaoCancel);
			this.Controls.Add(this.TxtContatoRep);
			this.Controls.Add(this.LblContatoRep);
			this.Controls.Add(this.TxtContatoPJ);
			this.Controls.Add(this.LblContatoPJ);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "QualificationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Qualificação PJ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblContatoPJ;
		private System.Windows.Forms.TextBox TxtContatoPJ;
		private System.Windows.Forms.TextBox TxtContatoRep;
		private System.Windows.Forms.Label LblContatoRep;
		private System.Windows.Forms.Button BntQualificacaoCancel;
		private System.Windows.Forms.Button BntQualificacaoOK;
	}
}