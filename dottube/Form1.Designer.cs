namespace dottube
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxVideoInformation = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelShowDuration = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelVideoDescription = new System.Windows.Forms.Label();
            this.labelShowFileName = new System.Windows.Forms.Label();
            this.labelShowFormatID = new System.Windows.Forms.Label();
            this.labelShowVideoURL = new System.Windows.Forms.Label();
            this.labelShowVideoTitle = new System.Windows.Forms.Label();
            this.labelShowVideoID = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFormatID = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelVideoTitle = new System.Windows.Forms.Label();
            this.labelVideoID = new System.Windows.Forms.Label();
            this.labelTextBoxURL = new System.Windows.Forms.Label();
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBoxThumbnail = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageYouTube.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxVideoInformation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageYouTube);
            this.tabControlMain.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPageYouTube
            // 
            this.tabPageYouTube.Controls.Add(this.propertyGrid1);
            this.tabPageYouTube.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPageYouTube, "tabPageYouTube");
            this.tabPageYouTube.Name = "tabPageYouTube";
            this.tabPageYouTube.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            resources.ApplyResources(this.propertyGrid1, "propertyGrid1");
            this.propertyGrid1.Name = "propertyGrid1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.groupBoxVideoInformation);
            this.groupBox2.Controls.Add(this.labelTextBoxURL);
            this.groupBox2.Controls.Add(this.buttonGetInfo);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBoxVideoInformation
            // 
            this.groupBoxVideoInformation.Controls.Add(this.pictureBoxThumbnail);
            this.groupBoxVideoInformation.Controls.Add(this.richTextBoxDescription);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowDuration);
            this.groupBoxVideoInformation.Controls.Add(this.labelDuration);
            this.groupBoxVideoInformation.Controls.Add(this.labelVideoDescription);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowFileName);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowFormatID);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowVideoURL);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowVideoTitle);
            this.groupBoxVideoInformation.Controls.Add(this.labelShowVideoID);
            this.groupBoxVideoInformation.Controls.Add(this.labelFileName);
            this.groupBoxVideoInformation.Controls.Add(this.labelFormatID);
            this.groupBoxVideoInformation.Controls.Add(this.labelURL);
            this.groupBoxVideoInformation.Controls.Add(this.labelVideoTitle);
            this.groupBoxVideoInformation.Controls.Add(this.labelVideoID);
            resources.ApplyResources(this.groupBoxVideoInformation, "groupBoxVideoInformation");
            this.groupBoxVideoInformation.Name = "groupBoxVideoInformation";
            this.groupBoxVideoInformation.TabStop = false;
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
            // labelShowFormatID
            // 
            resources.ApplyResources(this.labelShowFormatID, "labelShowFormatID");
            this.labelShowFormatID.Name = "labelShowFormatID";
            // 
            // labelShowVideoURL
            // 
            resources.ApplyResources(this.labelShowVideoURL, "labelShowVideoURL");
            this.labelShowVideoURL.Name = "labelShowVideoURL";
            // 
            // labelShowVideoTitle
            // 
            resources.ApplyResources(this.labelShowVideoTitle, "labelShowVideoTitle");
            this.labelShowVideoTitle.Name = "labelShowVideoTitle";
            // 
            // labelShowVideoID
            // 
            resources.ApplyResources(this.labelShowVideoID, "labelShowVideoID");
            this.labelShowVideoID.Name = "labelShowVideoID";
            // 
            // labelFileName
            // 
            resources.ApplyResources(this.labelFileName, "labelFileName");
            this.labelFileName.Name = "labelFileName";
            // 
            // labelFormatID
            // 
            resources.ApplyResources(this.labelFormatID, "labelFormatID");
            this.labelFormatID.Name = "labelFormatID";
            // 
            // labelURL
            // 
            resources.ApplyResources(this.labelURL, "labelURL");
            this.labelURL.Name = "labelURL";
            // 
            // labelVideoTitle
            // 
            resources.ApplyResources(this.labelVideoTitle, "labelVideoTitle");
            this.labelVideoTitle.Name = "labelVideoTitle";
            // 
            // labelVideoID
            // 
            resources.ApplyResources(this.labelVideoID, "labelVideoID");
            this.labelVideoID.Name = "labelVideoID";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.listView1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pictureBoxThumbnail
            // 
            resources.ApplyResources(this.pictureBoxThumbnail, "pictureBoxThumbnail");
            this.pictureBoxThumbnail.Name = "pictureBoxThumbnail";
            this.pictureBoxThumbnail.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // formMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Name = "formMainForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageYouTube.ResumeLayout(false);
            this.tabPageYouTube.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxVideoInformation.ResumeLayout(false);
            this.groupBoxVideoInformation.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageYouTube;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxVideoInformation;
        private System.Windows.Forms.Label labelVideoDescription;
        private System.Windows.Forms.Label labelShowFileName;
        private System.Windows.Forms.Label labelShowFormatID;
        private System.Windows.Forms.Label labelShowVideoURL;
        private System.Windows.Forms.Label labelShowVideoTitle;
        private System.Windows.Forms.Label labelShowVideoID;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFormatID;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelVideoTitle;
        private System.Windows.Forms.Label labelVideoID;
        private System.Windows.Forms.Label labelTextBoxURL;
        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelShowDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBoxThumbnail;
        private System.Windows.Forms.ListBox listBox1;
    }
}

