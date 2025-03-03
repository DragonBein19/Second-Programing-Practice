namespace Second_Programing_Practice__SPP_
{
    partial class Teacher_Form
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
            Students_list = new ListBox();
            update = new Button();
            label5 = new Label();
            IS_TextBox = new TextBox();
            label4 = new Label();
            R_TextBox = new TextBox();
            DD_TextBox = new TextBox();
            label3 = new Label();
            M_TextBox = new TextBox();
            label2 = new Label();
            OOP_TextBox = new TextBox();
            label1 = new Label();
            NaOM_TextBox = new TextBox();
            NaOM = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(Students_list);
            panel1.Controls.Add(update);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(IS_TextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(R_TextBox);
            panel1.Controls.Add(DD_TextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(M_TextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OOP_TextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NaOM_TextBox);
            panel1.Controls.Add(NaOM);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 373);
            panel1.TabIndex = 0;
            // 
            // Students_list
            // 
            Students_list.FormattingEnabled = true;
            Students_list.ItemHeight = 15;
            Students_list.Location = new Point(12, 63);
            Students_list.Name = "Students_list";
            Students_list.Size = new Size(182, 304);
            Students_list.TabIndex = 15;
            Students_list.SelectedIndexChanged += Students_list_SelectedIndexChanged;
            // 
            // update
            // 
            update.Location = new Point(342, 288);
            update.Name = "update";
            update.Size = new Size(170, 35);
            update.TabIndex = 14;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(313, 225);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 13;
            label5.Text = "Information system";
            // 
            // IS_TextBox
            // 
            IS_TextBox.Location = new Point(464, 225);
            IS_TextBox.Name = "IS_TextBox";
            IS_TextBox.Size = new Size(48, 23);
            IS_TextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(411, 196);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 11;
            label4.Text = "Right";
            // 
            // R_TextBox
            // 
            R_TextBox.Location = new Point(464, 196);
            R_TextBox.Name = "R_TextBox";
            R_TextBox.Size = new Size(48, 23);
            R_TextBox.TabIndex = 10;
            // 
            // DD_TextBox
            // 
            DD_TextBox.Location = new Point(464, 167);
            DD_TextBox.Name = "DD_TextBox";
            DD_TextBox.Size = new Size(48, 23);
            DD_TextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 167);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 8;
            label3.Text = "Database design";
            // 
            // M_TextBox
            // 
            M_TextBox.Location = new Point(464, 138);
            M_TextBox.Name = "M_TextBox";
            M_TextBox.Size = new Size(48, 23);
            M_TextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 140);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 6;
            label2.Text = "Managment";
            // 
            // OOP_TextBox
            // 
            OOP_TextBox.Location = new Point(464, 109);
            OOP_TextBox.Name = "OOP_TextBox";
            OOP_TextBox.Size = new Size(48, 23);
            OOP_TextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 111);
            label1.Name = "label1";
            label1.Size = new Size(222, 21);
            label1.TabIndex = 4;
            label1.Text = "Object orientation programing";
            // 
            // NaOM_TextBox
            // 
            NaOM_TextBox.Location = new Point(464, 80);
            NaOM_TextBox.Name = "NaOM_TextBox";
            NaOM_TextBox.Size = new Size(48, 23);
            NaOM_TextBox.TabIndex = 2;
            // 
            // NaOM
            // 
            NaOM.AutoSize = true;
            NaOM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NaOM.Location = new Point(209, 82);
            NaOM.Name = "NaOM";
            NaOM.Size = new Size(249, 21);
            NaOM.TabIndex = 1;
            NaOM.Text = "Numeric and optimization method";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 57);
            panel2.TabIndex = 0;
            // 
            // Teacher_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 373);
            Controls.Add(panel1);
            Name = "Teacher_Form";
            Text = "Teacher_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label NaOM;
        private Panel panel2;
        private TextBox NaOM_TextBox;
        private Label label1;
        private Label label2;
        private TextBox OOP_TextBox;
        private Label label3;
        private TextBox M_TextBox;
        private TextBox DD_TextBox;
        private TextBox R_TextBox;
        private Label label5;
        private TextBox IS_TextBox;
        private Label label4;
        private Button update;
        private ListBox Students_list;
    }
}