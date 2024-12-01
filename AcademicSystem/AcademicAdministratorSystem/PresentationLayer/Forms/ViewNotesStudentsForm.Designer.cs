namespace PresentationLayer.Forms
{
    partial class ViewNotesStudentsForm
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
            subjectsGroupBox = new GroupBox();
            subjectTittleLabel = new Label();
            subjectsDataGridView = new DataGridView();
            notesGroupBox = new GroupBox();
            notesTittlelabel = new Label();
            notesDataGridView = new DataGridView();
            stundenLabel = new Label();
            studentNameLabel = new Label();
            studentNameGroupBox = new GroupBox();
            subjectsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subjectsDataGridView).BeginInit();
            notesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notesDataGridView).BeginInit();
            studentNameGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // subjectsGroupBox
            // 
            subjectsGroupBox.Controls.Add(subjectTittleLabel);
            subjectsGroupBox.Controls.Add(subjectsDataGridView);
            subjectsGroupBox.Location = new Point(13, 86);
            subjectsGroupBox.Name = "subjectsGroupBox";
            subjectsGroupBox.Size = new Size(1368, 422);
            subjectsGroupBox.TabIndex = 0;
            subjectsGroupBox.TabStop = false;
            // 
            // subjectTittleLabel
            // 
            subjectTittleLabel.AutoSize = true;
            subjectTittleLabel.Location = new Point(667, 38);
            subjectTittleLabel.Name = "subjectTittleLabel";
            subjectTittleLabel.Size = new Size(97, 20);
            subjectTittleLabel.TabIndex = 9;
            subjectTittleLabel.Text = "mis materias ";
            // 
            // subjectsDataGridView
            // 
            subjectsDataGridView.AllowUserToAddRows = false;
            subjectsDataGridView.AllowUserToDeleteRows = false;
            subjectsDataGridView.AllowUserToOrderColumns = true;
            subjectsDataGridView.AllowUserToResizeColumns = false;
            subjectsDataGridView.AllowUserToResizeRows = false;
            subjectsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            subjectsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            subjectsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subjectsDataGridView.Location = new Point(24, 94);
            subjectsDataGridView.MultiSelect = false;
            subjectsDataGridView.Name = "subjectsDataGridView";
            subjectsDataGridView.RowHeadersVisible = false;
            subjectsDataGridView.RowHeadersWidth = 51;
            subjectsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subjectsDataGridView.Size = new Size(1274, 299);
            subjectsDataGridView.TabIndex = 8;
            // 
            // notesGroupBox
            // 
            notesGroupBox.Controls.Add(notesTittlelabel);
            notesGroupBox.Controls.Add(notesDataGridView);
            notesGroupBox.Location = new Point(13, 539);
            notesGroupBox.Name = "notesGroupBox";
            notesGroupBox.Size = new Size(1368, 438);
            notesGroupBox.TabIndex = 1;
            notesGroupBox.TabStop = false;
            // 
            // notesTittlelabel
            // 
            notesTittlelabel.AutoSize = true;
            notesTittlelabel.Location = new Point(692, 23);
            notesTittlelabel.Name = "notesTittlelabel";
            notesTittlelabel.Size = new Size(72, 20);
            notesTittlelabel.TabIndex = 9;
            notesTittlelabel.Text = "mis notas";
            // 
            // notesDataGridView
            // 
            notesDataGridView.AllowUserToAddRows = false;
            notesDataGridView.AllowUserToDeleteRows = false;
            notesDataGridView.AllowUserToOrderColumns = true;
            notesDataGridView.AllowUserToResizeColumns = false;
            notesDataGridView.AllowUserToResizeRows = false;
            notesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            notesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notesDataGridView.Location = new Point(24, 64);
            notesDataGridView.MultiSelect = false;
            notesDataGridView.Name = "notesDataGridView";
            notesDataGridView.RowHeadersVisible = false;
            notesDataGridView.RowHeadersWidth = 51;
            notesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            notesDataGridView.Size = new Size(1274, 340);
            notesDataGridView.TabIndex = 8;
            // 
            // stundenLabel
            // 
            stundenLabel.AutoSize = true;
            stundenLabel.Location = new Point(200, 23);
            stundenLabel.Name = "stundenLabel";
            stundenLabel.Size = new Size(70, 20);
            stundenLabel.TabIndex = 2;
            stundenLabel.Text = "alumno : ";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new Point(303, 23);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(50, 20);
            studentNameLabel.TabIndex = 3;
            studentNameLabel.Text = "label4";
            // 
            // studentNameGroupBox
            // 
            studentNameGroupBox.Controls.Add(studentNameLabel);
            studentNameGroupBox.Controls.Add(stundenLabel);
            studentNameGroupBox.Location = new Point(321, 12);
            studentNameGroupBox.Name = "studentNameGroupBox";
            studentNameGroupBox.Size = new Size(776, 77);
            studentNameGroupBox.TabIndex = 4;
            studentNameGroupBox.TabStop = false;
            // 
            // ViewNotesStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 1055);
            Controls.Add(studentNameGroupBox);
            Controls.Add(notesGroupBox);
            Controls.Add(subjectsGroupBox);
            Name = "ViewNotesStudentsForm";
            Text = "ViewNotesStudents";
            subjectsGroupBox.ResumeLayout(false);
            subjectsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)subjectsDataGridView).EndInit();
            notesGroupBox.ResumeLayout(false);
            notesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)notesDataGridView).EndInit();
            studentNameGroupBox.ResumeLayout(false);
            studentNameGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox subjectsGroupBox;
        private GroupBox notesGroupBox;
        private Label subjectTittleLabel;
        private DataGridView subjectsDataGridView;
        private DataGridView notesDataGridView;
        private Label notesTittlelabel;
        private Label stundenLabel;
        private Label studentNameLabel;
        private GroupBox studentNameGroupBox;
    }
}