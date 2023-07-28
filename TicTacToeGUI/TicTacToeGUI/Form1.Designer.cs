namespace TicTacToeGUI
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
            label1 = new Label();
            play_button = new Button();
            howtoplay_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 84);
            label1.Name = "label1";
            label1.Size = new Size(325, 70);
            label1.TabIndex = 0;
            label1.Text = "TIC TAC TOE";
            label1.Click += label1_Click;
            // 
            // play_button
            // 
            play_button.BackColor = SystemColors.AppWorkspace;
            play_button.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            play_button.ForeColor = SystemColors.ControlText;
            play_button.Location = new Point(220, 292);
            play_button.Name = "play_button";
            play_button.Size = new Size(227, 62);
            play_button.TabIndex = 1;
            play_button.Text = "PLAY";
            play_button.UseVisualStyleBackColor = false;
            play_button.Click += button1_Click;
            // 
            // howtoplay_button
            // 
            howtoplay_button.BackColor = SystemColors.AppWorkspace;
            howtoplay_button.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            howtoplay_button.Location = new Point(220, 413);
            howtoplay_button.Name = "howtoplay_button";
            howtoplay_button.Size = new Size(227, 62);
            howtoplay_button.TabIndex = 2;
            howtoplay_button.Text = "HOW TO PLAY";
            howtoplay_button.UseVisualStyleBackColor = false;
            howtoplay_button.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 644);
            Controls.Add(howtoplay_button);
            Controls.Add(play_button);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button play_button;
        private Button howtoplay_button;
    }
}