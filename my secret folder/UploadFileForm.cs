using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Project_My_Secret_Folder
{
    public partial class UploadFileForm : Form
    {
        private readonly string filePath;

        public string DroppedFilePath { get; set; }

        private string droppedFileContent;

        public UploadFileForm()
        {
            InitializeComponent();
        }
        public UploadFileForm(string filePath)
            : this()
        {
            this.filePath = filePath;

            this.richTextBoxTextContent.AllowDrop = true;
            this.richTextBoxTextContent.DragEnter += RichTextBoxTextContent_DragEnter;
            this.richTextBoxTextContent.DragDrop += RichTextBoxTextContent_DragDrop;

        }

        private void RichTextBoxTextContent_DragDrop(object? sender, DragEventArgs e)
        {
            this.richTextBoxTextContent.Text = string.Empty;
            this.richTextBoxTextContent.ForeColor = SystemColors.WindowText;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                this.DroppedFilePath = files[0];
                this.droppedFileContent = File.ReadAllText(this.DroppedFilePath);
                this.richTextBoxTextContent.Text = this.DroppedFilePath;
            }
        }

        private void RichTextBoxTextContent_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.DialogResult = DialogResult.OK;
                this.richTextBoxTextContent.Text = string.Empty;
            }
        }

        private void richTextBoxTextContent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.richTextBoxTextContent.Text))
            {
                e.Cancel = true;
                this.richTextBoxTextContent.Focus();
                SetErrorMessage("Please, drag and drop a file");
            }
            else if (File.Exists(Path.Combine(this.filePath, Path.GetFileName(this.DroppedFilePath))))
            {
                e.Cancel = true;
                this.richTextBoxTextContent.Focus();
                SetErrorMessage("A file with that name already exists");
            }
            else
            {
                e.Cancel = false;
                SetErrorMessage(string.Empty);
            }
        }

        private void SetErrorMessage(string message)
        {
            this.errorProvider1.SetError(this.richTextBoxTextContent, message);
            this.labelError.Text = message;
        }

        private void buttonOpenFileanager_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", string.Empty);
                this.DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the file manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
