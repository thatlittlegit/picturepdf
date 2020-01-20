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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FileLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scaleBox = new System.Windows.Forms.GroupBox();
            this.ScaleControl = new System.Windows.Forms.NumericUpDown();
            this.Xlabel = new System.Windows.Forms.Label();
            this.xBar = new System.Windows.Forms.TrackBar();
            this.Workspace = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Page = new System.Windows.Forms.Panel();
            this.Ylabel = new System.Windows.Forms.Label();
            this.yBar = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.previousFileButton = new System.Windows.Forms.ToolStripButton();
            this.nextFileButton = new System.Windows.Forms.ToolStripButton();
            this.pdfGeneratingButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.scaleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBar)).BeginInit();
            this.Workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileLabel});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // FileLabel
            // 
            resources.ApplyResources(this.FileLabel, "FileLabel");
            this.FileLabel.Name = "FileLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.scaleBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Xlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Workspace, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Ylabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.yBar, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // scaleBox
            // 
            resources.ApplyResources(this.scaleBox, "scaleBox");
            this.scaleBox.Controls.Add(this.ScaleControl);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.TabStop = false;
            // 
            // ScaleControl
            // 
            resources.ApplyResources(this.ScaleControl, "ScaleControl");
            this.ScaleControl.DecimalPlaces = 1;
            this.ScaleControl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleControl.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ScaleControl.Name = "ScaleControl";
            this.ScaleControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleControl.ValueChanged += new System.EventHandler(this.ScaleChanged);
            // 
            // Xlabel
            // 
            resources.ApplyResources(this.Xlabel, "Xlabel");
            this.Xlabel.Name = "Xlabel";
            // 
            // xBar
            // 
            resources.ApplyResources(this.xBar, "xBar");
            this.xBar.Maximum = 500;
            this.xBar.Minimum = -500;
            this.xBar.Name = "xBar";
            this.xBar.TickFrequency = 20;
            this.xBar.ValueChanged += new System.EventHandler(this.UpdateXOffset);
            // 
            // Workspace
            // 
            resources.ApplyResources(this.Workspace, "Workspace");
            this.Workspace.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Workspace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.Workspace, 6);
            this.Workspace.Controls.Add(this.PictureBox);
            this.Workspace.Controls.Add(this.Page);
            this.Workspace.Name = "Workspace";
            // 
            // PictureBox
            // 
            resources.ApplyResources(this.PictureBox, "PictureBox");
            this.PictureBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.TabStop = false;
            // 
            // Page
            // 
            resources.ApplyResources(this.Page, "Page");
            this.Page.BackColor = System.Drawing.Color.White;
            this.Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Page.Name = "Page";
            // 
            // Ylabel
            // 
            resources.ApplyResources(this.Ylabel, "Ylabel");
            this.Ylabel.Name = "Ylabel";
            // 
            // yBar
            // 
            resources.ApplyResources(this.yBar, "yBar");
            this.yBar.Maximum = 500;
            this.yBar.Minimum = -500;
            this.yBar.Name = "yBar";
            this.yBar.TickFrequency = 40;
            this.yBar.ValueChanged += new System.EventHandler(this.UpdateYOffset);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousFileButton,
            this.nextFileButton,
            this.pdfGeneratingButton,
            this.openButton});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Stretch = true;
            // 
            // previousFileButton
            // 
            resources.ApplyResources(this.previousFileButton, "previousFileButton");
            this.previousFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousFileButton.Name = "previousFileButton";
            // 
            // nextFileButton
            // 
            resources.ApplyResources(this.nextFileButton, "nextFileButton");
            this.nextFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextFileButton.Name = "nextFileButton";
            // 
            // pdfGeneratingButton
            // 
            resources.ApplyResources(this.pdfGeneratingButton, "pdfGeneratingButton");
            this.pdfGeneratingButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pdfGeneratingButton.Name = "pdfGeneratingButton";
            this.pdfGeneratingButton.Click += new System.EventHandler(this.MakePdfButtonPressed);
            // 
            // openButton
            // 
            resources.ApplyResources(this.openButton, "openButton");
            this.openButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Name = "openButton";
            this.openButton.Click += new System.EventHandler(this.OpenImageDialog);
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.UpdateAll);
            this.Resize += new System.EventHandler(this.UpdateAll);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.scaleBox.ResumeLayout(false);
            this.scaleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBar)).EndInit();
            this.Workspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.TrackBar xBar;
        private System.Windows.Forms.TrackBar yBar;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Panel Workspace;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox scaleBox;
        private System.Windows.Forms.NumericUpDown ScaleControl;
        private System.Windows.Forms.Panel Page;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton previousFileButton;
        private System.Windows.Forms.ToolStripButton nextFileButton;
        private System.Windows.Forms.ToolStripButton pdfGeneratingButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FileLabel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

