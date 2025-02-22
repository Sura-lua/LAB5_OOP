namespace LAB5_OOP
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
            button1 = new Button();
            textBoxFullName = new TextBox();
            textBoxTitle = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(516, 71);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "แยก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(219, 73);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(291, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(219, 158);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(140, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(219, 191);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(140, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(219, 224);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(140, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 76);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "ชื่อนามสกุลเต็ม";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 165);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 198);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 231);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "นามสกุล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxFullName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxFullName;
        private TextBox textBoxTitle;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
