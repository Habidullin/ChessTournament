namespace ChessTournament
{
    partial class Form3
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
            buttonEdit = new Button();
            buttonSave = new Button();
            buttonDiscard = new Button();
            comboBoxTournaments = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxWhite = new TextBox();
            textBoxBlack = new TextBox();
            comboBoxResult = new ComboBox();
            comboBoxGames = new ComboBox();
            buttonDelete = new Button();
            buttonBackToMain = new Button();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(31, 361);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 0;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(209, 361);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDiscard
            // 
            buttonDiscard.Location = new Point(372, 361);
            buttonDiscard.Name = "buttonDiscard";
            buttonDiscard.Size = new Size(94, 29);
            buttonDiscard.TabIndex = 2;
            buttonDiscard.Text = "Discard";
            buttonDiscard.UseVisualStyleBackColor = true;
            buttonDiscard.Click += buttonDiscard_Click;
            // 
            // comboBoxTournaments
            // 
            comboBoxTournaments.FormattingEnabled = true;
            comboBoxTournaments.Location = new Point(41, 68);
            comboBoxTournaments.Name = "comboBoxTournaments";
            comboBoxTournaments.Size = new Size(425, 28);
            comboBoxTournaments.TabIndex = 3;
            comboBoxTournaments.SelectedIndexChanged += comboBoxTournaments_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(42, 226);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 5;
            label1.Text = "White";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 267);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Black";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 302);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Result";
            // 
            // textBoxWhite
            // 
            textBoxWhite.Location = new Point(129, 219);
            textBoxWhite.Name = "textBoxWhite";
            textBoxWhite.Size = new Size(337, 27);
            textBoxWhite.TabIndex = 8;
            textBoxWhite.TextChanged += textBoxWhite_TextChanged;
            // 
            // textBoxBlack
            // 
            textBoxBlack.Location = new Point(129, 267);
            textBoxBlack.Name = "textBoxBlack";
            textBoxBlack.Size = new Size(337, 27);
            textBoxBlack.TabIndex = 9;
            textBoxBlack.TextChanged += textBoxBlack_TextChanged;
            // 
            // comboBoxResult
            // 
            comboBoxResult.FormattingEnabled = true;
            comboBoxResult.Location = new Point(129, 302);
            comboBoxResult.Name = "comboBoxResult";
            comboBoxResult.Size = new Size(337, 28);
            comboBoxResult.TabIndex = 10;
            comboBoxResult.SelectedIndexChanged += comboBoxResult_SelectedIndexChanged;
            // 
            // comboBoxGames
            // 
            comboBoxGames.FormattingEnabled = true;
            comboBoxGames.Location = new Point(42, 133);
            comboBoxGames.Name = "comboBoxGames";
            comboBoxGames.Size = new Size(424, 28);
            comboBoxGames.TabIndex = 11;
            comboBoxGames.SelectedIndexChanged += comboBoxGames_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(552, 361);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonBackToMain
            // 
            buttonBackToMain.Location = new Point(31, 12);
            buttonBackToMain.Name = "buttonBackToMain";
            buttonBackToMain.Size = new Size(134, 29);
            buttonBackToMain.TabIndex = 13;
            buttonBackToMain.Text = "Back to main";
            buttonBackToMain.UseVisualStyleBackColor = true;
            buttonBackToMain.Click += buttonBackToMain_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBackToMain);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxGames);
            Controls.Add(comboBoxResult);
            Controls.Add(textBoxBlack);
            Controls.Add(textBoxWhite);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTournaments);
            Controls.Add(buttonDiscard);
            Controls.Add(buttonSave);
            Controls.Add(buttonEdit);
            Name = "Form3";
            Text = "Edit game";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Button buttonSave;
        private Button buttonDiscard;
        private ComboBox comboBoxTournaments;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxWhite;
        private TextBox textBoxBlack;
        private ComboBox comboBoxResult;
        private ComboBox comboBoxGames;
        private Button buttonDelete;
        private Button buttonBackToMain;
    }
}