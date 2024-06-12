namespace _02_Project_Tennis_Score_App
{
    partial class NewGameForm
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
            label2 = new Label();
            label3 = new Label();
            textBoxFirstPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDownFirstPlayerPoints = new NumericUpDown();
            numericUpDownSecondPlayerPoints = new NumericUpDown();
            label6 = new Label();
            buttonSave = new Button();
            errorProviderFirstName = new ErrorProvider(components);
            errorProviderSecondName = new ErrorProvider(components);
            labelErrorFirstName = new Label();
            labelErrorSecondName = new Label();
            labelSameNameErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(291, 35);
            label1.Name = "label1";
            label1.Size = new Size(216, 54);
            label1.TabIndex = 0;
            label1.Text = "New Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 126);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "First player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 126);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Second player";
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.Location = new Point(84, 166);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(280, 27);
            textBoxFirstPlayerName.TabIndex = 1;
            textBoxFirstPlayerName.Validating += ValidatePlayerName;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.Location = new Point(453, 166);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(286, 27);
            textBoxSecondPlayerName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 268);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Points";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 268);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Points";
            // 
            // numericUpDownFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.Location = new Point(176, 307);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(81, 27);
            numericUpDownFirstPlayerPoints.TabIndex = 5;
            // 
            // numericUpDownSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.Location = new Point(544, 307);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(81, 27);
            numericUpDownSecondPlayerPoints.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(344, 212);
            label6.Name = "label6";
            label6.Size = new Size(116, 89);
            label6.TabIndex = 7;
            label6.Text = "VS";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(323, 380);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(149, 64);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // errorProviderFirstName
            // 
            errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderSecondName
            // 
            errorProviderSecondName.ContainerControl = this;
            // 
            // labelErrorFirstName
            // 
            labelErrorFirstName.AutoSize = true;
            labelErrorFirstName.Location = new Point(84, 196);
            labelErrorFirstName.Name = "labelErrorFirstName";
            labelErrorFirstName.Size = new Size(15, 20);
            labelErrorFirstName.TabIndex = 9;
            labelErrorFirstName.Text = "*";
            // 
            // labelErrorSecondName
            // 
            labelErrorSecondName.AutoSize = true;
            labelErrorSecondName.Location = new Point(453, 196);
            labelErrorSecondName.Name = "labelErrorSecondName";
            labelErrorSecondName.Size = new Size(15, 20);
            labelErrorSecondName.TabIndex = 10;
            labelErrorSecondName.Text = "*";
            // 
            // labelSameNameErrorMessage
            // 
            labelSameNameErrorMessage.AutoSize = true;
            labelSameNameErrorMessage.Location = new Point(301, 98);
            labelSameNameErrorMessage.Name = "labelSameNameErrorMessage";
            labelSameNameErrorMessage.Size = new Size(15, 20);
            labelSameNameErrorMessage.TabIndex = 11;
            labelSameNameErrorMessage.Text = "*";
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            ControlBox = false;
            Controls.Add(labelSameNameErrorMessage);
            Controls.Add(labelErrorSecondName);
            Controls.Add(labelErrorFirstName);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(numericUpDownSecondPlayerPoints);
            Controls.Add(numericUpDownFirstPlayerPoints);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFirstPlayerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirstPlayerName;
        private TextBox textBoxSecondPlayerName;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownFirstPlayerPoints;
        private NumericUpDown numericUpDownSecondPlayerPoints;
        private Label label6;
        private Button buttonSave;
        private ErrorProvider errorProviderFirstName;
        private ErrorProvider errorProviderSecondName;
        private Label labelErrorFirstName;
        private Label labelErrorSecondName;
        private Label labelSameNameErrorMessage;
    }
}