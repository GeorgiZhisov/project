using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Project_Tennis_Score_App
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        public (string, int) FirstPlayer { get; internal set; }
        public (string, int) SecondPlayer { get; internal set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text;
            int firstPlayerPoints = (int)numericUpDownFirstPlayerPoints.Value;

            string secondPlayerName = textBoxSecondPlayerName.Text;
            int secondPlayerPoints = (int)numericUpDownSecondPlayerPoints.Value;

            this.FirstPlayer = (firstPlayerName, firstPlayerPoints);
            this.SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;

        }

        private bool CheckIfInputsAreValid()
            => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreSame()
            => textBoxFirstPlayerName.Text == textBoxSecondPlayerName.Text;

        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrWhiteSpace(textBoxFirstPlayerName.Text)
            || string.IsNullOrWhiteSpace(textBoxSecondPlayerName.Text);

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessage(textBox);
                ShowErrorOnSameNames();
            }
        }

        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                labelSameNameErrorMessage.Text = "Player names should not be the same.";
            }
            else
            {
                labelSameNameErrorMessage.Text = string.Empty;
            }
        }

        private void RemoveErrorMessage(TextBox textBox)
        {
            if (textBox == this.textBoxFirstPlayerName)
            {
                this.errorProviderFirstName.SetError(textBox, string.Empty);
                this.labelErrorFirstName.Text = string.Empty;
            }
            else if (textBox == this.textBoxSecondPlayerName)
            {
                this.errorProviderSecondName.SetError(textBox, string.Empty);
                this.labelErrorSecondName.Text = string.Empty;
            }
        }

        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player name shoud not be blank";

            if(textBox == this.textBoxFirstPlayerName)
            {
                this.errorProviderFirstName.SetError(textBox, errorText);
                this.labelErrorFirstName.Text = $"First {errorText}";
            } else if (textBox == this.textBoxSecondPlayerName)
            {
                this.errorProviderSecondName.SetError(textBox, errorText);
                this.labelErrorSecondName.Text = $"Second {errorText}";
            }
        }
    }
}
