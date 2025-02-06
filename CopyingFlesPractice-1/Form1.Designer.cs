namespace CopyingFlesPractice_1
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Источник:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(430, 17);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 2;
            button1.Text = "Файл...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Приемник:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 27);
            textBox2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(430, 65);
            button2.Name = "button2";
            button2.Size = new Size(103, 29);
            button2.TabIndex = 2;
            button2.Text = "Папка...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 148);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(415, 24);
            progressBar1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(431, 146);
            button3.Name = "button3";
            button3.Size = new Size(102, 29);
            button3.TabIndex = 4;
            button3.Text = "Копировать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 189);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private ProgressBar progressBar1;
        private Button button3;
    }
}
