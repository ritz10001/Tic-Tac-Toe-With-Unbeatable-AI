namespace TicTacToeGUI
{
    partial class Form3
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            submit_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 42);
            label1.Name = "label1";
            label1.Size = new Size(497, 214);
            label1.TabIndex = 0;
            label1.Text = "WHAT LETTER YOU WANT TO CHOOSE? X OR O?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(85, 346);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 69);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "X";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(481, 321);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 119);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "O";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // submit_button
            // 
            submit_button.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            submit_button.Location = new Point(195, 459);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(280, 109);
            submit_button.TabIndex = 5;
            submit_button.Text = "SUBMIT";
            submit_button.UseVisualStyleBackColor = true;
            submit_button.Click += submit_button_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(678, 644);
            Controls.Add(submit_button);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button submit_button;
    }
}