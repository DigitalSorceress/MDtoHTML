using MarkdownSharp;

namespace MDtoHTML
{
    public partial class Form1 : Form
    {
        Markdown _mdParser;

        public Form1()
        {
            InitializeComponent();
            MarkdownOptions options = new MarkdownOptions();
            options.AutoNewlines = true;

            _mdParser = new Markdown();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConvertAndUpdate();
        }

        private void ConvertAndUpdate()
        {
            string mdText = textBoxMarkdown.Text;


            textBoxHtml.Text = _mdParser.Transform(mdText).Replace("\n", "\r\n");
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(textBoxHtml.SelectedText);
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                textBoxHtml.SelectAll();
            }
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ToggleHtmlWrap(object sender, EventArgs e)
        {
            textBoxHtml.WordWrap = !textBoxHtml.WordWrap;
            htmlWordWrapToolStripMenuItem.Checked = textBoxHtml.WordWrap;
        }

        private void ToggleMarkdownWrap(object sender, EventArgs e)
        {
            textBoxMarkdown.WordWrap = !textBoxMarkdown.WordWrap;
            markdownToolStripMenuItem.Checked = textBoxMarkdown.WordWrap;
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Markdown to HTML\r\n\r\nA minimal GUI implementation of MarkdownSharp https://github.com/StackExchange/MarkdownSharp\r\n\r\nMarkdownSharp is licenesd under the MIT software license.\r\n\r\nThis app was written by The Digital Sorceress and is licensed under the MIT license.");
        }

        private void htmlCopyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxHtml.Text);
        }
    }
}
