namespace _ABRAMS__CST_150_Activity_11
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
            this.rollDiceBtn = new System.Windows.Forms.Button();
            this.outputRollsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rollDiceBtn
            // 
            this.rollDiceBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rollDiceBtn.Location = new System.Drawing.Point(12, 18);
            this.rollDiceBtn.Name = "rollDiceBtn";
            this.rollDiceBtn.Size = new System.Drawing.Size(328, 109);
            this.rollDiceBtn.TabIndex = 0;
            this.rollDiceBtn.Text = "Roll Dice";
            this.rollDiceBtn.UseVisualStyleBackColor = true;
            this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
            // 
            // outputRollsBox
            // 
            this.outputRollsBox.FormattingEnabled = true;
            this.outputRollsBox.ItemHeight = 15;
            this.outputRollsBox.Location = new System.Drawing.Point(12, 133);
            this.outputRollsBox.Name = "outputRollsBox";
            this.outputRollsBox.Size = new System.Drawing.Size(328, 304);
            this.outputRollsBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(352, 452);
            this.Controls.Add(this.outputRollsBox);
            this.Controls.Add(this.rollDiceBtn);
            this.Name = "Form1";
            this.Text = "[ABRAMS] CST-150 Activity 11";
            this.ResumeLayout(false);

        }

        #endregion

        private Button rollDiceBtn;
        private ListBox outputRollsBox;
    }
}