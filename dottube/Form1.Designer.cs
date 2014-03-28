namespace Dottube
{
    partial class formMainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageYouTube = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.listViewPlayList = new System.Windows.Forms.ListView();
            this.columnHeaderSelect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUploader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateExe = new System.Windows.Forms.Button();
            this.groupBoxVideoInformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelShowDuration = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelVideoDescription = new System.Windows.Forms.Label();
            this.labelShowFileName = new System.Windows.Forms.Label();
            this.labelShowVideoTitle = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelVideoTitle = new System.Windows.Forms.Label();
            this.labelTextBoxURL = new System.Windows.Forms.Label();
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxThumbNail = new System.Windows.Forms.PictureBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageYouTube.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxVideoInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbNail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageYouTube);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPageYouTube
            // 
            this.tabPageYouTube.Controls.Add(this.groupBox1);
            this.tabPageYouTube.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPageYouTube, "tabPageYouTube");
            this.tabPageYouTube.Name = "tabPageYouTube";
            this.tabPageYouTube.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRemoveSelected);
            this.groupBox1.Controls.Add(this.progressBarDownload);
            this.groupBox1.Controls.Add(this.buttonDownload);
            this.groupBox1.Controls.Add(this.listViewPlayList);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // progressBarDownload
            // 
            resources.ApplyResources(this.progressBarDownload, "progressBarDownload");
            this.progressBarDownload.MarqueeAnimationSpeed = 30;
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // buttonDownload
            // 
            resources.ApplyResources(this.buttonDownload, "buttonDownload");
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // listViewPlayList
            // 
            this.listViewPlayList.CheckBoxes = true;
            this.listViewPlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSelect,
            this.columnHeaderTitle,
            this.columnHeaderUploader,
            this.columnHeaderDuration,
            this.columnHeaderUrl});
            this.listViewPlayList.FullRowSelect = true;
            resources.ApplyResources(this.listViewPlayList, "listViewPlayList");
            this.listViewPlayList.Name = "listViewPlayList";
            this.listViewPlayList.UseCompatibleStateImageBehavior = false;
            this.listViewPlayList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSelect
            // 
            resources.ApplyResources(this.columnHeaderSelect, "columnHeaderSelect");
            // 
            // columnHeaderTitle
            // 
            resources.ApplyResources(this.columnHeaderTitle, "columnHeaderTitle");
            // 
            // columnHeaderUploader
            // 
            resources.ApplyResources(this.columnHeaderUploader, "columnHeaderUploader");
            // 
            // columnHeaderDuration
            // 
            resources.ApplyResources(this.columnHeaderDuration, "columnHeaderDuration");
            // 
            // columnHeaderUrl
            // 
            resources.ApplyResources(this.columnHeaderUrl, "columnHeaderUrl");
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.buttonUpdateExe);
            this.groupBox2.Controls.Add(this.groupBoxVideoInformation);
            this.groupBox2.Controls.Add(this.labelTextBoxURL);
            this.groupBox2.Controls.Add(this.buttonGetInfo);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonUpdateExe
            // 
            resources.ApplyResources(this.buttonUpdateExe, "buttonUpdateExe");
            this.buttonUpdateExe.Name = "buttonUpdateExe";
            this.buttonUpdateExe.UseVisualStyleBackColor = true;
            this.buttonUpdateExe.Click += new System.EventHandler(this.buttonUpdateExe_Click);
            // 
            // groupBoxVideoInformation
            // 
            this.groupBoxVideoInformation.Controls.Add(this.pictureBoxThumbNail);
            this.groupBoxVideoInformation.Controls.Add(this.label1);
            this.groupBoxVideoInformation.Controls.Add(this.richTextBoxDescription);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowDuration);
            this.groupBoxVideoInformation.Controls.Add(this.labelDuration);
            this.groupBoxVideoInformation.Controls.Add(this.labelVideoDescription);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowFileName);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowVideoTitle);
            this.groupBoxVideoInformation.Controls.Add(this.labelFileName);
            this.groupBoxVideoInformation.Controls.Add(this.labelVideoTitle);
            resources.ApplyResources(this.groupBoxVideoInformation, "groupBoxVideoInformation");
            this.groupBoxVideoInformation.Name = "groupBoxVideoInformation";
            this.groupBoxVideoInformation.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // richTextBoxDescription
            // 
            resources.ApplyResources(this.richTextBoxDescription, "richTextBoxDescription");
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            // 
            // labelShowDuration
            // 
            resources.ApplyResources(this.labelShowDuration, "labelShowDuration");
            this.labelShowDuration.Name = "labelShowDuration";
            // 
            // labelDuration
            // 
            resources.ApplyResources(this.labelDuration, "labelDuration");
            this.labelDuration.Name = "labelDuration";
            // 
            // labelVideoDescription
            // 
            resources.ApplyResources(this.labelVideoDescription, "labelVideoDescription");
            this.labelVideoDescription.Name = "labelVideoDescription";
            // 
            // labelShowFileName
            // 
            resources.ApplyResources(this.labelShowFileName, "labelShowFileName");
            this.labelShowFileName.Name = "labelShowFileName";
            // 
            // labelShowVideoTitle
            // 
            resources.ApplyResources(this.labelShowVideoTitle, "labelShowVideoTitle");
            this.labelShowVideoTitle.Name = "labelShowVideoTitle";
            // 
            // labelFileName
            // 
            resources.ApplyResources(this.labelFileName, "labelFileName");
            this.labelFileName.Name = "labelFileName";
            // 
            // labelVideoTitle
            // 
            resources.ApplyResources(this.labelVideoTitle, "labelVideoTitle");
            this.labelVideoTitle.Name = "labelVideoTitle";
            // 
            // labelTextBoxURL
            // 
            resources.ApplyResources(this.labelTextBoxURL, "labelTextBoxURL");
            this.labelTextBoxURL.Name = "labelTextBoxURL";
            // 
            // buttonGetInfo
            // 
            resources.ApplyResources(this.buttonGetInfo, "buttonGetInfo");
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.UseVisualStyleBackColor = true;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // pictureBoxThumbNail
            // 
            resources.ApplyResources(this.pictureBoxThumbNail, "pictureBoxThumbNail");
            this.pictureBoxThumbNail.Name = "pictureBoxThumbNail";
            this.pictureBoxThumbNail.TabStop = false;
            // 
            // buttonRemoveSelected
            // 
            resources.ApplyResources(this.buttonRemoveSelected, "buttonRemoveSelected");
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // formMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.MaximizeBox = false;
            this.Name = "formMainForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageYouTube.ResumeLayout(false);
            this.tabPageYouTube.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxVideoInformation.ResumeLayout(false);
            this.groupBoxVideoInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbNail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageYouTube;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxVideoInformation;
        private System.Windows.Forms.Label labelVideoDescription;
        private System.Windows.Forms.Label labelShowFileName;
        private System.Windows.Forms.Label labelShowVideoTitle;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelVideoTitle;
        private System.Windows.Forms.Label labelTextBoxURL;
        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelShowDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonUpdateExe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.ListView listViewPlayList;
        private System.Windows.Forms.ColumnHeader columnHeaderSelect;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderUploader;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxThumbNail;
        private System.Windows.Forms.Button buttonRemoveSelected;
    }
}

