namespace PresentationLayer.Forms
{
    partial class ViewStudentsClassForm
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
            selectionSubjectButton = new FontAwesome.Sharp.IconButton();
            subjectLabel = new Label();
            subjectsComboBox = new ComboBox();
            classesGroupBox = new GroupBox();
            classesTittlelabel = new Label();
            clasesDataGridView = new DataGridView();
            tittleLabel = new Label();
            subjectsGroupBox.SuspendLayout();
            classesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clasesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // subjectsGroupBox
            // 
            subjectsGroupBox.Controls.Add(selectionSubjectButton);
            subjectsGroupBox.Controls.Add(subjectLabel);
            subjectsGroupBox.Controls.Add(subjectsComboBox);
            subjectsGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            subjectsGroupBox.Location = new Point(103, 151);
            subjectsGroupBox.Name = "subjectsGroupBox";
            subjectsGroupBox.Size = new Size(944, 132);
            subjectsGroupBox.TabIndex = 0;
            subjectsGroupBox.TabStop = false;
            // 
            // selectionSubjectButton
            // 
            selectionSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            selectionSubjectButton.IconColor = Color.Black;
            selectionSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            selectionSubjectButton.Location = new Point(756, 39);
            selectionSubjectButton.Name = "selectionSubjectButton";
            selectionSubjectButton.Size = new Size(121, 41);
            selectionSubjectButton.TabIndex = 15;
            selectionSubjectButton.Text = "seleccionar";
            selectionSubjectButton.UseVisualStyleBackColor = true;
            selectionSubjectButton.Click += selectionSubjectButton_Click;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new Point(17, 46);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(191, 23);
            subjectLabel.TabIndex = 1;
            subjectLabel.Text = "seleccione una materia";
            // 
            // subjectsComboBox
            // 
            subjectsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectsComboBox.FormattingEnabled = true;
            subjectsComboBox.Location = new Point(239, 46);
            subjectsComboBox.Name = "subjectsComboBox";
            subjectsComboBox.Size = new Size(484, 31);
            subjectsComboBox.TabIndex = 0;
            // 
            // classesGroupBox
            // 
            classesGroupBox.Controls.Add(classesTittlelabel);
            classesGroupBox.Controls.Add(clasesDataGridView);
            classesGroupBox.Location = new Point(46, 357);
            classesGroupBox.Name = "classesGroupBox";
            classesGroupBox.Size = new Size(1368, 438);
            classesGroupBox.TabIndex = 2;
            classesGroupBox.TabStop = false;
            // 
            // classesTittlelabel
            // 
            classesTittlelabel.AutoSize = true;
            classesTittlelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            classesTittlelabel.Location = new Point(692, 23);
            classesTittlelabel.Name = "classesTittlelabel";
            classesTittlelabel.Size = new Size(107, 28);
            classesTittlelabel.TabIndex = 9;
            classesTittlelabel.Text = "mis clases";
            // 
            // clasesDataGridView
            // 
            clasesDataGridView.AllowUserToAddRows = false;
            clasesDataGridView.AllowUserToDeleteRows = false;
            clasesDataGridView.AllowUserToResizeColumns = false;
            clasesDataGridView.AllowUserToResizeRows = false;
            clasesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clasesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            clasesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clasesDataGridView.Location = new Point(24, 64);
            clasesDataGridView.MultiSelect = false;
            clasesDataGridView.Name = "clasesDataGridView";
            clasesDataGridView.RowHeadersVisible = false;
            clasesDataGridView.RowHeadersWidth = 51;
            clasesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clasesDataGridView.Size = new Size(1274, 340);
            clasesDataGridView.TabIndex = 8;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tittleLabel.Location = new Point(547, 48);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(265, 32);
            tittleLabel.TabIndex = 3;
            tittleLabel.Text = "ver clases por materia";
            // 
            // ViewStudentsClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 1055);
            Controls.Add(tittleLabel);
            Controls.Add(classesGroupBox);
            Controls.Add(subjectsGroupBox);
            Name = "ViewStudentsClassForm";
            Text = "ViewStudentsClassForm";
            subjectsGroupBox.ResumeLayout(false);
            subjectsGroupBox.PerformLayout();
            classesGroupBox.ResumeLayout(false);
            classesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clasesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox subjectsGroupBox;
        private Label subjectLabel;
        private ComboBox subjectsComboBox;
        private FontAwesome.Sharp.IconButton selectionSubjectButton;
        private GroupBox classesGroupBox;
        private Label classesTittlelabel;
        private DataGridView clasesDataGridView;
        private Label tittleLabel;
    }
}