namespace WordGuessApplication
{
    partial class Form1
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
            textBoxGuess = new TextBox();
            buttonCheck = new Button();
            listBoxWrongGuesses = new ListBox();
            labelResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxGuess
            // 
            textBoxGuess.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGuess.Location = new Point(12, 99);
            textBoxGuess.Name = "textBoxGuess";
            textBoxGuess.Size = new Size(463, 33);
            textBoxGuess.TabIndex = 0;
            textBoxGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.DarkSeaGreen;
            buttonCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheck.ForeColor = Color.White;
            buttonCheck.Location = new Point(12, 148);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(463, 39);
            buttonCheck.TabIndex = 1;
            buttonCheck.Text = "Guess";
            buttonCheck.UseVisualStyleBackColor = false;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // listBoxWrongGuesses
            // 
            listBoxWrongGuesses.FormattingEnabled = true;
            listBoxWrongGuesses.ItemHeight = 15;
            listBoxWrongGuesses.Location = new Point(481, 48);
            listBoxWrongGuesses.Name = "listBoxWrongGuesses";
            listBoxWrongGuesses.Size = new Size(156, 139);
            listBoxWrongGuesses.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.DarkSeaGreen;
            labelResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.ForeColor = Color.White;
            labelResult.Location = new Point(12, 9);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(463, 75);
            labelResult.TabIndex = 3;
            labelResult.Text = "label1";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(481, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 4;
            label1.Text = "Wrong guess";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 199);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(listBoxWrongGuesses);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxGuess);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGuess;
        private Button buttonCheck;
        private ListBox listBoxWrongGuesses;
        private Label labelResult;
        private Label label1;
    }
}
