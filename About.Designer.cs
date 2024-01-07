namespace PicturePDF
{
	partial class About
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
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
			tableLayoutPanel1.Controls.Add(label1, 1, 0);
			tableLayoutPanel1.Controls.Add(button1, 1, 2);
			tableLayoutPanel1.Controls.Add(label2, 0, 0);
			tableLayoutPanel1.Controls.Add(label3, 1, 1);
			tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			tableLayoutPanel1.Size = new System.Drawing.Size(885, 336);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			label1.Location = new System.Drawing.Point(91, 54);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(117, 30);
			label1.TabIndex = 1;
			label1.Text = "PicturePDF";
			// 
			// button1
			// 
			button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			button1.Location = new System.Drawing.Point(760, 298);
			button1.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(112, 34);
			button1.TabIndex = 0;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = System.Windows.Forms.DockStyle.Fill;
			label2.Image = (System.Drawing.Image)resources.GetObject("label2.Image");
			label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			label2.Location = new System.Drawing.Point(3, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(82, 84);
			label2.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(91, 84);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(726, 175);
			label3.TabIndex = 3;
			label3.Text = resources.GetString("label3.Text");
			// 
			// About
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(885, 336);
			Controls.Add(tableLayoutPanel1);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Name = "About";
			Text = "About";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}