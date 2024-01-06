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
			zoomLabel = new System.Windows.Forms.ToolStripDropDownButton();
			pageView = new PageView();
			toolStrip1 = new System.Windows.Forms.ToolStrip();
			previousFileButton = new System.Windows.Forms.ToolStripButton();
			openButton = new System.Windows.Forms.ToolStripButton();
			nextFileButton = new System.Windows.Forms.ToolStripButton();
			pdfGeneratingButton = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			addAdditionalImageButton = new System.Windows.Forms.ToolStripButton();
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			toolStripContainer1.ContentPanel.SuspendLayout();
			toolStripContainer1.TopToolStripPanel.SuspendLayout();
			toolStripContainer1.SuspendLayout();
			statusStrip1.SuspendLayout();
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
			toolStripContainer1.ContentPanel.Controls.Add(pageView);
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
			statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { FileLabel, zoomLabel });
			statusStrip1.Name = "statusStrip1";
			// 
			// FileLabel
			// 
			FileLabel.Name = "FileLabel";
			resources.ApplyResources(FileLabel, "FileLabel");
			FileLabel.Spring = true;
			// 
			// zoomLabel
			// 
			zoomLabel.Name = "zoomLabel";
			zoomLabel.ShowDropDownArrow = false;
			resources.ApplyResources(zoomLabel, "zoomLabel");
			zoomLabel.DropDownItemClicked += zoomLabel_DropDownItemClicked;
			// 
			// pageView
			// 
			resources.ApplyResources(pageView, "pageView");
			pageView.Model = null;
			pageView.Name = "pageView";
			pageView.ZoomFactor = 1F;
			pageView.ZoomFactorChanged += pageView_ZoomFactorChanged;
			// 
			// toolStrip1
			// 
			resources.ApplyResources(toolStrip1, "toolStrip1");
			toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { previousFileButton, openButton, nextFileButton, pdfGeneratingButton, toolStripSeparator1, addAdditionalImageButton });
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Stretch = true;
			// 
			// previousFileButton
			// 
			previousFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(previousFileButton, "previousFileButton");
			previousFileButton.Name = "previousFileButton";
			// 
			// openButton
			// 
			openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(openButton, "openButton");
			openButton.Name = "openButton";
			openButton.Click += openButton_Click;
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
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
			// 
			// addAdditionalImageButton
			// 
			resources.ApplyResources(addAdditionalImageButton, "addAdditionalImageButton");
			addAdditionalImageButton.Name = "addAdditionalImageButton";
			addAdditionalImageButton.Click += addAdditionalImageButton_Click;
			// 
			// MainWindow
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(toolStripContainer1);
			DoubleBuffered = true;
			Name = "MainWindow";
			toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer1.BottomToolStripPanel.PerformLayout();
			toolStripContainer1.ContentPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.PerformLayout();
			toolStripContainer1.ResumeLayout(false);
			toolStripContainer1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton previousFileButton;
		private System.Windows.Forms.ToolStripButton nextFileButton;
		private System.Windows.Forms.ToolStripButton pdfGeneratingButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel FileLabel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripDropDownButton zoomLabel;
		private PageView pageView;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton addAdditionalImageButton;
	}
}

