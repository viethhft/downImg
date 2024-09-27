namespace downImg
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
            label2 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Đường dẫn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 107);
            label2.Name = "label2";
            label2.Size = new Size(46, 32);
            label2.TabIndex = 1;
            label2.Text = "Từ:";
            // 
            // button1
            // 
            button1.Location = new Point(599, 19);
            button1.Name = "button1";
            button1.Size = new Size(140, 129);
            button1.TabIndex = 2;
            button1.Text = "DownLoad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(180, 105);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(87, 39);
            numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 39);
            textBox1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(365, 105);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(87, 39);
            numericUpDown2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 107);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 5;
            label3.Text = "Đến:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 185);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown2;
        private Label label3;
    }
}
