namespace Second_Programing_Practice__SPP_
{
    partial class Administrator_Form
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
            Users_list = new ListBox();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            StatusTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UpdateButton = new Button();
            NaOM_lable = new Label();
            NaOM_textbox = new TextBox();
            OOP_lable = new Label();
            OOP_textbox = new TextBox();
            M_lable = new Label();
            M_textbox = new TextBox();
            label4 = new Label();
            DD_textbox = new TextBox();
            R_lable = new Label();
            R_textbox = new TextBox();
            IS_lable = new Label();
            IS_textbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Delete_Button = new Button();
            Add_Button = new Button();
            SuspendLayout();
            // 
            // Users_list
            // 
            Users_list.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Users_list.FormattingEnabled = true;
            Users_list.ItemHeight = 19;
            Users_list.Location = new Point(12, 12);
            Users_list.Name = "Users_list";
            Users_list.Size = new Size(157, 327);
            Users_list.TabIndex = 0;
            Users_list.SelectedIndexChanged += Users_list_SelectedIndexChanged;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(175, 49);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(144, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(175, 93);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(144, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(175, 137);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(144, 23);
            StatusTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 4;
            label1.Text = "Login (User name)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 119);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 6;
            label3.Text = "Account status";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(175, 304);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(120, 33);
            UpdateButton.TabIndex = 7;
            UpdateButton.Text = "Data update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // NaOM_lable
            // 
            NaOM_lable.AutoSize = true;
            NaOM_lable.Location = new Point(353, 31);
            NaOM_lable.Name = "NaOM_lable";
            NaOM_lable.RightToLeft = RightToLeft.No;
            NaOM_lable.Size = new Size(191, 15);
            NaOM_lable.TabIndex = 8;
            NaOM_lable.Text = "Numeric and optimization method";
            // 
            // NaOM_textbox
            // 
            NaOM_textbox.Location = new Point(353, 49);
            NaOM_textbox.Name = "NaOM_textbox";
            NaOM_textbox.Size = new Size(44, 23);
            NaOM_textbox.TabIndex = 9;
            // 
            // OOP_lable
            // 
            OOP_lable.AutoSize = true;
            OOP_lable.Location = new Point(353, 75);
            OOP_lable.Name = "OOP_lable";
            OOP_lable.Size = new Size(180, 15);
            OOP_lable.TabIndex = 10;
            OOP_lable.Text = "Object orientation programming";
            // 
            // OOP_textbox
            // 
            OOP_textbox.Location = new Point(353, 93);
            OOP_textbox.Name = "OOP_textbox";
            OOP_textbox.Size = new Size(44, 23);
            OOP_textbox.TabIndex = 11;
            // 
            // M_lable
            // 
            M_lable.AutoSize = true;
            M_lable.Location = new Point(353, 119);
            M_lable.Name = "M_lable";
            M_lable.Size = new Size(72, 15);
            M_lable.TabIndex = 12;
            M_lable.Text = "Managment";
            // 
            // M_textbox
            // 
            M_textbox.Location = new Point(353, 137);
            M_textbox.Name = "M_textbox";
            M_textbox.Size = new Size(44, 23);
            M_textbox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 163);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 14;
            label4.Text = "Database design";
            // 
            // DD_textbox
            // 
            DD_textbox.Location = new Point(353, 181);
            DD_textbox.Name = "DD_textbox";
            DD_textbox.Size = new Size(44, 23);
            DD_textbox.TabIndex = 15;
            // 
            // R_lable
            // 
            R_lable.AutoSize = true;
            R_lable.Location = new Point(353, 207);
            R_lable.Name = "R_lable";
            R_lable.Size = new Size(35, 15);
            R_lable.TabIndex = 16;
            R_lable.Text = "Right";
            // 
            // R_textbox
            // 
            R_textbox.Location = new Point(353, 225);
            R_textbox.Name = "R_textbox";
            R_textbox.Size = new Size(44, 23);
            R_textbox.TabIndex = 17;
            // 
            // IS_lable
            // 
            IS_lable.AutoSize = true;
            IS_lable.Location = new Point(353, 251);
            IS_lable.Name = "IS_lable";
            IS_lable.Size = new Size(110, 15);
            IS_lable.TabIndex = 18;
            IS_lable.Text = "Information system";
            // 
            // IS_textbox
            // 
            IS_textbox.Location = new Point(353, 269);
            IS_textbox.Name = "IS_textbox";
            IS_textbox.Size = new Size(44, 23);
            IS_textbox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(175, 9);
            label5.Name = "label5";
            label5.Size = new Size(169, 21);
            label5.TabIndex = 20;
            label5.Text = "Account information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(350, 9);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 21;
            label6.Text = "Rating";
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(310, 304);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(120, 33);
            Delete_Button.TabIndex = 22;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Add_Button
            // 
            Add_Button.Location = new Point(443, 304);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(120, 33);
            Add_Button.TabIndex = 23;
            Add_Button.Text = "Add";
            Add_Button.UseMnemonic = false;
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // Administrator_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 349);
            Controls.Add(Add_Button);
            Controls.Add(Delete_Button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(IS_textbox);
            Controls.Add(IS_lable);
            Controls.Add(R_textbox);
            Controls.Add(R_lable);
            Controls.Add(DD_textbox);
            Controls.Add(label4);
            Controls.Add(M_textbox);
            Controls.Add(M_lable);
            Controls.Add(OOP_textbox);
            Controls.Add(OOP_lable);
            Controls.Add(NaOM_textbox);
            Controls.Add(NaOM_lable);
            Controls.Add(UpdateButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StatusTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(Users_list);
            Name = "Administrator_Form";
            Text = "Administrator_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Users_list;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TextBox StatusTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button UpdateButton;
        private Label NaOM_lable;
        private TextBox NaOM_textbox;
        private Label OOP_lable;
        private TextBox OOP_textbox;
        private Label M_lable;
        private TextBox M_textbox;
        private Label label4;
        private TextBox DD_textbox;
        private Label R_lable;
        private TextBox R_textbox;
        private Label IS_lable;
        private TextBox IS_textbox;
        private Label label5;
        private Label label6;
        private Button Delete_Button;
        private Button Add_Button;
    }
}