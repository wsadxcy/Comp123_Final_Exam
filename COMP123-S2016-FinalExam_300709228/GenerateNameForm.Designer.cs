﻿namespace COMP123_S2016_FinalExam_300709228
{
    partial class GenerateNameForm
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
            this.NameListGroupBox = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.LastNameLabel2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameListBox = new System.Windows.Forms.ListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.NameListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameListGroupBox
            // 
            this.NameListGroupBox.Controls.Add(this.GenerateButton);
            this.NameListGroupBox.Controls.Add(this.LastNameLabel2);
            this.NameListGroupBox.Controls.Add(this.LastNameTextBox);
            this.NameListGroupBox.Controls.Add(this.FirstNameLabel2);
            this.NameListGroupBox.Controls.Add(this.textBox1);
            this.NameListGroupBox.Controls.Add(this.LastNameLabel);
            this.NameListGroupBox.Controls.Add(this.listBox1);
            this.NameListGroupBox.Controls.Add(this.FirstNameLabel);
            this.NameListGroupBox.Controls.Add(this.FirstNameListBox);
            this.NameListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameListGroupBox.Location = new System.Drawing.Point(64, 11);
            this.NameListGroupBox.Name = "NameListGroupBox";
            this.NameListGroupBox.Size = new System.Drawing.Size(372, 308);
            this.NameListGroupBox.TabIndex = 0;
            this.NameListGroupBox.TabStop = false;
            this.NameListGroupBox.Text = "Name Lists";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(166, 241);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(170, 37);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "Generate Names";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // LastNameLabel2
            // 
            this.LastNameLabel2.AutoSize = true;
            this.LastNameLabel2.Location = new System.Drawing.Point(184, 163);
            this.LastNameLabel2.Name = "LastNameLabel2";
            this.LastNameLabel2.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel2.TabIndex = 7;
            this.LastNameLabel2.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(184, 183);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(152, 26);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // FirstNameLabel2
            // 
            this.FirstNameLabel2.AutoSize = true;
            this.FirstNameLabel2.Location = new System.Drawing.Point(7, 163);
            this.FirstNameLabel2.Name = "FirstNameLabel2";
            this.FirstNameLabel2.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel2.TabIndex = 5;
            this.FirstNameLabel2.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(185, 30);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(94, 20);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Names";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Adams",
            "Allen",
            "Anderson",
            "Baker",
            "Brown",
            "Campbell",
            "Carter",
            "Clark",
            "Collins",
            "Davis",
            "Edwards",
            "Evans",
            "Garcia",
            "Gonzalez",
            "Green",
            "Hall",
            "Harris",
            "Hernandez",
            "Hill",
            "Jackso",
            "Johnson",
            "Jones",
            "King",
            "Lee",
            "Lewis",
            "Lopez",
            "Martin",
            "Martinez",
            "Miller",
            "Mitchell",
            "Moore",
            "Nelson",
            "Parker",
            "Perez",
            "Phillips",
            "Roberts",
            "Robinson",
            "Rodriguez",
            "Scott",
            "Smith",
            "Taylor",
            "Thomas",
            "Thompson",
            "Turner",
            "Walker",
            "White",
            "Williams",
            "Wilson",
            "Wright",
            "Young"});
            this.listBox1.Location = new System.Drawing.Point(184, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 84);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(7, 30);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(94, 20);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Names";
            // 
            // FirstNameListBox
            // 
            this.FirstNameListBox.FormattingEnabled = true;
            this.FirstNameListBox.ItemHeight = 20;
            this.FirstNameListBox.Items.AddRange(new object[] {
            "Anthony",
            "Barbara",
            "Betty",
            "Brian",
            "Carol",
            "Charles",
            "Christopher",
            "Daniel",
            "David",
            "Deborah",
            "Donald",
            "Donna",
            "Dorothy",
            "Edward",
            "Elizabeth",
            "George",
            "Helen",
            "James",
            "Jason",
            "Jeff",
            "Jennifer",
            "John",
            "Joseph",
            "Karen",
            "Kenneth",
            "Kevin",
            "Kimberly",
            "Laura",
            "Linda",
            "Lisa",
            "Margaret",
            "Maria",
            "Mark",
            "Mary",
            "Michael",
            "Michelle",
            "Nancy",
            "Patricia",
            "Paul",
            "Richard",
            "Robert",
            "Ronald",
            "Ruth",
            "Sandra\t ",
            "Sarah",
            "Sharon",
            "Steven",
            "Susan",
            "Thomas",
            "William"});
            this.FirstNameListBox.Location = new System.Drawing.Point(7, 47);
            this.FirstNameListBox.Name = "FirstNameListBox";
            this.FirstNameListBox.Size = new System.Drawing.Size(152, 84);
            this.FirstNameListBox.Sorted = true;
            this.FirstNameListBox.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(379, 396);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(113, 37);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GenerateNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 444);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.NameListGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenerateNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Name";
            this.Load += new System.EventHandler(this.GenerateNameForm_Load);
            this.NameListGroupBox.ResumeLayout(false);
            this.NameListGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NameListGroupBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox FirstNameListBox;
        private System.Windows.Forms.Label LastNameLabel2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel2;
        private System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Button NextButton;
        protected System.Windows.Forms.Button GenerateButton;
    }
}