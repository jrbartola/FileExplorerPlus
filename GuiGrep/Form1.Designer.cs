namespace GuiGrep
{
    partial class GuiGrepForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiGrepForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathField = new System.Windows.Forms.TextBox();
            this.fileBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "saveicon.png");
            this.imageList1.Images.SetKeyName(2, "exploreicon.ico");
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(51, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "<<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(69, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(51, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(550, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(68, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(124, 17);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Path:";
            // 
            // pathField
            // 
            this.pathField.Location = new System.Drawing.Point(162, 14);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(382, 20);
            this.pathField.TabIndex = 4;
            this.pathField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathField_KeyDown);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Location = new System.Drawing.Point(12, 41);
            this.fileBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(606, 440);
            this.fileBrowser.TabIndex = 5;
            // 
            // GuiGrepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 493);
            this.Controls.Add(this.fileBrowser);
            this.Controls.Add(this.pathField);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "GuiGrepForm";
            this.Text = "GUI GREP";
            this.Load += new System.EventHandler(this.GuiGrepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.WebBrowser fileBrowser;
    }
}

