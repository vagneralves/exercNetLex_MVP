namespace exercNetLex
{
	partial class FrmAddField
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddField));
			this.TxtAddField = new System.Windows.Forms.TextBox();
			this.LblAddField = new System.Windows.Forms.Label();
			this.BntAddFieldCancel = new System.Windows.Forms.Button();
			this.BntAddFieldOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtAddField
			// 
			this.TxtAddField.Location = new System.Drawing.Point(35, 64);
			this.TxtAddField.Name = "TxtAddField";
			this.TxtAddField.Size = new System.Drawing.Size(262, 22);
			this.TxtAddField.TabIndex = 0;
			// 
			// LblAddField
			// 
			this.LblAddField.AutoSize = true;
			this.LblAddField.Location = new System.Drawing.Point(32, 34);
			this.LblAddField.Name = "LblAddField";
			this.LblAddField.Size = new System.Drawing.Size(129, 17);
			this.LblAddField.TabIndex = 1;
			this.LblAddField.Text = "Digite a expressão:";
			// 
			// BntAddFieldCancel
			// 
			this.BntAddFieldCancel.Location = new System.Drawing.Point(35, 124);
			this.BntAddFieldCancel.Name = "BntAddFieldCancel";
			this.BntAddFieldCancel.Size = new System.Drawing.Size(75, 23);
			this.BntAddFieldCancel.TabIndex = 2;
			this.BntAddFieldCancel.Text = "Cancelar";
			this.BntAddFieldCancel.UseVisualStyleBackColor = true;
			this.BntAddFieldCancel.Click += new System.EventHandler(this.BntAddFieldCancel_Click);
			// 
			// BntAddFieldOk
			// 
			this.BntAddFieldOk.Location = new System.Drawing.Point(222, 124);
			this.BntAddFieldOk.Name = "BntAddFieldOk";
			this.BntAddFieldOk.Size = new System.Drawing.Size(75, 23);
			this.BntAddFieldOk.TabIndex = 3;
			this.BntAddFieldOk.Text = "OK";
			this.BntAddFieldOk.UseVisualStyleBackColor = true;
			this.BntAddFieldOk.Click += new System.EventHandler(this.BntAddFieldOk_Click);
			// 
			// FrmAddField
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 177);
			this.Controls.Add(this.BntAddFieldOk);
			this.Controls.Add(this.BntAddFieldCancel);
			this.Controls.Add(this.LblAddField);
			this.Controls.Add(this.TxtAddField);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAddField";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Field";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LblAddField;
		private System.Windows.Forms.Button BntAddFieldCancel;
		private System.Windows.Forms.Button BntAddFieldOk;
		public System.Windows.Forms.TextBox TxtAddField;
	}
}