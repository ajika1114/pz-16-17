namespace _16
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
            StartStopButton = new Button();
            PortTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            FolderPathLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(12, 12);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(161, 23);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Start / Stop";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(56, 57);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(100, 23);
            PortTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(70, 102);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // FolderPathLabel
            // 
            FolderPathLabel.AutoSize = true;
            FolderPathLabel.Location = new Point(26, 158);
            FolderPathLabel.Name = "FolderPathLabel";
            FolderPathLabel.Size = new Size(94, 15);
            FolderPathLabel.TabIndex = 3;
            FolderPathLabel.Text = "Шлях до файлу:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Порт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 195);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FolderPathLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PortTextBox);
            Controls.Add(StartStopButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopButton;
        private TextBox PortTextBox;
        private TextBox PasswordTextBox;
        private Label FolderPathLabel;
        private Label label1;
        private Label label2;
    }
}
