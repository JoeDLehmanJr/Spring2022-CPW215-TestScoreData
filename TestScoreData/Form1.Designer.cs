namespace TestScoreData
{
    partial class FrmScoreCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.TxtScoreTotal = new System.Windows.Forms.TextBox();
            this.TxtScoreCount = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDisplayScore = new System.Windows.Forms.Button();
            this.BtnClearScore = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(112, 12);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(27, 23);
            this.TxtScore.TabIndex = 4;
            this.TxtScore.Tag = "Score Input";
            // 
            // TxtScoreTotal
            // 
            this.TxtScoreTotal.Location = new System.Drawing.Point(112, 42);
            this.TxtScoreTotal.Name = "TxtScoreTotal";
            this.TxtScoreTotal.ReadOnly = true;
            this.TxtScoreTotal.Size = new System.Drawing.Size(27, 23);
            this.TxtScoreTotal.TabIndex = 5;
            this.TxtScoreTotal.Tag = "Score Total";
            // 
            // TxtScoreCount
            // 
            this.TxtScoreCount.Location = new System.Drawing.Point(112, 77);
            this.TxtScoreCount.Name = "TxtScoreCount";
            this.TxtScoreCount.ReadOnly = true;
            this.TxtScoreCount.Size = new System.Drawing.Size(27, 23);
            this.TxtScoreCount.TabIndex = 6;
            this.TxtScoreCount.Tag = "Score Count";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(112, 112);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ReadOnly = true;
            this.TxtAverage.Size = new System.Drawing.Size(27, 23);
            this.TxtAverage.TabIndex = 7;
            this.TxtAverage.Tag = "Score Average";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(156, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDisplayScore
            // 
            this.BtnDisplayScore.Location = new System.Drawing.Point(10, 171);
            this.BtnDisplayScore.Name = "BtnDisplayScore";
            this.BtnDisplayScore.Size = new System.Drawing.Size(105, 23);
            this.BtnDisplayScore.TabIndex = 9;
            this.BtnDisplayScore.Text = "Display score";
            this.BtnDisplayScore.UseVisualStyleBackColor = true;
            this.BtnDisplayScore.Click += new System.EventHandler(this.BtnDisplayScore_Click);
            // 
            // BtnClearScore
            // 
            this.BtnClearScore.Location = new System.Drawing.Point(138, 171);
            this.BtnClearScore.Name = "BtnClearScore";
            this.BtnClearScore.Size = new System.Drawing.Size(78, 23);
            this.BtnClearScore.TabIndex = 10;
            this.BtnClearScore.Text = "Clear score";
            this.BtnClearScore.UseVisualStyleBackColor = true;
            this.BtnClearScore.Click += new System.EventHandler(this.BtnClearScore_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(156, 200);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmScoreCalculator
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 241);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClearScore);
            this.Controls.Add(this.BtnDisplayScore);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.TxtScoreCount);
            this.Controls.Add(this.TxtScoreTotal);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmScoreCalculator";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtScore;
        private TextBox TxtScoreTotal;
        private TextBox TxtScoreCount;
        private TextBox TxtAverage;
        private Button BtnAdd;
        private Button BtnDisplayScore;
        private Button BtnClearScore;
        private Button BtnExit;
    }
}