using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Project_My_Secret_Folder
{
    public partial class NewTextFileForm : Form
    {
        private readonly string filePath;

        public string FileName { get; set; }
        public string ContentText { get; set; }

        public NewTextFileForm()
        {
            InitializeComponent();
        }

        public NewTextFileForm(string filePath)
            : this()
        {
            this.filePath = filePath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.FileName = textBoxFileName.Text.Trim();
                this.ContentText = richTextBoxFileContent.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ValidateText(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.richTextBoxFileContent.Text))
            {
                e.Cancel = true;
                this.richTextBoxFileContent.Focus();
                this.errorProviderText.SetError(this.richTextBoxFileContent, "Cannot save emty file");
                this.labelErrorContent.Text = "Cannot save emty file";
            }
            else
            {
                e.Cancel = false;
                this.errorProviderText.SetError(this.richTextBoxFileContent, string.Empty);
                this.labelErrorContent.Text = string.Empty;
            }
        }

        private void ValidateFileName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxFileName.Text))
            {
                e.Cancel = true;
                this.textBoxFileName.Focus();
                this.errorProviderFileName.SetError(this.textBoxFileName, "Invalid file name");
                this.labelErrorFileName.Text = "Invalid file name";
            }
            else if (File.Exists(Path.Combine(this.filePath, this.textBoxFileName.Text)))
            {
                e.Cancel = true;
                this.errorProviderFileName.SetError(this.textBoxFileName, "File already exists");
                this.labelErrorFileName.Text = "File already exists";
            }
            else
            {
                e.Cancel = false;
                this.errorProviderFileName.SetError(this.textBoxFileName, string.Empty);
                this.labelErrorFileName.Text = string.Empty;
            }
        }

    }
}
