namespace testOne
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.networks = new System.Windows.Forms.Button();
            this.Applications = new System.Windows.Forms.Button();
            this.deviceOptions = new System.Windows.Forms.Button();
            this.bootOptions = new System.Windows.Forms.Button();
            this.taskbar = new System.Windows.Forms.Button();
            this.loadConfig = new System.Windows.Forms.Button();
            this.startMenu = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Apply = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.etcToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.actionToolStripMenuItem.Text = "Export";
            this.actionToolStripMenuItem.Click += new System.EventHandler(this.actionToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.exportToolStripMenuItem.Text = "Json";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // etcToolStripMenuItem
            // 
            this.etcToolStripMenuItem.Name = "etcToolStripMenuItem";
            this.etcToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.etcToolStripMenuItem.Text = "etc";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectPageToolStripMenuItem,
            this.deselectPageToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectPageToolStripMenuItem
            // 
            this.selectPageToolStripMenuItem.Name = "selectPageToolStripMenuItem";
            this.selectPageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.selectPageToolStripMenuItem.Text = "Select Page";
            this.selectPageToolStripMenuItem.Click += new System.EventHandler(this.selectPageToolStripMenuItem_Click);
            // 
            // deselectPageToolStripMenuItem
            // 
            this.deselectPageToolStripMenuItem.Name = "deselectPageToolStripMenuItem";
            this.deselectPageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deselectPageToolStripMenuItem.Text = "Deselect Page";
            this.deselectPageToolStripMenuItem.Click += new System.EventHandler(this.deselectPageToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Location = new System.Drawing.Point(808, 489);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(116, 29);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.networks);
            this.panel1.Controls.Add(this.Applications);
            this.panel1.Controls.Add(this.deviceOptions);
            this.panel1.Controls.Add(this.bootOptions);
            this.panel1.Controls.Add(this.taskbar);
            this.panel1.Controls.Add(this.loadConfig);
            this.panel1.Controls.Add(this.startMenu);
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 507);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // networks
            // 
            this.networks.Location = new System.Drawing.Point(12, 263);
            this.networks.Name = "networks";
            this.networks.Size = new System.Drawing.Size(192, 35);
            this.networks.TabIndex = 8;
            this.networks.Text = "Networks";
            this.networks.UseVisualStyleBackColor = true;
            this.networks.Click += new System.EventHandler(this.networks_Click);
            // 
            // Applications
            // 
            this.Applications.Location = new System.Drawing.Point(12, 222);
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(192, 35);
            this.Applications.TabIndex = 7;
            this.Applications.Text = "Applications";
            this.Applications.UseVisualStyleBackColor = true;
            this.Applications.Click += new System.EventHandler(this.Applications_Click);
            // 
            // deviceOptions
            // 
            this.deviceOptions.Location = new System.Drawing.Point(12, 345);
            this.deviceOptions.Name = "deviceOptions";
            this.deviceOptions.Size = new System.Drawing.Size(192, 35);
            this.deviceOptions.TabIndex = 6;
            this.deviceOptions.Text = "Device Options";
            this.deviceOptions.UseVisualStyleBackColor = true;
            this.deviceOptions.Click += new System.EventHandler(this.deviceOptions_Click);
            // 
            // bootOptions
            // 
            this.bootOptions.Location = new System.Drawing.Point(12, 304);
            this.bootOptions.Name = "bootOptions";
            this.bootOptions.Size = new System.Drawing.Size(192, 35);
            this.bootOptions.TabIndex = 5;
            this.bootOptions.Text = "Boot Options";
            this.bootOptions.UseVisualStyleBackColor = true;
            this.bootOptions.Click += new System.EventHandler(this.bootOptions_Click);
            // 
            // taskbar
            // 
            this.taskbar.Location = new System.Drawing.Point(12, 99);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(192, 35);
            this.taskbar.TabIndex = 4;
            this.taskbar.Text = "Taskbar";
            this.taskbar.UseVisualStyleBackColor = true;
            this.taskbar.Click += new System.EventHandler(this.taskbar_Click);
            // 
            // loadConfig
            // 
            this.loadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadConfig.Location = new System.Drawing.Point(12, 453);
            this.loadConfig.Name = "loadConfig";
            this.loadConfig.Size = new System.Drawing.Size(192, 35);
            this.loadConfig.TabIndex = 3;
            this.loadConfig.Text = "Load Config";
            this.loadConfig.UseVisualStyleBackColor = true;
            this.loadConfig.Click += new System.EventHandler(this.loadConfig_Click);
            // 
            // startMenu
            // 
            this.startMenu.Location = new System.Drawing.Point(12, 181);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(192, 35);
            this.startMenu.TabIndex = 2;
            this.startMenu.Text = "Start Menu";
            this.startMenu.UseVisualStyleBackColor = true;
            this.startMenu.Click += new System.EventHandler(this.startMenu_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 140);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(192, 35);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Text = "Web browser";
            this.webBrowser.UseVisualStyleBackColor = true;
            this.webBrowser.Click += new System.EventHandler(this.webBrowser_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(240, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 441);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Path";
            this.columnHeader2.Width = 539;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Apply
            // 
            this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Apply.Location = new System.Drawing.Point(672, 489);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(121, 29);
            this.Apply.TabIndex = 6;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(936, 531);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button loadConfig;
        private System.Windows.Forms.Button startMenu;
        private System.Windows.Forms.Button webBrowser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button taskbar;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etcToolStripMenuItem;
        private System.Windows.Forms.Button bootOptions;
        private System.Windows.Forms.Button deviceOptions;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Applications;
        private System.Windows.Forms.Button networks;
    }
}

