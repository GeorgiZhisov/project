namespace _20_Project_My_Secret_Folder
{
    partial class UploadFileForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            richTextBoxTextContent = new RichTextBox();
            buttonSave = new Button();
            buttonOpenFileanager = new Button();
            errorProvider1 = new ErrorProvider(components);
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(774, 74);
            label1.TabIndex = 0;
            label1.Text = "Upload your new secret file";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // richTextBoxTextContent
            // 
            richTextBoxTextContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxTextContent.Location = new Point(28, 120);
            richTextBoxTextContent.Name = "richTextBoxTextContent";
            richTextBoxTextContent.Size = new Size(739, 242);
            richTextBoxTextContent.TabIndex = 1;
            richTextBoxTextContent.Text = "";
            richTextBoxTextContent.Validating += richTextBoxTextContent_Validating;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(329, 390);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(197, 34);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpenFileanager
            // 
            buttonOpenFileanager.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOpenFileanager.Location = new Point(545, 390);
            buttonOpenFileanager.Name = "buttonOpenFileanager";
            buttonOpenFileanager.Size = new Size(222, 34);
            buttonOpenFileanager.TabIndex = 2;
            buttonOpenFileanager.Text = "Open File Manager";
            buttonOpenFileanager.UseVisualStyleBackColor = true;
            buttonOpenFileanager.Click += buttonOpenFileanager_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(28, 365);
            labelError.Name = "labelError";
            labelError.Size = new Size(20, 25);
            labelError.TabIndex = 3;
            labelError.Text = "*";
            // 
            // UploadFileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 468);
            Controls.Add(labelError);
            Controls.Add(buttonOpenFileanager);
            Controls.Add(buttonSave);
            Controls.Add(richTextBoxTextContent);
            Controls.Add(label1);
            Name = "UploadFileForm";
            Text = "Upload File";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxTextContent;
        private Button buttonSave;
        private Button buttonOpenFileanager;
        private ErrorProvider errorProvider1;
        private Label labelError;
    }
}