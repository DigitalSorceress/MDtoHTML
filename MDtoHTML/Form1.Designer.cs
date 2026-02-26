namespace MDtoHTML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileOpenToolStripMenuItem = new ToolStripMenuItem();
            fileSaveAsToolStripMenuItem = new ToolStripMenuItem();
            fileExitToolStripMenuItem = new ToolStripMenuItem();
            markdownToolStripMenuItem = new ToolStripMenuItem();
            markdownWordWrapToolStripMenuItem = new ToolStripMenuItem();
            hTMLToolStripMenuItem = new ToolStripMenuItem();
            htmlCopyAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            htmlWordWrapToolStripMenuItem = new ToolStripMenuItem();
            htmlAutoNewLinesToolStripMenuItem = new ToolStripMenuItem();
            htmlAutoHyperlinkToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpAboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            btnMdWrap = new ToolStripButton();
            btnHtmlWrap = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnCopyHtml = new ToolStripButton();
            btnSaveAs = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            textBoxMarkdown = new TextBox();
            textBoxHtml = new TextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, markdownToolStripMenuItem, hTMLToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileOpenToolStripMenuItem, fileSaveAsToolStripMenuItem, fileExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // fileOpenToolStripMenuItem
            // 
            fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            fileOpenToolStripMenuItem.Size = new Size(180, 22);
            fileOpenToolStripMenuItem.Text = "&Open";
            fileOpenToolStripMenuItem.Click += fileOpen_Click;
            // 
            // fileSaveAsToolStripMenuItem
            // 
            fileSaveAsToolStripMenuItem.Name = "fileSaveAsToolStripMenuItem";
            fileSaveAsToolStripMenuItem.Size = new Size(180, 22);
            fileSaveAsToolStripMenuItem.Text = "Save &As ...";
            fileSaveAsToolStripMenuItem.Click += fileSaveAs_Click;
            // 
            // fileExitToolStripMenuItem
            // 
            fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            fileExitToolStripMenuItem.Size = new Size(180, 22);
            fileExitToolStripMenuItem.Text = "E&xit";
            fileExitToolStripMenuItem.Click += fileExit_Click;
            // 
            // markdownToolStripMenuItem
            // 
            markdownToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { markdownWordWrapToolStripMenuItem });
            markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            markdownToolStripMenuItem.Size = new Size(76, 20);
            markdownToolStripMenuItem.Text = "&Markdown";
            // 
            // markdownWordWrapToolStripMenuItem
            // 
            markdownWordWrapToolStripMenuItem.Checked = true;
            markdownWordWrapToolStripMenuItem.CheckOnClick = true;
            markdownWordWrapToolStripMenuItem.CheckState = CheckState.Checked;
            markdownWordWrapToolStripMenuItem.Name = "markdownWordWrapToolStripMenuItem";
            markdownWordWrapToolStripMenuItem.Size = new Size(134, 22);
            markdownWordWrapToolStripMenuItem.Text = "&Word Wrap";
            markdownWordWrapToolStripMenuItem.Click += ToggleMarkdownWrap;
            // 
            // hTMLToolStripMenuItem
            // 
            hTMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { htmlCopyAllToolStripMenuItem, toolStripSeparator1, htmlWordWrapToolStripMenuItem, htmlAutoNewLinesToolStripMenuItem, htmlAutoHyperlinkToolStripMenuItem });
            hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            hTMLToolStripMenuItem.Size = new Size(52, 20);
            hTMLToolStripMenuItem.Text = "&HTML";
            // 
            // htmlCopyAllToolStripMenuItem
            // 
            htmlCopyAllToolStripMenuItem.Name = "htmlCopyAllToolStripMenuItem";
            htmlCopyAllToolStripMenuItem.Size = new Size(154, 22);
            htmlCopyAllToolStripMenuItem.Text = "&Copy All";
            htmlCopyAllToolStripMenuItem.Click += htmlCopyAll_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(151, 6);
            // 
            // htmlWordWrapToolStripMenuItem
            // 
            htmlWordWrapToolStripMenuItem.Checked = true;
            htmlWordWrapToolStripMenuItem.CheckState = CheckState.Checked;
            htmlWordWrapToolStripMenuItem.Name = "htmlWordWrapToolStripMenuItem";
            htmlWordWrapToolStripMenuItem.Size = new Size(154, 22);
            htmlWordWrapToolStripMenuItem.Text = "&Word Wrap";
            htmlWordWrapToolStripMenuItem.Click += ToggleHtmlWrap;
            // 
            // htmlAutoNewLinesToolStripMenuItem
            // 
            htmlAutoNewLinesToolStripMenuItem.Checked = true;
            htmlAutoNewLinesToolStripMenuItem.CheckState = CheckState.Checked;
            htmlAutoNewLinesToolStripMenuItem.Name = "htmlAutoNewLinesToolStripMenuItem";
            htmlAutoNewLinesToolStripMenuItem.Size = new Size(154, 22);
            htmlAutoNewLinesToolStripMenuItem.Text = "&BR on NewLine";
            htmlAutoNewLinesToolStripMenuItem.Click += ToggleAutoNewLine;
            // 
            // htmlAutoHyperlinkToolStripMenuItem
            // 
            htmlAutoHyperlinkToolStripMenuItem.Name = "htmlAutoHyperlinkToolStripMenuItem";
            htmlAutoHyperlinkToolStripMenuItem.Size = new Size(154, 22);
            htmlAutoHyperlinkToolStripMenuItem.Text = "Auto &Hyperlink";
            htmlAutoHyperlinkToolStripMenuItem.Click += ToggleHtmlAutoHyperLink;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpAboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Hel&p";
            // 
            // helpAboutToolStripMenuItem
            // 
            helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            helpAboutToolStripMenuItem.Size = new Size(107, 22);
            helpAboutToolStripMenuItem.Text = "&About";
            helpAboutToolStripMenuItem.Click += helpAbout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMdWrap, btnHtmlWrap, btnOpen, btnCopyHtml, btnSaveAs });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 31);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMdWrap
            // 
            btnMdWrap.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMdWrap.Image = (Image)resources.GetObject("btnMdWrap.Image");
            btnMdWrap.ImageTransparentColor = Color.Magenta;
            btnMdWrap.Name = "btnMdWrap";
            btnMdWrap.Size = new Size(28, 28);
            btnMdWrap.Text = "MD WordWrap";
            btnMdWrap.Click += ToggleMarkdownWrap;
            // 
            // btnHtmlWrap
            // 
            btnHtmlWrap.Alignment = ToolStripItemAlignment.Right;
            btnHtmlWrap.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHtmlWrap.Image = (Image)resources.GetObject("btnHtmlWrap.Image");
            btnHtmlWrap.ImageTransparentColor = Color.Magenta;
            btnHtmlWrap.Name = "btnHtmlWrap";
            btnHtmlWrap.Size = new Size(28, 28);
            btnHtmlWrap.Text = "HTML WordWrap";
            btnHtmlWrap.Click += ToggleHtmlWrap;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(28, 28);
            btnOpen.Text = "toolStripButton1";
            btnOpen.Click += fileOpen_Click;
            // 
            // btnCopyHtml
            // 
            btnCopyHtml.Alignment = ToolStripItemAlignment.Right;
            btnCopyHtml.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopyHtml.Image = (Image)resources.GetObject("btnCopyHtml.Image");
            btnCopyHtml.ImageTransparentColor = Color.Magenta;
            btnCopyHtml.Name = "btnCopyHtml";
            btnCopyHtml.Size = new Size(28, 28);
            btnCopyHtml.Text = "toolStripButton1";
            btnCopyHtml.Click += htmlCopyAll_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Alignment = ToolStripItemAlignment.Right;
            btnSaveAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveAs.Image = (Image)resources.GetObject("btnSaveAs.Image");
            btnSaveAs.ImageTransparentColor = Color.Magenta;
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(28, 28);
            btnSaveAs.Text = "toolStripButton2";
            btnSaveAs.Click += fileSaveAs_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBoxMarkdown);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxHtml);
            splitContainer1.Size = new Size(800, 577);
            splitContainer1.SplitterDistance = 385;
            splitContainer1.TabIndex = 3;
            // 
            // textBoxMarkdown
            // 
            textBoxMarkdown.Dock = DockStyle.Fill;
            textBoxMarkdown.Location = new Point(0, 0);
            textBoxMarkdown.Multiline = true;
            textBoxMarkdown.Name = "textBoxMarkdown";
            textBoxMarkdown.ScrollBars = ScrollBars.Both;
            textBoxMarkdown.Size = new Size(385, 577);
            textBoxMarkdown.TabIndex = 0;
            textBoxMarkdown.TextChanged += markdownTextBox_TextChanged;
            // 
            // textBoxHtml
            // 
            textBoxHtml.Dock = DockStyle.Fill;
            textBoxHtml.Location = new Point(0, 0);
            textBoxHtml.Multiline = true;
            textBoxHtml.Name = "textBoxHtml";
            textBoxHtml.ReadOnly = true;
            textBoxHtml.ScrollBars = ScrollBars.Both;
            textBoxHtml.Size = new Size(411, 577);
            textBoxHtml.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 654);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Markdown to HTML - 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private TextBox textBoxMarkdown;
        private TextBox textBoxHtml;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExitToolStripMenuItem;
        private ToolStripMenuItem markdownToolStripMenuItem;
        private ToolStripMenuItem markdownWordWrapToolStripMenuItem;
        private ToolStripButton btnMdWrap;
        private ToolStripButton btnHtmlWrap;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private ToolStripMenuItem htmlWordWrapToolStripMenuItem;
        private ToolStripMenuItem htmlCopyAllToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpAboutToolStripMenuItem;
        private ToolStripMenuItem fileOpenToolStripMenuItem;
        private ToolStripMenuItem htmlAutoNewLinesToolStripMenuItem;
        private ToolStripMenuItem htmlAutoHyperlinkToolStripMenuItem;
        private ToolStripMenuItem fileSaveAsToolStripMenuItem;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSaveAs;
        private ToolStripButton btnCopyHtml;
        private ToolStripSeparator toolStripSeparator1;
    }
}
