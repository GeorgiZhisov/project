namespace _02_Project_Tennis_Score_App
{
    partial class ScoreForm
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
            label1 = new Label();
            label2 = new Label();
            listViewRankings = new ListView();
            columnName = new ColumnHeader();
            columnScore = new ColumnHeader();
            label3 = new Label();
            listViewLatestGames = new ListView();
            columnFirstPlayer = new ColumnHeader();
            columnSceondPlayer = new ColumnHeader();
            columnWinner = new ColumnHeader();
            columnTotalScore = new ColumnHeader();
            buttonAddNewGame = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(428, 40);
            label1.Name = "label1";
            label1.Size = new Size(242, 54);
            label1.TabIndex = 0;
            label1.Text = "Tennis Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Renking";
            // 
            // listViewRankings
            // 
            listViewRankings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewRankings.Columns.AddRange(new ColumnHeader[] { columnName, columnScore });
            listViewRankings.Location = new Point(80, 141);
            listViewRankings.Name = "listViewRankings";
            listViewRankings.Size = new Size(920, 121);
            listViewRankings.TabIndex = 1;
            listViewRankings.UseCompatibleStateImageBehavior = false;
            listViewRankings.View = View.Details;
            listViewRankings.Click += listViewRankings_Click;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 200;
            // 
            // columnScore
            // 
            columnScore.Text = "Score";
            columnScore.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 359);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Latest games";
            // 
            // listViewLatestGames
            // 
            listViewLatestGames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewLatestGames.Columns.AddRange(new ColumnHeader[] { columnFirstPlayer, columnSceondPlayer, columnWinner, columnTotalScore });
            listViewLatestGames.Location = new Point(80, 391);
            listViewLatestGames.Name = "listViewLatestGames";
            listViewLatestGames.Size = new Size(920, 219);
            listViewLatestGames.TabIndex = 3;
            listViewLatestGames.UseCompatibleStateImageBehavior = false;
            listViewLatestGames.View = View.Details;
            // 
            // columnFirstPlayer
            // 
            columnFirstPlayer.Text = "First player";
            columnFirstPlayer.Width = 200;
            // 
            // columnSceondPlayer
            // 
            columnSceondPlayer.Text = "Second Player";
            columnSceondPlayer.Width = 200;
            // 
            // columnWinner
            // 
            columnWinner.Text = "Winner";
            columnWinner.Width = 200;
            // 
            // columnTotalScore
            // 
            columnTotalScore.Text = "Score";
            columnTotalScore.Width = 200;
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddNewGame.Location = new Point(789, 268);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(211, 50);
            buttonAddNewGame.TabIndex = 4;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = true;
            buttonAddNewGame.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 268);
            label4.Name = "label4";
            label4.Size = new Size(473, 20);
            label4.TabIndex = 2;
            label4.Text = "*click on a player's name to see more information about their matches";
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 694);
            Controls.Add(buttonAddNewGame);
            Controls.Add(listViewLatestGames);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listViewRankings);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ScoreForm";
            Text = "Score Form";
            Load += ScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listViewRankings;
        private ColumnHeader columnName;
        private ColumnHeader columnScore;
        private Label label3;
        private ListView listViewLatestGames;
        private ColumnHeader columnFirstPlayer;
        private ColumnHeader columnSceondPlayer;
        private ColumnHeader columnWinner;
        private ColumnHeader columnTotalScore;
        private Button buttonAddNewGame;
        private Label label4;
    }
}
