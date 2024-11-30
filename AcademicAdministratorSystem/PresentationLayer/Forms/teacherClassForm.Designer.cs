namespace PresentationLayer.Forms
{
    partial class TeacherClassForm
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
            addClassgroupBox = new GroupBox();
            addClassButton = new FontAwesome.Sharp.IconButton();
            addContentTextBox = new TextBox();
            addContentLabel = new Label();
            addSubjectComboBox = new ComboBox();
            addSubjectLabel = new Label();
            classesDataGridView = new DataGridView();
            deleteClassButton = new FontAwesome.Sharp.IconButton();
            editClassGroupBox = new GroupBox();
            editClassButton = new FontAwesome.Sharp.IconButton();
            editContentTextBox = new TextBox();
            editContentLabel = new Label();
            editSubjectComboBox = new ComboBox();
            editSubjectLabel = new Label();
            classesPanel = new Panel();
            classesTittleLabel = new Label();
            subjectsPanel = new Panel();
            subjectTittleLabel = new Label();
            selectionSubjectButton = new FontAwesome.Sharp.IconButton();
            subjectDataGridView = new DataGridView();
            subjectLabel = new Label();
            studentsPanel = new Panel();
            label6 = new Label();
            studentsDataGridView = new DataGridView();
            contentErrorProvider = new ErrorProvider(components);
            addClassgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classesDataGridView).BeginInit();
            editClassGroupBox.SuspendLayout();
            classesPanel.SuspendLayout();
            subjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).BeginInit();
            studentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contentErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // addClassgroupBox
            // 
            addClassgroupBox.Controls.Add(addClassButton);
            addClassgroupBox.Controls.Add(addContentTextBox);
            addClassgroupBox.Controls.Add(addContentLabel);
            addClassgroupBox.Controls.Add(addSubjectComboBox);
            addClassgroupBox.Controls.Add(addSubjectLabel);
            addClassgroupBox.Location = new Point(41, 44);
            addClassgroupBox.Name = "addClassgroupBox";
            addClassgroupBox.Size = new Size(501, 195);
            addClassgroupBox.TabIndex = 0;
            addClassgroupBox.TabStop = false;
            addClassgroupBox.Text = "agregar clase";
            // 
            // addClassButton
            // 
            addClassButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addClassButton.IconColor = Color.Black;
            addClassButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addClassButton.Location = new Point(22, 143);
            addClassButton.Name = "addClassButton";
            addClassButton.Size = new Size(146, 37);
            addClassButton.TabIndex = 14;
            addClassButton.Text = "agregar";
            addClassButton.UseVisualStyleBackColor = true;
            addClassButton.Click += addClassButton_Click;
            // 
            // addContentTextBox
            // 
            addContentTextBox.Location = new Point(169, 99);
            addContentTextBox.Name = "addContentTextBox";
            addContentTextBox.Size = new Size(286, 27);
            addContentTextBox.TabIndex = 3;
            addContentTextBox.TextChanged += addContentTextBox_TextChanged;
            // 
            // addContentLabel
            // 
            addContentLabel.AutoSize = true;
            addContentLabel.Location = new Point(22, 102);
            addContentLabel.Name = "addContentLabel";
            addContentLabel.Size = new Size(132, 20);
            addContentLabel.TabIndex = 2;
            addContentLabel.Text = "agregar contenido";
            // 
            // addSubjectComboBox
            // 
            addSubjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addSubjectComboBox.FormattingEnabled = true;
            addSubjectComboBox.Location = new Point(102, 42);
            addSubjectComboBox.Name = "addSubjectComboBox";
            addSubjectComboBox.Size = new Size(228, 28);
            addSubjectComboBox.TabIndex = 1;
            // 
            // addSubjectLabel
            // 
            addSubjectLabel.AutoSize = true;
            addSubjectLabel.Location = new Point(22, 42);
            addSubjectLabel.Name = "addSubjectLabel";
            addSubjectLabel.Size = new Size(60, 20);
            addSubjectLabel.TabIndex = 0;
            addSubjectLabel.Text = "materia";
            // 
            // classesDataGridView
            // 
            classesDataGridView.AllowUserToAddRows = false;
            classesDataGridView.AllowUserToDeleteRows = false;
            classesDataGridView.AllowUserToOrderColumns = true;
            classesDataGridView.AllowUserToResizeColumns = false;
            classesDataGridView.AllowUserToResizeRows = false;
            classesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            classesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classesDataGridView.Location = new Point(618, 86);
            classesDataGridView.MultiSelect = false;
            classesDataGridView.Name = "classesDataGridView";
            classesDataGridView.RowHeadersVisible = false;
            classesDataGridView.RowHeadersWidth = 51;
            classesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            classesDataGridView.Size = new Size(663, 387);
            classesDataGridView.TabIndex = 8;
            classesDataGridView.SelectionChanged += classesDataGridView_SelectionChanged;
            // 
            // deleteClassButton
            // 
            deleteClassButton.IconChar = FontAwesome.Sharp.IconChar.None;
            deleteClassButton.IconColor = Color.Black;
            deleteClassButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteClassButton.Location = new Point(1308, 220);
            deleteClassButton.Name = "deleteClassButton";
            deleteClassButton.Size = new Size(146, 51);
            deleteClassButton.TabIndex = 13;
            deleteClassButton.Text = "eliminar";
            deleteClassButton.UseVisualStyleBackColor = true;
            deleteClassButton.Click += deleteClassButton_Click;
            // 
            // editClassGroupBox
            // 
            editClassGroupBox.Controls.Add(editClassButton);
            editClassGroupBox.Controls.Add(editContentTextBox);
            editClassGroupBox.Controls.Add(editContentLabel);
            editClassGroupBox.Controls.Add(editSubjectComboBox);
            editClassGroupBox.Controls.Add(editSubjectLabel);
            editClassGroupBox.Location = new Point(41, 264);
            editClassGroupBox.Name = "editClassGroupBox";
            editClassGroupBox.Size = new Size(501, 199);
            editClassGroupBox.TabIndex = 11;
            editClassGroupBox.TabStop = false;
            editClassGroupBox.Text = "editar clase";
            // 
            // editClassButton
            // 
            editClassButton.IconChar = FontAwesome.Sharp.IconChar.None;
            editClassButton.IconColor = Color.Black;
            editClassButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editClassButton.Location = new Point(22, 134);
            editClassButton.Name = "editClassButton";
            editClassButton.Size = new Size(146, 37);
            editClassButton.TabIndex = 16;
            editClassButton.Text = "editar";
            editClassButton.UseVisualStyleBackColor = true;
            editClassButton.Click += editClassButton_Click;
            // 
            // editContentTextBox
            // 
            editContentTextBox.Location = new Point(210, 92);
            editContentTextBox.Name = "editContentTextBox";
            editContentTextBox.Size = new Size(230, 27);
            editContentTextBox.TabIndex = 3;
            editContentTextBox.TextChanged += editContentTextBox_TextChanged;
            // 
            // editContentLabel
            // 
            editContentLabel.AutoSize = true;
            editContentLabel.Location = new Point(39, 99);
            editContentLabel.Name = "editContentLabel";
            editContentLabel.Size = new Size(119, 20);
            editContentLabel.TabIndex = 2;
            editContentLabel.Text = "editar contenido";
            // 
            // editSubjectComboBox
            // 
            editSubjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editSubjectComboBox.FormattingEnabled = true;
            editSubjectComboBox.Location = new Point(105, 50);
            editSubjectComboBox.Name = "editSubjectComboBox";
            editSubjectComboBox.Size = new Size(228, 28);
            editSubjectComboBox.TabIndex = 1;
            editSubjectComboBox.Click += editSubjectComboBox_Click;
            // 
            // editSubjectLabel
            // 
            editSubjectLabel.AutoSize = true;
            editSubjectLabel.Location = new Point(39, 52);
            editSubjectLabel.Name = "editSubjectLabel";
            editSubjectLabel.Size = new Size(60, 20);
            editSubjectLabel.TabIndex = 0;
            editSubjectLabel.Text = "materia";
            // 
            // classesPanel
            // 
            classesPanel.Controls.Add(classesTittleLabel);
            classesPanel.Controls.Add(addClassgroupBox);
            classesPanel.Controls.Add(deleteClassButton);
            classesPanel.Controls.Add(editClassGroupBox);
            classesPanel.Controls.Add(classesDataGridView);
            classesPanel.Location = new Point(10, 463);
            classesPanel.Name = "classesPanel";
            classesPanel.Size = new Size(1475, 506);
            classesPanel.TabIndex = 14;
            // 
            // classesTittleLabel
            // 
            classesTittleLabel.AutoSize = true;
            classesTittleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            classesTittleLabel.Location = new Point(965, 26);
            classesTittleLabel.Name = "classesTittleLabel";
            classesTittleLabel.Size = new Size(81, 32);
            classesTittleLabel.TabIndex = 15;
            classesTittleLabel.Text = "clases";
            // 
            // subjectsPanel
            // 
            subjectsPanel.Controls.Add(subjectTittleLabel);
            subjectsPanel.Controls.Add(selectionSubjectButton);
            subjectsPanel.Controls.Add(subjectDataGridView);
            subjectsPanel.Controls.Add(subjectLabel);
            subjectsPanel.Location = new Point(10, 12);
            subjectsPanel.Name = "subjectsPanel";
            subjectsPanel.Size = new Size(660, 423);
            subjectsPanel.TabIndex = 15;
            // 
            // subjectTittleLabel
            // 
            subjectTittleLabel.AutoSize = true;
            subjectTittleLabel.Location = new Point(20, 53);
            subjectTittleLabel.Name = "subjectTittleLabel";
            subjectTittleLabel.Size = new Size(322, 20);
            subjectTittleLabel.TabIndex = 15;
            subjectTittleLabel.Text = "seleccione una materia para ver sus estudiantes";
            // 
            // selectionSubjectButton
            // 
            selectionSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            selectionSubjectButton.IconColor = Color.Black;
            selectionSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            selectionSubjectButton.Location = new Point(522, 196);
            selectionSubjectButton.Name = "selectionSubjectButton";
            selectionSubjectButton.Size = new Size(121, 41);
            selectionSubjectButton.TabIndex = 14;
            selectionSubjectButton.Text = "seleccionar";
            selectionSubjectButton.UseVisualStyleBackColor = true;
            selectionSubjectButton.Click += selectionSubjectButton_Click_1;
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
            subjectDataGridView.Location = new Point(20, 89);
            subjectDataGridView.MultiSelect = false;
            subjectDataGridView.Name = "subjectDataGridView";
            subjectDataGridView.RowHeadersVisible = false;
            subjectDataGridView.RowHeadersWidth = 51;
            subjectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subjectDataGridView.Size = new Size(496, 311);
            subjectDataGridView.TabIndex = 9;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new Point(342, 17);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(93, 20);
            subjectLabel.TabIndex = 0;
            subjectLabel.Text = "mis materias";
            // 
            // studentsPanel
            // 
            studentsPanel.Controls.Add(label6);
            studentsPanel.Controls.Add(studentsDataGridView);
            studentsPanel.Location = new Point(692, 12);
            studentsPanel.Name = "studentsPanel";
            studentsPanel.Size = new Size(965, 423);
            studentsPanel.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 17);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 12;
            label6.Text = "estudiantes ";
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
            studentsDataGridView.Location = new Point(25, 135);
            studentsDataGridView.MultiSelect = false;
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.RowHeadersVisible = false;
            studentsDataGridView.RowHeadersWidth = 51;
            studentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsDataGridView.Size = new Size(902, 274);
            studentsDataGridView.TabIndex = 10;
            // 
            // contentErrorProvider
            // 
            contentErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            contentErrorProvider.ContainerControl = this;
            // 
            // TeacherClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(studentsPanel);
            Controls.Add(subjectsPanel);
            Controls.Add(classesPanel);
            Name = "TeacherClassForm";
            addClassgroupBox.ResumeLayout(false);
            addClassgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classesDataGridView).EndInit();
            editClassGroupBox.ResumeLayout(false);
            editClassGroupBox.PerformLayout();
            classesPanel.ResumeLayout(false);
            classesPanel.PerformLayout();
            subjectsPanel.ResumeLayout(false);
            subjectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).EndInit();
            studentsPanel.ResumeLayout(false);
            studentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)contentErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addClassgroupBox;
        private Label addSubjectLabel;
        private ComboBox addSubjectComboBox;
        private TextBox addContentTextBox;
        private Label addContentLabel;
        private DataGridView classesDataGridView;
        private FontAwesome.Sharp.IconButton deleteClassButton;
        private GroupBox editClassGroupBox;
        private TextBox editContentTextBox;
        private Label editContentLabel;
        private ComboBox editSubjectComboBox;
        private Label editSubjectLabel;
        private Panel classesPanel;
        private Panel subjectsPanel;
        private Label subjectLabel;
        private FontAwesome.Sharp.IconButton selectionSubjectButton;
        private DataGridView subjectDataGridView;
        private Panel studentsPanel;
        private DataGridView studentsDataGridView;
        private Label subjectTittleLabel;
        private Label label6;
        private Label classesTittleLabel;
        private FontAwesome.Sharp.IconButton editClassButton;
        private FontAwesome.Sharp.IconButton addClassButton;
        private ErrorProvider contentErrorProvider;
    }
}