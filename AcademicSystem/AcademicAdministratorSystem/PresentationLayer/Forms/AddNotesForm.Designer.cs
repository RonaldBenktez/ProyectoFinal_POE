namespace PresentationLayer.Forms
{
    partial class AddNotesForm
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
            components = new System.ComponentModel.Container();
            subjectComboBox = new ComboBox();
            subjectLabel = new Label();
            notesGroupBox = new GroupBox();
            selectSubjectButton = new FontAwesome.Sharp.IconButton();
            saveNotesGroupBox = new GroupBox();
            saveNoteButton = new FontAwesome.Sharp.IconButton();
            secondNoteTextBox = new TextBox();
            secondNoteLabel = new Label();
            firstNoteTextBox = new TextBox();
            firstNoteLabel = new Label();
            studentNameLabel = new Label();
            studentsNotesDataGridView = new DataGridView();
            searchStudentGroupBox = new GroupBox();
            searchStudentButton = new FontAwesome.Sharp.IconButton();
            searchStudentLabel = new Label();
            searchStudentTextBox = new TextBox();
            notesErrorProvider = new ErrorProvider(components);
            notesGroupBox.SuspendLayout();
            saveNotesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsNotesDataGridView).BeginInit();
            searchStudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notesErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // subjectComboBox
            // 
            subjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectComboBox.FormattingEnabled = true;
            subjectComboBox.Location = new Point(241, 57);
            subjectComboBox.Name = "subjectComboBox";
            subjectComboBox.Size = new Size(427, 28);
            subjectComboBox.TabIndex = 3;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            subjectLabel.Location = new Point(34, 60);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(144, 20);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "seleccionar materia";
            // 
            // notesGroupBox
            // 
            notesGroupBox.Controls.Add(selectSubjectButton);
            notesGroupBox.Controls.Add(saveNotesGroupBox);
            notesGroupBox.Controls.Add(studentsNotesDataGridView);
            notesGroupBox.Controls.Add(searchStudentGroupBox);
            notesGroupBox.Controls.Add(subjectLabel);
            notesGroupBox.Controls.Add(subjectComboBox);
            notesGroupBox.Location = new Point(12, 12);
            notesGroupBox.Name = "notesGroupBox";
            notesGroupBox.Size = new Size(1726, 985);
            notesGroupBox.TabIndex = 4;
            notesGroupBox.TabStop = false;
            // 
            // selectSubjectButton
            // 
            selectSubjectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            selectSubjectButton.IconColor = Color.Black;
            selectSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            selectSubjectButton.Location = new Point(711, 53);
            selectSubjectButton.Name = "selectSubjectButton";
            selectSubjectButton.Size = new Size(140, 32);
            selectSubjectButton.TabIndex = 18;
            selectSubjectButton.Text = "seleccionar";
            selectSubjectButton.UseVisualStyleBackColor = true;
            selectSubjectButton.Click += selectSubjectButton_Click;
            // 
            // saveNotesGroupBox
            // 
            saveNotesGroupBox.BackColor = SystemColors.ActiveCaption;
            saveNotesGroupBox.Controls.Add(saveNoteButton);
            saveNotesGroupBox.Controls.Add(secondNoteTextBox);
            saveNotesGroupBox.Controls.Add(secondNoteLabel);
            saveNotesGroupBox.Controls.Add(firstNoteTextBox);
            saveNotesGroupBox.Controls.Add(firstNoteLabel);
            saveNotesGroupBox.Controls.Add(studentNameLabel);
            saveNotesGroupBox.Location = new Point(16, 804);
            saveNotesGroupBox.Name = "saveNotesGroupBox";
            saveNotesGroupBox.Size = new Size(1480, 151);
            saveNotesGroupBox.TabIndex = 17;
            saveNotesGroupBox.TabStop = false;
            // 
            // saveNoteButton
            // 
            saveNoteButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveNoteButton.IconColor = Color.Black;
            saveNoteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveNoteButton.IconSize = 35;
            saveNoteButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveNoteButton.Location = new Point(1030, 57);
            saveNoteButton.Name = "saveNoteButton";
            saveNoteButton.Size = new Size(174, 39);
            saveNoteButton.TabIndex = 15;
            saveNoteButton.Text = "guardar";
            saveNoteButton.UseVisualStyleBackColor = true;
            saveNoteButton.Click += saveNoteButton_Click;
            // 
            // secondNoteTextBox
            // 
            secondNoteTextBox.Location = new Point(872, 63);
            secondNoteTextBox.Name = "secondNoteTextBox";
            secondNoteTextBox.Size = new Size(89, 27);
            secondNoteTextBox.TabIndex = 4;
            secondNoteTextBox.TextChanged += secondNoteTextBox_TextChanged;
            // 
            // secondNoteLabel
            // 
            secondNoteLabel.AutoSize = true;
            secondNoteLabel.Location = new Point(749, 66);
            secondNoteLabel.Name = "secondNoteLabel";
            secondNoteLabel.Size = new Size(99, 20);
            secondNoteLabel.TabIndex = 3;
            secondNoteLabel.Text = "segunda nota";
            // 
            // firstNoteTextBox
            // 
            firstNoteTextBox.Location = new Point(599, 63);
            firstNoteTextBox.Name = "firstNoteTextBox";
            firstNoteTextBox.Size = new Size(89, 27);
            firstNoteTextBox.TabIndex = 2;
            firstNoteTextBox.TextChanged += firstNoteTextBox_TextChanged;
            // 
            // firstNoteLabel
            // 
            firstNoteLabel.AutoSize = true;
            firstNoteLabel.Location = new Point(478, 66);
            firstNoteLabel.Name = "firstNoteLabel";
            firstNoteLabel.Size = new Size(87, 20);
            firstNoteLabel.TabIndex = 1;
            firstNoteLabel.Text = "primer nota";
            // 
            // studentNameLabel
            // 
            studentNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            studentNameLabel.Location = new Point(6, 49);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(433, 55);
            studentNameLabel.TabIndex = 0;
            studentNameLabel.Text = "ningun estudiante seleccionado";
            studentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studentsNotesDataGridView
            // 
            studentsNotesDataGridView.AllowUserToAddRows = false;
            studentsNotesDataGridView.AllowUserToDeleteRows = false;
            studentsNotesDataGridView.AllowUserToOrderColumns = true;
            studentsNotesDataGridView.AllowUserToResizeColumns = false;
            studentsNotesDataGridView.AllowUserToResizeRows = false;
            studentsNotesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsNotesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentsNotesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsNotesDataGridView.Location = new Point(34, 229);
            studentsNotesDataGridView.MultiSelect = false;
            studentsNotesDataGridView.Name = "studentsNotesDataGridView";
            studentsNotesDataGridView.RowHeadersVisible = false;
            studentsNotesDataGridView.RowHeadersWidth = 51;
            studentsNotesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsNotesDataGridView.Size = new Size(1480, 542);
            studentsNotesDataGridView.TabIndex = 16;
            studentsNotesDataGridView.SelectionChanged += studentsNotesDataGridView_SelectionChanged;
            // 
            // searchStudentGroupBox
            // 
            searchStudentGroupBox.Controls.Add(searchStudentButton);
            searchStudentGroupBox.Controls.Add(searchStudentLabel);
            searchStudentGroupBox.Controls.Add(searchStudentTextBox);
            searchStudentGroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            searchStudentGroupBox.Location = new Point(34, 117);
            searchStudentGroupBox.Name = "searchStudentGroupBox";
            searchStudentGroupBox.Size = new Size(1044, 69);
            searchStudentGroupBox.TabIndex = 15;
            searchStudentGroupBox.TabStop = false;
            // 
            // searchStudentButton
            // 
            searchStudentButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchStudentButton.IconColor = Color.Black;
            searchStudentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchStudentButton.IconSize = 35;
            searchStudentButton.Location = new Point(862, 24);
            searchStudentButton.Name = "searchStudentButton";
            searchStudentButton.Size = new Size(58, 39);
            searchStudentButton.TabIndex = 14;
            searchStudentButton.UseVisualStyleBackColor = true;
            searchStudentButton.Click += searchStudentButton_Click;
            // 
            // searchStudentLabel
            // 
            searchStudentLabel.AutoSize = true;
            searchStudentLabel.Location = new Point(15, 33);
            searchStudentLabel.Name = "searchStudentLabel";
            searchStudentLabel.Size = new Size(198, 30);
            searchStudentLabel.TabIndex = 4;
            searchStudentLabel.Text = "buscar estudiante";
            // 
            // searchStudentTextBox
            // 
            searchStudentTextBox.Location = new Point(268, 27);
            searchStudentTextBox.Name = "searchStudentTextBox";
            searchStudentTextBox.Size = new Size(528, 36);
            searchStudentTextBox.TabIndex = 5;
            searchStudentTextBox.TextChanged += searchStudentTextBox_TextChanged;
            // 
            // notesErrorProvider
            // 
            notesErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            notesErrorProvider.ContainerControl = this;
            // 
            // AddNotesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(notesGroupBox);
            Name = "AddNotesForm";
            Text = "AddNotesForm";
            notesGroupBox.ResumeLayout(false);
            notesGroupBox.PerformLayout();
            saveNotesGroupBox.ResumeLayout(false);
            saveNotesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsNotesDataGridView).EndInit();
            searchStudentGroupBox.ResumeLayout(false);
            searchStudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)notesErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox subjectComboBox;
        private Label subjectLabel;
        private GroupBox notesGroupBox;
        private GroupBox searchStudentGroupBox;
        private FontAwesome.Sharp.IconButton searchStudentButton;
        private Label searchStudentLabel;
        private TextBox searchStudentTextBox;
        private GroupBox saveNotesGroupBox;
        private DataGridView studentsNotesDataGridView;
        private Label studentNameLabel;
        private FontAwesome.Sharp.IconButton saveNoteButton;
        private TextBox secondNoteTextBox;
        private Label secondNoteLabel;
        private TextBox firstNoteTextBox;
        private Label firstNoteLabel;
        private FontAwesome.Sharp.IconButton selectSubjectButton;
        private ErrorProvider notesErrorProvider;
    }
}