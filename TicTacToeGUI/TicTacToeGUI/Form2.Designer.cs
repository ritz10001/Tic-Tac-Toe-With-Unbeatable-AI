namespace TicTacToeGUI
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            restart_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(134, 100);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(260, 100);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(386, 100);
            button3.Name = "button3";
            button3.Size = new Size(120, 120);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(134, 226);
            button4.Name = "button4";
            button4.Size = new Size(120, 120);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(260, 226);
            button5.Name = "button5";
            button5.Size = new Size(120, 120);
            button5.TabIndex = 15;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(386, 226);
            button6.Name = "button6";
            button6.Size = new Size(120, 120);
            button6.TabIndex = 16;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(134, 352);
            button7.Name = "button7";
            button7.Size = new Size(120, 120);
            button7.TabIndex = 17;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLight;
            button8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(260, 352);
            button8.Name = "button8";
            button8.Size = new Size(120, 120);
            button8.TabIndex = 18;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLight;
            button9.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(386, 352);
            button9.Name = "button9";
            button9.Size = new Size(120, 120);
            button9.TabIndex = 19;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // restart_button
            // 
            restart_button.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            restart_button.Location = new Point(238, 525);
            restart_button.Name = "restart_button";
            restart_button.Size = new Size(180, 80);
            restart_button.TabIndex = 20;
            restart_button.Text = "RESTART";
            restart_button.UseVisualStyleBackColor = true;
            restart_button.Click += restart_button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 644);
            Controls.Add(restart_button);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Tic Tac Toe";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button restart_button;
    }
}