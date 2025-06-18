namespace ChessTournament
{
    partial class Form4
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
            buttonBackToMain = new Button();
            comboBoxTournaments = new ComboBox();
            numericUpDownYear = new NumericUpDown();
            numericUpDownAmountOfRounds = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountOfRounds).BeginInit();
            SuspendLayout();
            // 
            // buttonBackToMain
            // 
            buttonBackToMain.Location = new Point(12, 12);
            buttonBackToMain.Name = "buttonBackToMain";
            buttonBackToMain.Size = new Size(134, 29);
            buttonBackToMain.TabIndex = 14;
            buttonBackToMain.Text = "Back to main";
            buttonBackToMain.UseVisualStyleBackColor = true;
            buttonBackToMain.Click += buttonBackToMain_Click;
            // 
            // comboBoxTournaments
            // 
            comboBoxTournaments.FormattingEnabled = true;
            comboBoxTournaments.Location = new Point(33, 72);
            comboBoxTournaments.Name = "comboBoxTournaments";
            comboBoxTournaments.Size = new Size(358, 28);
            comboBoxTournaments.TabIndex = 15;
            comboBoxTournaments.SelectedIndexChanged += comboBoxTournaments_SelectedIndexChanged;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(88, 177);
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(303, 27);
            numericUpDownYear.TabIndex = 16;
            numericUpDownYear.ValueChanged += numericUpDownYear_ValueChanged;
            // 
            // numericUpDownAmountOfRounds
            // 
            numericUpDownAmountOfRounds.Location = new Point(179, 225);
            numericUpDownAmountOfRounds.Name = "numericUpDownAmountOfRounds";
            numericUpDownAmountOfRounds.Size = new Size(212, 27);
            numericUpDownAmountOfRounds.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 179);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 18;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 227);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 19;
            label2.Text = "Amoubt of rounds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 127);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 20;
            label3.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(88, 127);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(303, 27);
            textBoxName.TabIndex = 21;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(33, 326);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 22;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(297, 326);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownAmountOfRounds);
            Controls.Add(numericUpDownYear);
            Controls.Add(comboBoxTournaments);
            Controls.Add(buttonBackToMain);
            Name = "Form4";
            Text = "Edit game";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountOfRounds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackToMain;
        private ComboBox comboBoxTournaments;
        private NumericUpDown numericUpDownYear;
        private NumericUpDown numericUpDownAmountOfRounds;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}