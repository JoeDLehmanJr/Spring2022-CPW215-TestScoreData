namespace TestScoreData
{
    public partial class FrmScoreCalculator : Form
    {
        public FrmScoreCalculator()
        {
            InitializeComponent();
            ClearText(TxtScore);
            ResetReadonlyText();
        }
        private List<uint> testScores = new();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                PerformCalculation();
            }
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClearScore_Click(object sender, EventArgs e)
        {
            ClearText(TxtScore);
            ResetReadonlyText();
            testScores.Clear();
        }

        private void BtnDisplayScore_Click(object sender, EventArgs e)
        {
            testScores.Sort();

            var message = string.Join(Environment.NewLine, testScores);
            MessageBox.Show(message, "Sorted Scores");
        }

        /// <summary>
        /// Returns true if a textbox is empty
        /// </summary>
        /// <param name="box">The textbox to check</param>
        /// <returns>True if textbox is empty, false if textbox contains input</returns>
        private static string IsPresent(TextBox box)
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                msg += "Score input box must not be empty.\n";
                return msg;
            }
            return msg;
        }

        /// <summary>
        /// This method tries to convert the TxtScore text box into a integer between 0 to 100. 
        /// If it fails the message: "Score must be a valid number between 0 to 100" is returned.
        /// If successful, an empty string is returned.
        /// </summary>
        /// <param name="txtScore">The textbox to be tested.</param>
        /// <returns>If it fails the message: "Score must be a valid number between 0 to 100 is
        /// returned." If successful, an empty string is returned.</returns>
        private static string IsUInt(TextBox box)
        {
            string msg = "";
            if (!uint.TryParse(box.Text, out _))
            {
                msg += "Score must be a valid number between 0 to 100.\n";
            }
            return msg;
        }

        /// <summary>
        /// Checks if a number is within a inclusive range
        /// </summary>
        /// <param name="value">The number to check</param>
        /// <param name="min">The lower inclusive value</param>
        /// <param name="max">The upper inclusive value</param>
        /// <returns> A string containing the error message</returns>
        private static string IsWithinRange(string value, uint min, uint max)
        {
            string msg = "";
            if (uint.TryParse(value, out uint number))
            {
                if (!(number >= min && number <= max))
                {
                    msg += "Score must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }

        /// <summary>
        /// This method clears the passed textbox.
        /// </summary>
        /// <param name="box">The textbox to clear</param>
        private static void ClearText(TextBox box)
        {
            box.Clear();
        }

        private void ResetReadonlyText()
        {
            TxtScoreTotal.Clear();
            TxtScoreTotal.Text = "0";
            TxtScoreCount.Clear();
            TxtScoreCount.Text = "0";
            TxtAverage.Clear();
            TxtAverage.Text = "0";
            TxtScore.Focus();
        }

        /// <summary>
        /// This method grabs the score input and adds it to testScores List. It then iterates through the List 
        /// and performs a summation of the testScores and the count is calculated. It then puts the individual 
        /// pieces in to the correct textbox.
        /// </summary>
        private void PerformCalculation()
        {
            uint score = Convert.ToUInt32(TxtScore.Text);
            uint scoreTotal = 0;
            uint scoreCount = 0;
            uint scoreAverage;

            testScores.Add(score);

            for (int i = 0; i < testScores.Count; i++)
            {
                scoreTotal += testScores[i];
                scoreCount++;
            }
            scoreAverage = scoreTotal / scoreCount;

            ClearText(TxtScore);
            TxtScoreTotal.Text = scoreTotal.ToString();
            TxtScoreCount.Text = scoreCount.ToString();
            TxtAverage.Text = scoreAverage.ToString();
            TxtScore.Focus();
        }

        /// <summary>
        /// This method tests if the numbers can be converted from a string to uint. If it can not convert it 
        /// will return the message: Tag + " must be a valid number between 0 to 4,294,967,295.\n". if it can 
        /// convert it will return an empty string.
        /// </summary>
        /// <param name="box">The textbox you are trying to convert.</param>
        /// <returns>If it can not convert it will return the message: Tag + " must be a valid number between 
        /// 0 to 4,294,967,295.\n". if it can convert it will return an empty string.</returns>
        private static string IsTextUInt(TextBox box)
        {
            string msg = "";
            if (!uint.TryParse(box.Text, out _))
            {
                msg += box.Tag.ToString() + " must be a valid number between 0 to 4,294,967,295.\n";
            }
            return msg;
        }

        /// <summary>
        /// This method validates the textboxes to make sure that the textboxes don't have whitespace or nulls
        /// and that the numbers are valid. It returns true if the data is valid, otherwise false if there was in 
        /// valid data. 
        /// </summary>
        /// <returns>It returns true if the data is valid, otherwise false if there was in valid data.</returns>
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += IsPresent(TxtScore);
            errorMessage += IsUInt(TxtScore);
            errorMessage += IsWithinRange(TxtScore.Text, 0, 100);

            errorMessage += IsPresent(TxtScoreTotal);
            errorMessage += IsTextUInt(TxtScoreTotal);

            errorMessage += IsPresent(TxtScoreCount);
            errorMessage += IsTextUInt(TxtScoreCount);

            errorMessage += IsPresent(TxtAverage);
            errorMessage += IsTextUInt(TxtAverage);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }
    }
}