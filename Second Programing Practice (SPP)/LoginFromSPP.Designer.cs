namespace Second_Programing_Practice__SPP_
{
    partial class LoginFromSPP
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
            panel1 = new Panel();
            LogInButton = new Button();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            panel2 = new Panel();
            LogInTable = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(LogInButton);
            panel1.Controls.Add(PasswordLabel);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(LoginTextBox);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 480);
            panel1.TabIndex = 0;
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.Location = new Point(110, 396);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(245, 56);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(110, 256);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(173, 46);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(110, 146);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(113, 46);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "Login";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(110, 305);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(245, 58);
            PasswordTextBox.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(110, 195);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(245, 58);
            LoginTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(LogInTable);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 143);
            panel2.TabIndex = 0;
            // 
            // LogInTable
            // 
            LogInTable.Dock = DockStyle.Fill;
            LogInTable.Font = new Font("Times New Roman", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInTable.Location = new Point(0, 0);
            LogInTable.Name = "LogInTable";
            LogInTable.Size = new Size(485, 143);
            LogInTable.TabIndex = 0;
            LogInTable.Text = "Log In\r\n\r\n";
            LogInTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginFromSPP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 480);
            Controls.Add(panel1);
            Name = "LoginFromSPP";
            Text = "LoginFromSPP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LogInTable;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button LogInButton;
    }
}