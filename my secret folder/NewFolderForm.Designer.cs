namespace _20_Project_My_Secret_Folder
{
    partial class NewFolderForm
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
            textBoxFolderName = new TextBox();
            buttonEnter = new Button();
            errorProviderFolderName = new ErrorProvider(components);
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderFolderName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 50);
            label1.Name = "label1";
            label1.Size = new Size(602, 93);
            label1.TabIndex = 0;
            label1.Text = "Please enter folder name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxFolderName
            // 
            textBoxFolderName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFolderName.Location = new Point(67, 159);
            textBoxFolderName.Name = "textBoxFolderName";
            textBoxFolderName.Size = new Size(701, 31);
            textBoxFolderName.TabIndex = 1;
            textBoxFolderName.Validating += ValidateTextBoxFolderName;
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEnter.Location = new Point(656, 271);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(112, 34);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // errorProviderFolderName
            // 
            errorProviderFolderName.ContainerControl = this;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(67, 193);
            labelError.Name = "labelError";
            labelError.Size = new Size(20, 25);
            labelError.TabIndex = 3;
            labelError.Text = "*";
            // 
            // NewFolderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 357);
            Controls.Add(labelError);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxFolderName);
            Controls.Add(label1);
            Name = "NewFolderForm";
            Text = "New Folder";
            ((System.ComponentModel.ISupportInitialize)errorProviderFolderName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFolderName;
        private Button buttonEnter;
        private ErrorProvider errorProviderFolderName;
        private Label labelError;
    }
}