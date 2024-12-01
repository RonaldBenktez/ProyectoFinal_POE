namespace PresentationLayer.Forms
{
    partial class GradesAndSectionsForm
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
            gradesGroupBox = new GroupBox();
            editGradeGroupBox = new GroupBox();
            editGradeButton = new FontAwesome.Sharp.IconButton();
            editNameGradetextBox = new TextBox();
            editGradeLabel = new Label();
            addGradeGroupBox = new GroupBox();
            addGradeButton = new FontAwesome.Sharp.IconButton();
            addGradeNameTextBox = new TextBox();
            addGradeNameLabel = new Label();
            gradesDataGridView = new DataGridView();
            sectionsGroupBox = new GroupBox();
            editSectiongroupBox = new GroupBox();
            editSectionGradecomboBox = new ComboBox();
            editSectionNameLabel = new Label();
            editSectionButton = new FontAwesome.Sharp.IconButton();
            editSectionNameTextBox = new TextBox();
            editaGradesectionlabel = new Label();
            addSectiongroupBox = new GroupBox();
            addSectionGradeComboBox = new ComboBox();
            addSectionlabel = new Label();
            addSectionButton = new FontAwesome.Sharp.IconButton();
            addSectionNametextBox = new TextBox();
            addSectionNamelabel = new Label();
            sectionsDataGridView = new DataGridView();
            sectionErrorProvider = new ErrorProvider(components);
            gradesGroupBox.SuspendLayout();
            editGradeGroupBox.SuspendLayout();
            addGradeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).BeginInit();
            sectionsGroupBox.SuspendLayout();
            editSectiongroupBox.SuspendLayout();
            addSectiongroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sectionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sectionErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // gradesGroupBox
            // 
            gradesGroupBox.Controls.Add(editGradeGroupBox);
            gradesGroupBox.Controls.Add(addGradeGroupBox);
            gradesGroupBox.Controls.Add(gradesDataGridView);
            gradesGroupBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gradesGroupBox.Location = new Point(29, 23);
            gradesGroupBox.Name = "gradesGroupBox";
            gradesGroupBox.Size = new Size(1651, 431);
            gradesGroupBox.TabIndex = 0;
            gradesGroupBox.TabStop = false;
            gradesGroupBox.Text = "grados";
            // 
            // editGradeGroupBox
            // 
            editGradeGroupBox.Controls.Add(editGradeButton);
            editGradeGroupBox.Controls.Add(editNameGradetextBox);
            editGradeGroupBox.Controls.Add(editGradeLabel);
            editGradeGroupBox.Location = new Point(18, 222);
            editGradeGroupBox.Name = "editGradeGroupBox";
            editGradeGroupBox.Size = new Size(680, 98);
            editGradeGroupBox.TabIndex = 5;
            editGradeGroupBox.TabStop = false;
            editGradeGroupBox.Text = "editar grado";
            // 
            // editGradeButton
            // 
            editGradeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            editGradeButton.IconColor = Color.Black;
            editGradeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editGradeButton.Location = new Point(467, 37);
            editGradeButton.Name = "editGradeButton";
            editGradeButton.Size = new Size(160, 29);
            editGradeButton.TabIndex = 3;
            editGradeButton.Text = "editar";
            editGradeButton.UseVisualStyleBackColor = true;
            editGradeButton.Click += editGradeButton_Click;
            // 
            // editNameGradetextBox
            // 
            editNameGradetextBox.Font = new Font("Segoe UI", 10F);
            editNameGradetextBox.Location = new Point(180, 40);
            editNameGradetextBox.Name = "editNameGradetextBox";
            editNameGradetextBox.Size = new Size(208, 30);
            editNameGradetextBox.TabIndex = 2;
            editNameGradetextBox.TextChanged += editNameGradetextBox_TextChanged;
            // 
            // editGradeLabel
            // 
            editGradeLabel.AutoSize = true;
            editGradeLabel.Font = new Font("Segoe UI", 10F);
            editGradeLabel.Location = new Point(12, 44);
            editGradeLabel.Name = "editGradeLabel";
            editGradeLabel.Size = new Size(144, 23);
            editGradeLabel.TabIndex = 1;
            editGradeLabel.Text = "nombre de grado";
            // 
            // addGradeGroupBox
            // 
            addGradeGroupBox.Controls.Add(addGradeButton);
            addGradeGroupBox.Controls.Add(addGradeNameTextBox);
            addGradeGroupBox.Controls.Add(addGradeNameLabel);
            addGradeGroupBox.Location = new Point(12, 53);
            addGradeGroupBox.Name = "addGradeGroupBox";
            addGradeGroupBox.Size = new Size(686, 98);
            addGradeGroupBox.TabIndex = 4;
            addGradeGroupBox.TabStop = false;
            addGradeGroupBox.Text = "añadir grado";
            // 
            // addGradeButton
            // 
            addGradeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addGradeButton.IconColor = Color.Black;
            addGradeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addGradeButton.Location = new Point(467, 42);
            addGradeButton.Name = "addGradeButton";
            addGradeButton.Size = new Size(141, 29);
            addGradeButton.TabIndex = 3;
            addGradeButton.Text = "añadir";
            addGradeButton.UseVisualStyleBackColor = true;
            addGradeButton.Click += addGradeButton_Click;
            // 
            // addGradeNameTextBox
            // 
            addGradeNameTextBox.Font = new Font("Segoe UI", 10F);
            addGradeNameTextBox.Location = new Point(186, 35);
            addGradeNameTextBox.Name = "addGradeNameTextBox";
            addGradeNameTextBox.Size = new Size(208, 30);
            addGradeNameTextBox.TabIndex = 2;
            addGradeNameTextBox.TextChanged += addGradeNameTextBox_TextChanged;
            // 
            // addGradeNameLabel
            // 
            addGradeNameLabel.AutoSize = true;
            addGradeNameLabel.Font = new Font("Segoe UI", 10F);
            addGradeNameLabel.Location = new Point(18, 42);
            addGradeNameLabel.Name = "addGradeNameLabel";
            addGradeNameLabel.Size = new Size(144, 23);
            addGradeNameLabel.TabIndex = 1;
            addGradeNameLabel.Text = "nombre de grado";
            // 
            // gradesDataGridView
            // 
            gradesDataGridView.AllowUserToAddRows = false;
            gradesDataGridView.AllowUserToDeleteRows = false;
            gradesDataGridView.AllowUserToResizeColumns = false;
            gradesDataGridView.AllowUserToResizeRows = false;
            gradesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gradesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gradesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesDataGridView.Location = new Point(793, 44);
            gradesDataGridView.MultiSelect = false;
            gradesDataGridView.Name = "gradesDataGridView";
            gradesDataGridView.ReadOnly = true;
            gradesDataGridView.RowHeadersVisible = false;
            gradesDataGridView.RowHeadersWidth = 51;
            gradesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gradesDataGridView.Size = new Size(467, 362);
            gradesDataGridView.TabIndex = 0;
            gradesDataGridView.SelectionChanged += gradesDataGridView_SelectionChanged_1;
            // 
            // sectionsGroupBox
            // 
            sectionsGroupBox.Controls.Add(editSectiongroupBox);
            sectionsGroupBox.Controls.Add(addSectiongroupBox);
            sectionsGroupBox.Controls.Add(sectionsDataGridView);
            sectionsGroupBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sectionsGroupBox.Location = new Point(29, 485);
            sectionsGroupBox.Name = "sectionsGroupBox";
            sectionsGroupBox.Size = new Size(1651, 480);
            sectionsGroupBox.TabIndex = 1;
            sectionsGroupBox.TabStop = false;
            sectionsGroupBox.Text = "secciones";
            // 
            // editSectiongroupBox
            // 
            editSectiongroupBox.Controls.Add(editSectionGradecomboBox);
            editSectiongroupBox.Controls.Add(editSectionNameLabel);
            editSectiongroupBox.Controls.Add(editSectionButton);
            editSectiongroupBox.Controls.Add(editSectionNameTextBox);
            editSectiongroupBox.Controls.Add(editaGradesectionlabel);
            editSectiongroupBox.Location = new Point(12, 248);
            editSectiongroupBox.Name = "editSectiongroupBox";
            editSectiongroupBox.Size = new Size(686, 169);
            editSectiongroupBox.TabIndex = 5;
            editSectiongroupBox.TabStop = false;
            editSectiongroupBox.Text = "editar seccion";
            // 
            // editSectionGradecomboBox
            // 
            editSectionGradecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editSectionGradecomboBox.Font = new Font("Segoe UI", 10F);
            editSectionGradecomboBox.FormattingEnabled = true;
            editSectionGradecomboBox.Location = new Point(192, 46);
            editSectionGradecomboBox.Name = "editSectionGradecomboBox";
            editSectionGradecomboBox.Size = new Size(151, 31);
            editSectionGradecomboBox.TabIndex = 7;
            // 
            // editSectionNameLabel
            // 
            editSectionNameLabel.AutoSize = true;
            editSectionNameLabel.Font = new Font("Segoe UI", 10F);
            editSectionNameLabel.Location = new Point(47, 113);
            editSectionNameLabel.Name = "editSectionNameLabel";
            editSectionNameLabel.Size = new Size(66, 23);
            editSectionNameLabel.TabIndex = 6;
            editSectionNameLabel.Text = "seccion";
            // 
            // editSectionButton
            // 
            editSectionButton.IconChar = FontAwesome.Sharp.IconChar.None;
            editSectionButton.IconColor = Color.Black;
            editSectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editSectionButton.Location = new Point(467, 84);
            editSectionButton.Name = "editSectionButton";
            editSectionButton.Size = new Size(160, 29);
            editSectionButton.TabIndex = 3;
            editSectionButton.Text = "editar";
            editSectionButton.UseVisualStyleBackColor = true;
            editSectionButton.Click += editSectionButton_Click;
            // 
            // editSectionNameTextBox
            // 
            editSectionNameTextBox.Font = new Font("Segoe UI", 10F);
            editSectionNameTextBox.Location = new Point(198, 106);
            editSectionNameTextBox.Name = "editSectionNameTextBox";
            editSectionNameTextBox.Size = new Size(145, 30);
            editSectionNameTextBox.TabIndex = 2;
            editSectionNameTextBox.TextChanged += editSectionNameTextBox_TextChanged;
            // 
            // editaGradesectionlabel
            // 
            editaGradesectionlabel.AutoSize = true;
            editaGradesectionlabel.Font = new Font("Segoe UI", 10F);
            editaGradesectionlabel.Location = new Point(47, 46);
            editaGradesectionlabel.Name = "editaGradesectionlabel";
            editaGradesectionlabel.Size = new Size(55, 23);
            editaGradesectionlabel.TabIndex = 1;
            editaGradesectionlabel.Text = "grado";
            // 
            // addSectiongroupBox
            // 
            addSectiongroupBox.Controls.Add(addSectionGradeComboBox);
            addSectiongroupBox.Controls.Add(addSectionlabel);
            addSectiongroupBox.Controls.Add(addSectionButton);
            addSectiongroupBox.Controls.Add(addSectionNametextBox);
            addSectiongroupBox.Controls.Add(addSectionNamelabel);
            addSectiongroupBox.Location = new Point(12, 46);
            addSectiongroupBox.Name = "addSectiongroupBox";
            addSectiongroupBox.Size = new Size(686, 170);
            addSectiongroupBox.TabIndex = 4;
            addSectiongroupBox.TabStop = false;
            addSectiongroupBox.Text = "añadir seccion";
            // 
            // addSectionGradeComboBox
            // 
            addSectionGradeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addSectionGradeComboBox.Font = new Font("Segoe UI", 10F);
            addSectionGradeComboBox.FormattingEnabled = true;
            addSectionGradeComboBox.Location = new Point(166, 36);
            addSectionGradeComboBox.Name = "addSectionGradeComboBox";
            addSectionGradeComboBox.Size = new Size(185, 31);
            addSectionGradeComboBox.TabIndex = 5;
            // 
            // addSectionlabel
            // 
            addSectionlabel.AutoSize = true;
            addSectionlabel.Font = new Font("Segoe UI", 10F);
            addSectionlabel.Location = new Point(47, 36);
            addSectionlabel.Name = "addSectionlabel";
            addSectionlabel.Size = new Size(55, 23);
            addSectionlabel.TabIndex = 4;
            addSectionlabel.Text = "grado";
            // 
            // addSectionButton
            // 
            addSectionButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addSectionButton.IconColor = Color.Black;
            addSectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addSectionButton.Location = new Point(467, 75);
            addSectionButton.Name = "addSectionButton";
            addSectionButton.Size = new Size(141, 29);
            addSectionButton.TabIndex = 3;
            addSectionButton.Text = "añadir";
            addSectionButton.UseVisualStyleBackColor = true;
            addSectionButton.Click += addSectionButton_Click;
            // 
            // addSectionNametextBox
            // 
            addSectionNametextBox.Font = new Font("Segoe UI", 10F);
            addSectionNametextBox.Location = new Point(166, 116);
            addSectionNametextBox.Name = "addSectionNametextBox";
            addSectionNametextBox.Size = new Size(185, 30);
            addSectionNametextBox.TabIndex = 2;
            addSectionNametextBox.TextChanged += addSectionNametextBox_TextChanged;
            // 
            // addSectionNamelabel
            // 
            addSectionNamelabel.AutoSize = true;
            addSectionNamelabel.Font = new Font("Segoe UI", 10F);
            addSectionNamelabel.Location = new Point(47, 116);
            addSectionNamelabel.Name = "addSectionNamelabel";
            addSectionNamelabel.Size = new Size(66, 23);
            addSectionNamelabel.TabIndex = 1;
            addSectionNamelabel.Text = "seccion";
            // 
            // sectionsDataGridView
            // 
            sectionsDataGridView.AllowUserToAddRows = false;
            sectionsDataGridView.AllowUserToDeleteRows = false;
            sectionsDataGridView.AllowUserToResizeColumns = false;
            sectionsDataGridView.AllowUserToResizeRows = false;
            sectionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sectionsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sectionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sectionsDataGridView.Location = new Point(813, 41);
            sectionsDataGridView.MultiSelect = false;
            sectionsDataGridView.Name = "sectionsDataGridView";
            sectionsDataGridView.RowHeadersVisible = false;
            sectionsDataGridView.RowHeadersWidth = 51;
            sectionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sectionsDataGridView.Size = new Size(675, 400);
            sectionsDataGridView.TabIndex = 0;
            sectionsDataGridView.SelectionChanged += sectionsDataGridView_SelectionChanged;
            // 
            // sectionErrorProvider
            // 
            sectionErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            sectionErrorProvider.ContainerControl = this;
            // 
            // GradesAndSectionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(sectionsGroupBox);
            Controls.Add(gradesGroupBox);
            Name = "GradesAndSectionsForm";
            gradesGroupBox.ResumeLayout(false);
            editGradeGroupBox.ResumeLayout(false);
            editGradeGroupBox.PerformLayout();
            addGradeGroupBox.ResumeLayout(false);
            addGradeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).EndInit();
            sectionsGroupBox.ResumeLayout(false);
            editSectiongroupBox.ResumeLayout(false);
            editSectiongroupBox.PerformLayout();
            addSectiongroupBox.ResumeLayout(false);
            addSectiongroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sectionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)sectionErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gradesGroupBox;
        private TextBox addGradeNameTextBox;
        private Label addGradeNameLabel;
        private DataGridView gradesDataGridView;
        private GroupBox editGradeGroupBox;
        private FontAwesome.Sharp.IconButton editGradeButton;
        private TextBox editNameGradetextBox;
        private Label editGradeLabel;
        private GroupBox addGradeGroupBox;
        private FontAwesome.Sharp.IconButton addGradeButton;
        private GroupBox sectionsGroupBox;
        private GroupBox editSectiongroupBox;
        private FontAwesome.Sharp.IconButton editSectionButton;
        private TextBox editSectionNameTextBox;
        private Label editaGradesectionlabel;
        private GroupBox addSectiongroupBox;
        private ComboBox addSectionGradeComboBox;
        private Label addSectionlabel;
        private FontAwesome.Sharp.IconButton addSectionButton;
        private TextBox addSectionNametextBox;
        private Label addSectionNamelabel;
        private DataGridView sectionsDataGridView;
        private ComboBox editSectionGradecomboBox;
        private Label editSectionNameLabel;
        private ErrorProvider sectionErrorProvider;
    }
}