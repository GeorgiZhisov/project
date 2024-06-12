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
    public partial class NewFolderForm : Form
    {
        private readonly string filePath;

        public string FolderName { get; set; }

        public NewFolderForm()
        {
            InitializeComponent();
        }
        public NewFolderForm(string filePath)
            : this()
        {
            this.filePath = filePath;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.FolderName = textBoxFolderName.Text.Trim();
                this.DialogResult = DialogResult.OK;

            }
        }

        private void ValidateTextBoxFolderName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxFolderName.Text))
            {
                e.Cancel = true;
                this.textBoxFolderName.Focus();
                SetErrorMessage("Cannot create folder with no name");
            }
            else if (Directory.Exists(Path.Combine(this.filePath, textBoxFolderName.Text)))
            {
                e.Cancel = true;
                this.textBoxFolderName.Focus();
                SetErrorMessage("A folder with the same name already exists");
            }
            else
            {
                e.Cancel = false;
                SetErrorMessage(string.Empty);
            }

        }

        private void SetErrorMessage(string message)
        {
            this.errorProviderFolderName.SetError(this.textBoxFolderName, message);
            this.labelError.Text = message;
        }
    }
}
