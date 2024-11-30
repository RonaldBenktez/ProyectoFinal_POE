namespace PresentationLayer.Forms
{
    partial class studentsAndSubjectsForm
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
            groupBox1 = new GroupBox();
            subjectTittleLabel = new Label();
            studentTittleLabel = new Label();
            enrollStudentGroupBox = new GroupBox();
            deleteEnrollStudentButton = new FontAwesome.Sharp.IconButton();
            enrollStudentButton = new FontAwesome.Sharp.IconButton();
            studentLabel = new Label();
            studentNamesLabel = new Label();
            addSubjectLabel = new Label();
            addSubjectComboBox = new ComboBox();
            subjectDataGridView = new DataGridView();
            studentsDataGridView = new DataGridView();
            searchStudentGroupBox = new GroupBox();
            searchStudentButton = new FontAwesome.Sharp.IconButton();
            searchStudentLabel = new Label();
            searchStudentTextBox = new TextBox();
            groupBox1.SuspendLayout();
            enrollStudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            searchStudentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(subjectTittleLabel);
            groupBox1.Controls.Add(studentTittleLabel);
            groupBox1.Controls.Add(enrollStudentGroupBox);
            groupBox1.Controls.Add(subjectDataGridView);
            groupBox1.Controls.Add(studentsDataGridView);
            groupBox1.Controls.Add(searchStudentGroupBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1648, 948);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // subjectTittleLabel
            // 
            subjectTittleLabel.AutoSize = true;
            subjectTittleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            subjectTittleLabel.Location = new Point(1149, 129);
            subjectTittleLabel.Name = "subjectTittleLabel";
            subjectTittleLabel.Size = new Size(179, 25);
            subjectTittleLabel.TabIndex = 25;
            subjectTittleLabel.Text = "materias asignadas";
            // 
            // studentTittleLabel
            // 
            studentTittleLabel.AutoSize = true;
            studentTittleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            studentTittleLabel.Location = new Point(447, 129);
            studentTittleLabel.Name = "studentTittleLabel";
            studentTittleLabel.Size = new Size(113, 25);
            studentTittleLabel.TabIndex = 24;
            studentTittleLabel.Text = "estudiantes";
            // 
            // enrollStudentGroupBox
            // 
            enrollStudentGroupBox.Controls.Add(deleteEnrollStudentButton);
            enrollStudentGroupBox.Controls.Add(enrollStudentButton);
            enrollStudentGroupBox.Controls.Add(studentLabel);
            enrollStudentGroupBox.Controls.Add(studentNamesLabel);
            enrollStudentGroupBox.Controls.Add(addSubjectLabel);
            enrollStudentGroupBox.Controls.Add(addSubjectComboBox);
            enrollStudentGroupBox.Font = new Font("Segoe UI", 10F);
            enrollStudentGroupBox.Location = new Point(58, 619);
            enrollStudentGroupBox.Name = "enrollStudentGroupBox";
            enrollStudentGroupBox.Size = new Size(1182, 299);
            enrollStudentGroupBox.TabIndex = 23;
            enrollStudentGroupBox.TabStop = false;
            enrollStudentGroupBox.Text = "inscribir estudiane";
            // 
            // deleteEnrollStudentButton
            // 
            deleteEnrollStudentButton.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            deleteEnrollStudentButton.IconColor = Color.Black;
            deleteEnrollStudentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteEnrollStudentButton.IconSize = 35;
            deleteEnrollStudentButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteEnrollStudentButton.Location = new Point(862, 173);
            deleteEnrollStudentButton.Name = "deleteEnrollStudentButton";
            deleteEnrollStudentButton.Size = new Size(210, 39);
            deleteEnrollStudentButton.TabIndex = 25;
            deleteEnrollStudentButton.Text = "retirar materia";
            deleteEnrollStudentButton.UseVisualStyleBackColor = true;
            deleteEnrollStudentButton.Click += deleteEnrollStudentButton_Click;
            // 
            // enrollStudentButton
            // 
            enrollStudentButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            enrollStudentButton.IconColor = Color.Black;
            enrollStudentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            enrollStudentButton.IconSize = 35;
            enrollStudentButton.ImageAlign = ContentAlignment.MiddleLeft;
            enrollStudentButton.Location = new Point(862, 70);
            enrollStudentButton.Name = "enrollStudentButton";
            enrollStudentButton.Size = new Size(210, 39);
            enrollStudentButton.TabIndex = 23;
            enrollStudentButton.Text = "inscribir estudiante";
            enrollStudentButton.TextAlign = ContentAlignment.MiddleRight;
            enrollStudentButton.UseVisualStyleBackColor = true;
            enrollStudentButton.Click += enrollStudentButton_Click;
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(38, 70);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(104, 23);
            studentLabel.TabIndex = 21;
            studentLabel.Text = "estudiante : ";
            // 
            // studentNamesLabel
            // 
            studentNamesLabel.Location = new Point(157, 70);
            studentNamesLabel.Name = "studentNamesLabel";
            studentNamesLabel.Size = new Size(318, 25);
            studentNamesLabel.TabIndex = 22;
            studentNamesLabel.Text = "nombre del estudiante";
            studentNamesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addSubjectLabel
            // 
            addSubjectLabel.AutoSize = true;
            addSubjectLabel.Location = new Point(28, 144);
            addSubjectLabel.Name = "addSubjectLabel";
            addSubjectLabel.Size = new Size(68, 23);
            addSubjectLabel.TabIndex = 19;
            addSubjectLabel.Text = "materia";
            // 
            // addSubjectComboBox
            // 
            addSubjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addSubjectComboBox.FormattingEnabled = true;
            addSubjectComboBox.Location = new Point(108, 144);
            addSubjectComboBox.Name = "addSubjectComboBox";
            addSubjectComboBox.Size = new Size(564, 31);
            addSubjectComboBox.TabIndex = 20;
            // 
            // subjectDataGridView
            // 
            subjectDataGridView.AllowUserToAddRows = false;
            subjectDataGridView.AllowUserToDeleteRows = false;
            subjectDataGridView.AllowUserToOrderColumns = true;
            subjectDataGridView.AllowUserToResizeColumns = false;
            subjectDataGridView.AllowUserToResizeRows = false;
            subjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            subjectDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            subjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subjectDataGridView.Location = new Point(941, 179);
            subjectDataGridView.MultiSelect = false;
            subjectDataGridView.Name = "subjectDataGridView";
            subjectDataGridView.RowHeadersVisible = false;
            subjectDataGridView.RowHeadersWidth = 51;
            subjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subjectDataGridView.Size = new Size(584, 385);
            subjectDataGridView.TabIndex = 18;
            subjectDataGridView.SelectionChanged += subjectDataGridView_SelectionChanged;
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.AllowUserToAddRows = false;
            studentsDataGridView.AllowUserToDeleteRows = false;
            studentsDataGridView.AllowUserToOrderColumns = true;
            studentsDataGridView.AllowUserToResizeColumns = false;
            studentsDataGridView.AllowUserToResizeRows = false;
            studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(26, 179);
            studentsDataGridView.MultiSelect = false;
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.RowHeadersVisible = false;
            studentsDataGridView.RowHeadersWidth = 51;
            studentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsDataGridView.Size = new Size(876, 385);
            studentsDataGridView.TabIndex = 17;
            studentsDataGridView.SelectionChanged += studentsDataGridView_SelectionChanged;
            // 
            // searchStudentGroupBox
            // 
            searchStudentGroupBox.Controls.Add(searchStudentButton);
            searchStudentGroupBox.Controls.Add(searchStudentLabel);
            searchStudentGroupBox.Controls.Add(searchStudentTextBox);
            searchStudentGroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            searchStudentGroupBox.Location = new Point(58, 29);
            searchStudentGroupBox.Name = "searchStudentGroupBox";
            searchStudentGroupBox.Size = new Size(1044, 69);
            searchStudentGroupBox.TabIndex = 16;
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
            // studentsAndSubjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Name = "studentsAndSubjectsForm";
            Text = "studentsAndSubjectsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            enrollStudentGroupBox.ResumeLayout(false);
            enrollStudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            searchStudentGroupBox.ResumeLayout(false);
            searchStudentGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox searchStudentGroupBox;
        private FontAwesome.Sharp.IconButton searchStudentButton;
        private Label searchStudentLabel;
        private TextBox searchStudentTextBox;
        private DataGridView studentsDataGridView;
        private DataGridView subjectDataGridView;
        private ComboBox addSubjectComboBox;
        private Label addSubjectLabel;
        private Label studentNamesLabel;
        private Label studentLabel;
        private GroupBox enrollStudentGroupBox;
        private FontAwesome.Sharp.IconButton enrollStudentButton;
        private FontAwesome.Sharp.IconButton deleteEnrollStudentButton;
        private Label subjectTittleLabel;
        private Label studentTittleLabel;
    }
}