namespace ChessTournament
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
            Button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(32, 322);
            Button1.Name = "Button1";
            Button1.Size = new Size(94, 29);
            Button1.TabIndex = 0;
            Button1.Text = "Add";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(32, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 204);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 196);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(168, 322);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(Button1);
            Name = "Form1";
            Text = "Tournament list";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button2;
    }
}
