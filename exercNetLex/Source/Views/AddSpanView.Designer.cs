﻿namespace exercNetLex
{
	partial class AddSpanView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSpanView));
			this.BntAddSpanOk = new System.Windows.Forms.Button();
			this.BntAddSpanCancel = new System.Windows.Forms.Button();
			this.LblAddSpan = new System.Windows.Forms.Label();
			this.TxtAddSpan = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BntAddSpanOk
			// 
			this.BntAddSpanOk.Location = new System.Drawing.Point(172, 100);
			this.BntAddSpanOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BntAddSpanOk.Name = "BntAddSpanOk";
			this.BntAddSpanOk.Size = new System.Drawing.Size(56, 19);
			this.BntAddSpanOk.TabIndex = 7;
			this.BntAddSpanOk.Text = "OK";
			this.BntAddSpanOk.UseVisualStyleBackColor = true;
			this.BntAddSpanOk.Click += new System.EventHandler(this.BntAddSpanOk_Click);
			// 
			// BntAddSpanCancel
			// 
			this.BntAddSpanCancel.Location = new System.Drawing.Point(32, 100);
			this.BntAddSpanCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BntAddSpanCancel.Name = "BntAddSpanCancel";
			this.BntAddSpanCancel.Size = new System.Drawing.Size(56, 19);
			this.BntAddSpanCancel.TabIndex = 6;
			this.BntAddSpanCancel.Text = "Cancelar";
			this.BntAddSpanCancel.UseVisualStyleBackColor = true;
			this.BntAddSpanCancel.Click += new System.EventHandler(this.BntAddSpanCancel_Click);
			// 
			// LblAddSpan
			// 
			this.LblAddSpan.AutoSize = true;
			this.LblAddSpan.Location = new System.Drawing.Point(29, 27);
			this.LblAddSpan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAddSpan.Name = "LblAddSpan";
			this.LblAddSpan.Size = new System.Drawing.Size(97, 13);
			this.LblAddSpan.TabIndex = 5;
			this.LblAddSpan.Text = "Digite a expressão:";
			// 
			// TxtAddSpan
			// 
			this.TxtAddSpan.Location = new System.Drawing.Point(32, 51);
			this.TxtAddSpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TxtAddSpan.Name = "TxtAddSpan";
			this.TxtAddSpan.Size = new System.Drawing.Size(198, 20);
			this.TxtAddSpan.TabIndex = 4;
			// 
			// AddSpanView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 145);
			this.Controls.Add(this.BntAddSpanOk);
			this.Controls.Add(this.BntAddSpanCancel);
			this.Controls.Add(this.LblAddSpan);
			this.Controls.Add(this.TxtAddSpan);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AddSpanView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Span";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BntAddSpanOk;
		private System.Windows.Forms.Button BntAddSpanCancel;
		private System.Windows.Forms.Label LblAddSpan;
		public System.Windows.Forms.TextBox TxtAddSpan;
	}
}