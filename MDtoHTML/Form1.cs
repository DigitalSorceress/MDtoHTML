using MarkdownSharp;

namespace MDtoHTML
{
    public partial class Form1 : Form
    {
        Markdown _mdParser;
        string _lastFile = "";

        public Form1()
        {
            InitializeComponent();
            MarkdownOptions options = new MarkdownOptions();
            options.AutoNewlines = true;

            _mdParser = new Markdown(options);
        }

        #region FileMenu
        private void fileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Markdown / plaintext (*.md;*.txt)|*.md;*.txt|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxMarkdown.Text = File.ReadAllText(dlg.FileName);
                    _lastFile = dlg.FileName;
                }
            }
        }

        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Hypertext Markup Language - HTML (*.htm)|*.htm;*.html|All Files(*.*)|*.*";
                if (string.IsNullOrEmpty(_lastFile) || ! Directory.Exists(Path.GetDirectoryName(_lastFile)))
                {
                    dlg.FileName = "markdown.htm";
                } else
                {
                    dlg.InitialDirectory = Path.GetDirectoryName(_lastFile);
                    dlg.FileName = Path.GetFileNameWithoutExtension(_lastFile) + ".htm";
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, textBoxHtml.Text);
                }
            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion FileMenu


        #region MarkdownEvents
        private void ToggleMarkdownWrap(object sender, EventArgs e)
        {
            textBoxMarkdown.WordWrap = !textBoxMarkdown.WordWrap;
            markdownToolStripMenuItem.Checked = textBoxMarkdown.WordWrap;
        }

        private void markdownTextBox_TextChanged(object sender, EventArgs e)
        {
            string mdText = textBoxMarkdown.Text;
            textBoxHtml.Text = _mdParser.Transform(mdText).Replace("\n", "\r\n");
        }
        #endregion MarkdownEvents


        #region HtmlEvents
        private void ToggleHtmlWrap(object sender, EventArgs e)
        {
            textBoxHtml.WordWrap = !textBoxHtml.WordWrap;
            htmlWordWrapToolStripMenuItem.Checked = textBoxHtml.WordWrap;
        }

        private void htmlCopyAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHtml.Text))
            {
                Clipboard.Clear();
            }
            else
            {
                Clipboard.SetText(textBoxHtml.Text);
            }
        }

        private void ToggleAutoNewLine(object sender, EventArgs e)
        {
            _mdParser.AutoNewLines = !_mdParser.AutoNewLines;
            htmlAutoNewLinesToolStripMenuItem.Checked = _mdParser.AutoNewLines;
            markdownTextBox_TextChanged(sender, e);
        }

        private void ToggleHtmlAutoHyperLink(object sender, EventArgs e)
        {
            _mdParser.AutoHyperlink = !_mdParser.AutoHyperlink;
            htmlAutoHyperlinkToolStripMenuItem.Checked = _mdParser.AutoHyperlink;
            markdownTextBox_TextChanged(sender, e);
        }
        #endregion HtmlEvents

        #region HelpMenu
        private void helpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Markdown to HTML\r\n\r\nA minimal GUI implementation of MarkdownSharp https://github.com/StackExchange/MarkdownSharp\r\n\r\nMarkdownSharp is licenesd under the MIT software license.\r\n\r\nThis app was written by The Digital Sorceress and is licensed under the MIT license.");
        }
        #endregion HelpMenu



    }
}
