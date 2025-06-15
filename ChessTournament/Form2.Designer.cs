namespace ChessTournament
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBoxResult = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(445, 329);
            button1.Name = "button1";
            button1.Size = new Size(83, 27);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(443, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(445, 110);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 4;
            label1.Text = "White";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 156);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Black";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 210);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 264);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Round";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(522, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(522, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(522, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(553, 327);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 110);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 13;
            label5.Text = "Tournament name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 166);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 14;
            label6.Text = "Round amount";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(257, 27);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(151, 156);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 16;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 210);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 17;
            label7.Text = "Year";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(151, 207);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 18;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(192, 262);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(84, 264);
            button4.Name = "button4";
            button4.Size = new Size(83, 27);
            button4.TabIndex = 19;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(132, 29);
            button5.TabIndex = 21;
            button5.Text = "Back to main";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBoxResult
            // 
            comboBoxResult.FormattingEnabled = true;
            comboBoxResult.Location = new Point(522, 206);
            comboBoxResult.Name = "comboBoxResult";
            comboBoxResult.Size = new Size(125, 28);
            comboBoxResult.TabIndex = 22;
            comboBoxResult.SelectedIndexChanged += comboBoxResult_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxResult);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Add";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBoxResult;
    }
}