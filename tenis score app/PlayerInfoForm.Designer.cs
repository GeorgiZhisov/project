namespace _02_Project_Tennis_Score_App
{
    partial class PlayerInfoForm
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
            labelPlayerName = new Label();
            label1 = new Label();
            listViewVictories = new ListView();
            columnHeaderCompetitor = new ColumnHeader();
            columnHeaderScore = new ColumnHeader();
            listViewLosses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label2 = new Label();
            listViewDraw = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(281, 65);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(245, 54);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 144);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Victories";
            // 
            // listViewVictories
            // 
            listViewVictories.Columns.AddRange(new ColumnHeader[] { columnHeaderCompetitor, columnHeaderScore });
            listViewVictories.Location = new Point(63, 167);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(217, 185);
            listViewVictories.TabIndex = 2;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // columnHeaderCompetitor
            // 
            columnHeaderCompetitor.Text = "Comnpetitor";
            columnHeaderCompetitor.Width = 150;
            // 
            // columnHeaderScore
            // 
            columnHeaderScore.Text = "Score";
            columnHeaderScore.Width = 80;
            // 
            // listViewLosses
            // 
            listViewLosses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewLosses.Location = new Point(309, 167);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(228, 185);
            listViewLosses.TabIndex = 4;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Comnpetitor";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            columnHeader2.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 144);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Loses";
            // 
            // listViewDraw
            // 
            listViewDraw.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listViewDraw.Location = new Point(568, 167);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(217, 185);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Comnpetitor";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            columnHeader4.Width = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 144);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Draw";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(listViewDraw);
            Controls.Add(label3);
            Controls.Add(listViewLosses);
            Controls.Add(label2);
            Controls.Add(listViewVictories);
            Controls.Add(label1);
            Controls.Add(labelPlayerName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label label1;
        private ListView listViewVictories;
        private ColumnHeader columnHeaderCompetitor;
        private ColumnHeader columnHeaderScore;
        private ListView listViewLosses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label2;
        private ListView listViewDraw;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label3;
    }
}