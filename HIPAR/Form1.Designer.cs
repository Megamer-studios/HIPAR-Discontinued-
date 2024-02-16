namespace HIPAR
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.Font = new Font("Public Pixel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 22);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Public Pixel", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(195, 35);
            label1.TabIndex = 3;
            label1.Text = "HIPAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Public Pixel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(757, 60);
            label2.TabIndex = 4;
            label2.Text = "Welcome to HIPAR \r\n(Highly Intelligent Processing Arigtonyte Result).\r\nA Highly intelligent processing system based on\r\nThe Arygtonite Framework\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 64);
            button1.Font = new Font("Public Pixel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(683, 379);
            button1.Name = "button1";
            button1.Size = new Size(96, 30);
            button1.TabIndex = 5;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
