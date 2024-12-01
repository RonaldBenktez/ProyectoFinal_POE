namespace PresentationLayer.Forms
{
    partial class SubjectsForm
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
            subjectDataGridView = new DataGridView();
            addSujectGroupBox = new GroupBox();
            addYearDateTimePicker = new DateTimePicker();
            addSectionComboBox = new ComboBox();
            addSujectNameTextBox = new TextBox();
            label3 = new Label();
            addSecttionLabel = new Label();
            addSubjectNameLabel = new Label();
            addSubjectButton = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            deleteSubjectButton = new FontAwesome.Sharp.IconButton();
            editYearDateTimePicker = new DateTimePicker();
            editSectionComboBox = new ComboBox();
            editNameSubjectTextBox = new TextBox();
            editYearLabel = new Label();
            editSectionLabel = new Label();
            editSubjectNameLabel = new Label();
            editSubjectButton = new FontAwesome.Sharp.IconButton();
            teacherAndSubjectGroupBox = new GroupBox();
            deleteTaeacherAndSubjectButton = new FontAwesome.Sharp.IconButton();
            editTeacherButton = new FontAwesome.Sharp.IconButton();
            addTeacherButton = new FontAwesome.Sharp.IconButton();
            SubjectComboBox = new ComboBox();
            teacherComboBox = new ComboBox();
            subjectLabel = new Label();
            teacherLabel = new Label();
            teachersAndSubjectDataGridView = new DataGridView();
            subjectsErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).BeginInit();
            addSujectGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            teacherAndSubjectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersAndSubjectDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectsErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // subjectDataGridView
            // 
            subjectDataGridView.AllowUserToAddRows = false;
            subjectDataGridView.AllowUserToDeleteRows = false;
            subjectDataGridView.AllowUserToResizeColumns = false;
            subjectDataGridView.AllowUserToResizeRows = false;
            subjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            subjectDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            subjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subjectDataGridView.Location = new Point(264, 289);
            subjectDataGridView.MultiSelect = false;
            subjectDataGridView.Name = "subjectDataGridView";
            subjectDataGridView.RowHeadersWidth = 51;
            subjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subjectDataGridView.Size = new Size(1032, 304);
            subjectDataGridView.TabIndex = 8;
            subjectDataGridView.SelectionChanged += subjectDataGridView_SelectionChanged;
            // 
            // addSujectGroupBox
            // 
            addSujectGroupBox.Controls.Add(addYearDateTimePicker);
            addSujectGroupBox.Controls.Add(addSectionComboBox);
            addSujectGroupBox.Controls.Add(addSujectNameTextBox);
            addSujectGroupBox.Controls.Add(label3);
            addSujectGroupBox.Controls.Add(addSecttionLabel);
            addSujectGroupBox.Controls.Add(addSubjectNameLabel);
            addSujectGroupBox.Controls.Add(addSubjectButton);
            addSujectGroupBox.Location = new Point(68, 23);
            addSujectGroupBox.Name = "addSujectGroupBox";
            addSujectGroupBox.Size = new Size(581, 243);
            addSujectGroupBox.TabIndex = 9;
            addSujectGroupBox.TabStop = false;
            addSujectGroupBox.Text = "agregar materia";
            // 
            // addYearDateTimePicker
            // 
            addYearDateTimePicker.Format = DateTimePickerFormat.Custom;
            addYearDateTimePicker.Location = new Point(186, 141);
            addYearDateTimePicker.Name = "addYearDateTimePicker";
            addYearDateTimePicker.ShowUpDown = true;
            addYearDateTimePicker.Size = new Size(147, 27);
            addYearDateTimePicker.TabIndex = 17;
            // 
            // addSectionComboBox
            // 
            addSectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addSectionComboBox.FormattingEnabled = true;
            addSectionComboBox.Location = new Point(186, 93);
            addSectionComboBox.Name = "addSectionComboBox";
            addSectionComboBox.Size = new Size(203, 28);
            addSectionComboBox.TabIndex = 16;
            // 
            // addSujectNameTextBox
            // 
            addSujectNameTextBox.Location = new Point(186, 41);
            addSujectNameTextBox.Name = "addSujectNameTextBox";
            addSujectNameTextBox.Size = new Size(189, 27);
            addSujectNameTextBox.TabIndex = 15;
            addSujectNameTextBox.TextChanged += addSujectNameTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 146);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 14;
            label3.Text = "año";
            // 
            // addSecttionLabel
            // 
            addSecttionLabel.AutoSize = true;
            addSecttionLabel.Location = new Point(81, 93);
            addSecttionLabel.Name = "addSecttionLabel";
            addSecttionLabel.Size = new Size(62, 20);
            addSecttionLabel.TabIndex = 13;
            addSecttionLabel.Text = "seccion ";
            // 
            // addSubjectNameLabel
            // 
            addSubjectNameLabel.AutoSize = true;
            addSubjectNameLabel.Location = new Point(6, 44);
            addSubjectNameLabel.Name = "addSubjectNameLabel";
            addSubjectNameLabel.Size = new Size(153, 20);
            addSubjectNameLabel.TabIndex = 12;
            addSubjectNameLabel.Text = "nombre de la materia";
            // 
            // addSubjectButton
            // 
            addSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addSubjectButton.IconColor = Color.Black;
            addSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addSubjectButton.Location = new Point(435, 92);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(140, 29);
            addSubjectButton.TabIndex = 11;
            addSubjectButton.Text = "añadir materia";
            addSubjectButton.UseVisualStyleBackColor = true;
            addSubjectButton.Click += addSubjectButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteSubjectButton);
            groupBox2.Controls.Add(editYearDateTimePicker);
            groupBox2.Controls.Add(editSectionComboBox);
            groupBox2.Controls.Add(editNameSubjectTextBox);
            groupBox2.Controls.Add(editYearLabel);
            groupBox2.Controls.Add(editSectionLabel);
            groupBox2.Controls.Add(editSubjectNameLabel);
            groupBox2.Controls.Add(editSubjectButton);
            groupBox2.Location = new Point(722, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 254);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "editar materia";
            // 
            // deleteSubjectButton
            // 
            deleteSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            deleteSubjectButton.IconColor = Color.Black;
            deleteSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteSubjectButton.Location = new Point(434, 136);
            deleteSubjectButton.Name = "deleteSubjectButton";
            deleteSubjectButton.Size = new Size(140, 29);
            deleteSubjectButton.TabIndex = 18;
            deleteSubjectButton.Text = "eliminar materia";
            deleteSubjectButton.UseVisualStyleBackColor = true;
            deleteSubjectButton.Click += deleteSubjectButton_Click;
            // 
            // editYearDateTimePicker
            // 
            editYearDateTimePicker.Format = DateTimePickerFormat.Custom;
            editYearDateTimePicker.Location = new Point(219, 160);
            editYearDateTimePicker.Name = "editYearDateTimePicker";
            editYearDateTimePicker.ShowUpDown = true;
            editYearDateTimePicker.Size = new Size(147, 27);
            editYearDateTimePicker.TabIndex = 17;
            // 
            // editSectionComboBox
            // 
            editSectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editSectionComboBox.FormattingEnabled = true;
            editSectionComboBox.Location = new Point(219, 104);
            editSectionComboBox.Name = "editSectionComboBox";
            editSectionComboBox.Size = new Size(151, 28);
            editSectionComboBox.TabIndex = 16;
            // 
            // editNameSubjectTextBox
            // 
            editNameSubjectTextBox.Location = new Point(219, 49);
            editNameSubjectTextBox.Name = "editNameSubjectTextBox";
            editNameSubjectTextBox.Size = new Size(172, 27);
            editNameSubjectTextBox.TabIndex = 15;
            editNameSubjectTextBox.TextChanged += editNameSubjectTextBox_TextChanged;
            // 
            // editYearLabel
            // 
            editYearLabel.AutoSize = true;
            editYearLabel.Location = new Point(101, 160);
            editYearLabel.Name = "editYearLabel";
            editYearLabel.Size = new Size(34, 20);
            editYearLabel.TabIndex = 14;
            editYearLabel.Text = "año";
            // 
            // editSectionLabel
            // 
            editSectionLabel.AutoSize = true;
            editSectionLabel.Location = new Point(77, 120);
            editSectionLabel.Name = "editSectionLabel";
            editSectionLabel.Size = new Size(58, 20);
            editSectionLabel.TabIndex = 13;
            editSectionLabel.Text = "seccion";
            // 
            // editSubjectNameLabel
            // 
            editSubjectNameLabel.AutoSize = true;
            editSubjectNameLabel.Location = new Point(32, 52);
            editSubjectNameLabel.Name = "editSubjectNameLabel";
            editSubjectNameLabel.Size = new Size(153, 20);
            editSubjectNameLabel.TabIndex = 12;
            editSubjectNameLabel.Text = "nombre de la materia";
            // 
            // editSubjectButton
            // 
            editSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            editSubjectButton.IconColor = Color.Black;
            editSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editSubjectButton.Location = new Point(434, 55);
            editSubjectButton.Name = "editSubjectButton";
            editSubjectButton.Size = new Size(140, 29);
            editSubjectButton.TabIndex = 11;
            editSubjectButton.Text = "editar materia";
            editSubjectButton.UseVisualStyleBackColor = true;
            editSubjectButton.Click += editSubjectButton_Click;
            // 
            // teacherAndSubjectGroupBox
            // 
            teacherAndSubjectGroupBox.Controls.Add(deleteTaeacherAndSubjectButton);
            teacherAndSubjectGroupBox.Controls.Add(editTeacherButton);
            teacherAndSubjectGroupBox.Controls.Add(addTeacherButton);
            teacherAndSubjectGroupBox.Controls.Add(SubjectComboBox);
            teacherAndSubjectGroupBox.Controls.Add(teacherComboBox);
            teacherAndSubjectGroupBox.Controls.Add(subjectLabel);
            teacherAndSubjectGroupBox.Controls.Add(teacherLabel);
            teacherAndSubjectGroupBox.Location = new Point(21, 677);
            teacherAndSubjectGroupBox.Name = "teacherAndSubjectGroupBox";
            teacherAndSubjectGroupBox.Size = new Size(781, 173);
            teacherAndSubjectGroupBox.TabIndex = 11;
            teacherAndSubjectGroupBox.TabStop = false;
            teacherAndSubjectGroupBox.Text = "asignar materia a un docente";
            // 
            // deleteTaeacherAndSubjectButton
            // 
            deleteTaeacherAndSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            deleteTaeacherAndSubjectButton.IconColor = Color.Black;
            deleteTaeacherAndSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteTaeacherAndSubjectButton.Location = new Point(569, 126);
            deleteTaeacherAndSubjectButton.Name = "deleteTaeacherAndSubjectButton";
            deleteTaeacherAndSubjectButton.Size = new Size(134, 29);
            deleteTaeacherAndSubjectButton.TabIndex = 13;
            deleteTaeacherAndSubjectButton.Text = "eliminar";
            deleteTaeacherAndSubjectButton.UseVisualStyleBackColor = true;
            deleteTaeacherAndSubjectButton.Click += deleteTaeacherAndSubjectButton_Click;
            // 
            // editTeacherButton
            // 
            editTeacherButton.IconChar = FontAwesome.Sharp.IconChar.None;
            editTeacherButton.IconColor = Color.Black;
            editTeacherButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editTeacherButton.Location = new Point(364, 126);
            editTeacherButton.Name = "editTeacherButton";
            editTeacherButton.Size = new Size(134, 29);
            editTeacherButton.TabIndex = 5;
            editTeacherButton.Text = "editar";
            editTeacherButton.UseVisualStyleBackColor = true;
            editTeacherButton.Click += editTeacherButton_Click;
            // 
            // addTeacherButton
            // 
            addTeacherButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addTeacherButton.IconColor = Color.Black;
            addTeacherButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addTeacherButton.Location = new Point(128, 126);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(134, 29);
            addTeacherButton.TabIndex = 4;
            addTeacherButton.Text = "añadir";
            addTeacherButton.UseVisualStyleBackColor = true;
            addTeacherButton.Click += addTeacherButton_Click;
            // 
            // SubjectComboBox
            // 
            SubjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectComboBox.FormattingEnabled = true;
            SubjectComboBox.Location = new Point(473, 60);
            SubjectComboBox.Name = "SubjectComboBox";
            SubjectComboBox.Size = new Size(285, 28);
            SubjectComboBox.TabIndex = 3;
            // 
            // teacherComboBox
            // 
            teacherComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teacherComboBox.FormattingEnabled = true;
            teacherComboBox.Location = new Point(86, 64);
            teacherComboBox.Name = "teacherComboBox";
            teacherComboBox.Size = new Size(294, 28);
            teacherComboBox.TabIndex = 2;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new Point(407, 67);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(60, 20);
            subjectLabel.TabIndex = 1;
            subjectLabel.Text = "materia";
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.Location = new Point(17, 66);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new Size(63, 20);
            teacherLabel.TabIndex = 0;
            teacherLabel.Text = "docente";
            // 
            // teachersAndSubjectDataGridView
            // 
            teachersAndSubjectDataGridView.AllowUserToAddRows = false;
            teachersAndSubjectDataGridView.AllowUserToDeleteRows = false;
            teachersAndSubjectDataGridView.AllowUserToResizeColumns = false;
            teachersAndSubjectDataGridView.AllowUserToResizeRows = false;
            teachersAndSubjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teachersAndSubjectDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            teachersAndSubjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teachersAndSubjectDataGridView.Location = new Point(826, 677);
            teachersAndSubjectDataGridView.MultiSelect = false;
            teachersAndSubjectDataGridView.Name = "teachersAndSubjectDataGridView";
            teachersAndSubjectDataGridView.RowHeadersVisible = false;
            teachersAndSubjectDataGridView.RowHeadersWidth = 51;
            teachersAndSubjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teachersAndSubjectDataGridView.Size = new Size(660, 254);
            teachersAndSubjectDataGridView.TabIndex = 12;
            teachersAndSubjectDataGridView.SelectionChanged += teachersAndSubjectDataGridView_SelectionChanged;
            // 
            // subjectsErrorProvider
            // 
            subjectsErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            subjectsErrorProvider.ContainerControl = this;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1516, 1055);
            Controls.Add(teachersAndSubjectDataGridView);
            Controls.Add(teacherAndSubjectGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(addSujectGroupBox);
            Controls.Add(subjectDataGridView);
            Name = "SubjectsForm";
            Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).EndInit();
            addSujectGroupBox.ResumeLayout(false);
            addSujectGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            teacherAndSubjectGroupBox.ResumeLayout(false);
            teacherAndSubjectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersAndSubjectDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectsErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView subjectDataGridView;
        private GroupBox addSujectGroupBox;
        private FontAwesome.Sharp.IconButton addSubjectButton;
        private DateTimePicker addYearDateTimePicker;
        private ComboBox addSectionComboBox;
        private TextBox addSujectNameTextBox;
        private Label label3;
        private Label addSecttionLabel;
        private Label addSubjectNameLabel;
        private GroupBox groupBox2;
        private DateTimePicker editYearDateTimePicker;
        private ComboBox editSectionComboBox;
        private TextBox editNameSubjectTextBox;
        private Label editYearLabel;
        private Label editSectionLabel;
        private Label editSubjectNameLabel;
        private FontAwesome.Sharp.IconButton editSubjectButton;
        private FontAwesome.Sharp.IconButton deleteSubjectButton;
        private GroupBox teacherAndSubjectGroupBox;
        private ComboBox SubjectComboBox;
        private ComboBox teacherComboBox;
        private Label subjectLabel;
        private Label teacherLabel;
        private FontAwesome.Sharp.IconButton editTeacherButton;
        private FontAwesome.Sharp.IconButton addTeacherButton;
        private DataGridView teachersAndSubjectDataGridView;
        private FontAwesome.Sharp.IconButton deleteTaeacherAndSubjectButton;
        private ErrorProvider subjectsErrorProvider;
    }
}