namespace PicturePDF
{
	partial class MainWindow
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
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			statusStrip1 = new System.Windows.Forms.StatusStrip();
			FileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			scaleBox = new System.Windows.Forms.GroupBox();
			ScaleControl = new System.Windows.Forms.NumericUpDown();
			Xlabel = new System.Windows.Forms.Label();
			xBar = new System.Windows.Forms.TrackBar();
			Ylabel = new System.Windows.Forms.Label();
			yBar = new System.Windows.Forms.TrackBar();
			pageView1 = new PageView();
			toolStrip1 = new System.Windows.Forms.ToolStrip();
			previousFileButton = new System.Windows.Forms.ToolStripButton();
			nextFileButton = new System.Windows.Forms.ToolStripButton();
			pdfGeneratingButton = new System.Windows.Forms.ToolStripButton();
			openButton = new System.Windows.Forms.ToolStripButton();
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			toolStripContainer1.ContentPanel.SuspendLayout();
			toolStripContainer1.TopToolStripPanel.SuspendLayout();
			toolStripContainer1.SuspendLayout();
			statusStrip1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			scaleBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ScaleControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)xBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)yBar).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
			// 
			// toolStripContainer1.ContentPanel
			// 
			toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
			resources.ApplyResources(toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
			resources.ApplyResources(toolStripContainer1, "toolStripContainer1");
			toolStripContainer1.Name = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
			// 
			// statusStrip1
			// 
			resources.ApplyResources(statusStrip1, "statusStrip1");
			statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { FileLabel });
			statusStrip1.Name = "statusStrip1";
			// 
			// FileLabel
			// 
			FileLabel.Name = "FileLabel";
			resources.ApplyResources(FileLabel, "FileLabel");
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
			tableLayoutPanel1.Controls.Add(scaleBox, 4, 0);
			tableLayoutPanel1.Controls.Add(Xlabel, 0, 0);
			tableLayoutPanel1.Controls.Add(xBar, 1, 0);
			tableLayoutPanel1.Controls.Add(Ylabel, 2, 0);
			tableLayoutPanel1.Controls.Add(yBar, 3, 0);
			tableLayoutPanel1.Controls.Add(pageView1, 0, 1);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// scaleBox
			// 
			resources.ApplyResources(scaleBox, "scaleBox");
			scaleBox.Controls.Add(ScaleControl);
			scaleBox.Name = "scaleBox";
			scaleBox.TabStop = false;
			// 
			// ScaleControl
			// 
			resources.ApplyResources(ScaleControl, "ScaleControl");
			ScaleControl.DecimalPlaces = 1;
			ScaleControl.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			ScaleControl.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
			ScaleControl.Name = "ScaleControl";
			ScaleControl.Value = new decimal(new int[] { 1, 0, 0, 0 });
			ScaleControl.ValueChanged += ScaleChanged;
			// 
			// Xlabel
			// 
			resources.ApplyResources(Xlabel, "Xlabel");
			Xlabel.Name = "Xlabel";
			// 
			// xBar
			// 
			resources.ApplyResources(xBar, "xBar");
			xBar.Maximum = 500;
			xBar.Minimum = -500;
			xBar.Name = "xBar";
			xBar.TickFrequency = 20;
			xBar.ValueChanged += UpdateXOffset;
			// 
			// Ylabel
			// 
			resources.ApplyResources(Ylabel, "Ylabel");
			Ylabel.Name = "Ylabel";
			// 
			// yBar
			// 
			resources.ApplyResources(yBar, "yBar");
			yBar.Maximum = 500;
			yBar.Minimum = -500;
			yBar.Name = "yBar";
			yBar.TickFrequency = 40;
			yBar.ValueChanged += UpdateYOffset;
			// 
			// pageView1
			// 
			tableLayoutPanel1.SetColumnSpan(pageView1, 6);
			resources.ApplyResources(pageView1, "pageView1");
			pageView1.Name = "pageView1";
			// 
			// toolStrip1
			// 
			resources.ApplyResources(toolStrip1, "toolStrip1");
			toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { previousFileButton, nextFileButton, pdfGeneratingButton, openButton });
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Stretch = true;
			// 
			// previousFileButton
			// 
			previousFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(previousFileButton, "previousFileButton");
			previousFileButton.Name = "previousFileButton";
			// 
			// nextFileButton
			// 
			nextFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(nextFileButton, "nextFileButton");
			nextFileButton.Name = "nextFileButton";
			// 
			// pdfGeneratingButton
			// 
			pdfGeneratingButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			resources.ApplyResources(pdfGeneratingButton, "pdfGeneratingButton");
			pdfGeneratingButton.Name = "pdfGeneratingButton";
			pdfGeneratingButton.Click += MakePdfButtonPressed;
			// 
			// openButton
			// 
			openButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(openButton, "openButton");
			openButton.Name = "openButton";
			openButton.Click += OpenImageDialog;
			// 
			// MainWindow
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(toolStripContainer1);
			DoubleBuffered = true;
			Name = "MainWindow";
			Layout += UpdateAll;
			Resize += UpdateAll;
			toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer1.BottomToolStripPanel.PerformLayout();
			toolStripContainer1.ContentPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.PerformLayout();
			toolStripContainer1.ResumeLayout(false);
			toolStripContainer1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			scaleBox.ResumeLayout(false);
			scaleBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ScaleControl).EndInit();
			((System.ComponentModel.ISupportInitialize)xBar).EndInit();
			((System.ComponentModel.ISupportInitialize)yBar).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Xlabel;
		private System.Windows.Forms.TrackBar xBar;
		private System.Windows.Forms.TrackBar yBar;
		private System.Windows.Forms.Label Ylabel;
		private System.Windows.Forms.GroupBox scaleBox;
		private System.Windows.Forms.NumericUpDown ScaleControl;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton previousFileButton;
		private System.Windows.Forms.ToolStripButton nextFileButton;
		private System.Windows.Forms.ToolStripButton pdfGeneratingButton;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel FileLabel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private PageView pageView1;
	}
}

