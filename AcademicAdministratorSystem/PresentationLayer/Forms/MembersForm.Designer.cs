namespace PresentationLayer.Forms
{
    partial class MembersForm
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
            showStudentsButton = new FontAwesome.Sharp.IconButton();
            showTeacherButton = new FontAwesome.Sharp.IconButton();
            searchButton = new FontAwesome.Sharp.IconButton();
            TitleMemberLabel = new Label();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            searchGroupBox = new GroupBox();
            membersDataGridView = new DataGridView();
            membersDatagroupBox = new GroupBox();
            editMemberButton = new FontAwesome.Sharp.IconButton();
            deleteMemberButton = new FontAwesome.Sharp.IconButton();
            editRolComboBox = new ComboBox();
            editPhoneTextBox = new TextBox();
            editEmailTextBox = new TextBox();
            editPasswordTextBox = new TextBox();
            editUserTextBox = new TextBox();
            editLastNamesTextBox = new TextBox();
            editNameTextBox = new TextBox();
            editEmailLabel = new Label();
            editPhoneLabel = new Label();
            editUserLabel = new Label();
            editRollabel = new Label();
            editPasswordLabel = new Label();
            editLastNamesLabel = new Label();
            editNameLabel = new Label();
            addMemberButton = new FontAwesome.Sharp.IconButton();
            showAdminButton = new FontAwesome.Sharp.IconButton();
            showAllButton = new FontAwesome.Sharp.IconButton();
            addMemberGroupBox = new GroupBox();
            addRolComboBox = new ComboBox();
            addPhoneTextBox = new TextBox();
            addEmailTextBox = new TextBox();
            addPasswordTextBox = new TextBox();
            addUserTextBox = new TextBox();
            addLastNameTextBox = new TextBox();
            addNameTextBox = new TextBox();
            addMailLabel = new Label();
            addRolLabel = new Label();
            addPhoneLabel = new Label();
            addUserlabel = new Label();
            addPasswordLabel = new Label();
            AddLastNameLabel = new Label();
            addNameLabel = new Label();
            membersErrorProvider = new ErrorProvider(components);
            searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membersDataGridView).BeginInit();
            membersDatagroupBox.SuspendLayout();
            addMemberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membersErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // showStudentsButton
            // 
            showStudentsButton.Font = new Font("Segoe UI", 12F);
            showStudentsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showStudentsButton.IconColor = Color.Black;
            showStudentsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showStudentsButton.Location = new Point(222, 100);
            showStudentsButton.Name = "showStudentsButton";
            showStudentsButton.Size = new Size(196, 45);
            showStudentsButton.TabIndex = 0;
            showStudentsButton.Text = "ver estudiantes";
            showStudentsButton.UseVisualStyleBackColor = true;
            showStudentsButton.Click += showStudentsButton_Click;
            // 
            // showTeacherButton
            // 
            showTeacherButton.Font = new Font("Segoe UI", 12F);
            showTeacherButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showTeacherButton.IconColor = Color.Black;
            showTeacherButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showTeacherButton.Location = new Point(486, 100);
            showTeacherButton.Name = "showTeacherButton";
            showTeacherButton.Size = new Size(220, 45);
            showTeacherButton.TabIndex = 1;
            showTeacherButton.Text = "ver docentes";
            showTeacherButton.UseVisualStyleBackColor = true;
            showTeacherButton.Click += showTeacherButton_Click;
            // 
            // searchButton
            // 
            searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchButton.IconColor = Color.Black;
            searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchButton.IconSize = 35;
            searchButton.Location = new Point(810, 26);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(85, 37);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // TitleMemberLabel
            // 
            TitleMemberLabel.AutoSize = true;
            TitleMemberLabel.Font = new Font("Segoe UI", 13F);
            TitleMemberLabel.Location = new Point(133, 162);
            TitleMemberLabel.Name = "TitleMemberLabel";
            TitleMemberLabel.Size = new Size(205, 30);
            TitleMemberLabel.TabIndex = 3;
            TitleMemberLabel.Text = "todos los miembros";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(37, 33);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(82, 30);
            searchLabel.TabIndex = 4;
            searchLabel.Text = "buscar";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(147, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(645, 36);
            searchTextBox.TabIndex = 5;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchLabel);
            searchGroupBox.Controls.Add(searchTextBox);
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            searchGroupBox.Location = new Point(228, 9);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(1048, 78);
            searchGroupBox.TabIndex = 6;
            searchGroupBox.TabStop = false;
            // 
            // membersDataGridView
            // 
            membersDataGridView.AllowUserToAddRows = false;
            membersDataGridView.AllowUserToDeleteRows = false;
            membersDataGridView.AllowUserToResizeColumns = false;
            membersDataGridView.AllowUserToResizeRows = false;
            membersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            membersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            membersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            membersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            membersDataGridView.Location = new Point(133, 207);
            membersDataGridView.MultiSelect = false;
            membersDataGridView.Name = "membersDataGridView";
            membersDataGridView.RowHeadersVisible = false;
            membersDataGridView.RowHeadersWidth = 51;
            membersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersDataGridView.Size = new Size(1358, 299);
            membersDataGridView.TabIndex = 7;
            membersDataGridView.SelectionChanged += membersDataGridView_SelectionChanged;
            // 
            // membersDatagroupBox
            // 
            membersDatagroupBox.Controls.Add(editMemberButton);
            membersDatagroupBox.Controls.Add(deleteMemberButton);
            membersDatagroupBox.Controls.Add(editRolComboBox);
            membersDatagroupBox.Controls.Add(editPhoneTextBox);
            membersDatagroupBox.Controls.Add(editEmailTextBox);
            membersDatagroupBox.Controls.Add(editPasswordTextBox);
            membersDatagroupBox.Controls.Add(editUserTextBox);
            membersDatagroupBox.Controls.Add(editLastNamesTextBox);
            membersDatagroupBox.Controls.Add(editNameTextBox);
            membersDatagroupBox.Controls.Add(editEmailLabel);
            membersDatagroupBox.Controls.Add(editPhoneLabel);
            membersDatagroupBox.Controls.Add(editUserLabel);
            membersDatagroupBox.Controls.Add(editRollabel);
            membersDatagroupBox.Controls.Add(editPasswordLabel);
            membersDatagroupBox.Controls.Add(editLastNamesLabel);
            membersDatagroupBox.Controls.Add(editNameLabel);
            membersDatagroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            membersDatagroupBox.Location = new Point(824, 525);
            membersDatagroupBox.Name = "membersDatagroupBox";
            membersDatagroupBox.Size = new Size(698, 414);
            membersDatagroupBox.TabIndex = 8;
            membersDatagroupBox.TabStop = false;
            membersDatagroupBox.Text = "editar usuario existente";
            // 
            // editMemberButton
            // 
            editMemberButton.IconChar = FontAwesome.Sharp.IconChar.None;
            editMemberButton.IconColor = Color.Black;
            editMemberButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editMemberButton.Location = new Point(526, 89);
            editMemberButton.Name = "editMemberButton";
            editMemberButton.Size = new Size(146, 51);
            editMemberButton.TabIndex = 11;
            editMemberButton.Text = "editar";
            editMemberButton.UseVisualStyleBackColor = true;
            editMemberButton.Click += editMemberButton_Click;
            // 
            // deleteMemberButton
            // 
            deleteMemberButton.IconChar = FontAwesome.Sharp.IconChar.None;
            deleteMemberButton.IconColor = Color.Black;
            deleteMemberButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteMemberButton.Location = new Point(526, 200);
            deleteMemberButton.Name = "deleteMemberButton";
            deleteMemberButton.Size = new Size(146, 51);
            deleteMemberButton.TabIndex = 10;
            deleteMemberButton.Text = "eliminar";
            deleteMemberButton.UseVisualStyleBackColor = true;
            deleteMemberButton.Click += deleteMemberButton_Click;
            // 
            // editRolComboBox
            // 
            editRolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editRolComboBox.FormattingEnabled = true;
            editRolComboBox.Location = new Point(148, 36);
            editRolComboBox.Name = "editRolComboBox";
            editRolComboBox.Size = new Size(139, 31);
            editRolComboBox.TabIndex = 14;
            // 
            // editPhoneTextBox
            // 
            editPhoneTextBox.Location = new Point(147, 340);
            editPhoneTextBox.Name = "editPhoneTextBox";
            editPhoneTextBox.Size = new Size(305, 30);
            editPhoneTextBox.TabIndex = 13;
            // 
            // editEmailTextBox
            // 
            editEmailTextBox.Location = new Point(148, 288);
            editEmailTextBox.Name = "editEmailTextBox";
            editEmailTextBox.Size = new Size(303, 30);
            editEmailTextBox.TabIndex = 12;
            // 
            // editPasswordTextBox
            // 
            editPasswordTextBox.Location = new Point(148, 237);
            editPasswordTextBox.Name = "editPasswordTextBox";
            editPasswordTextBox.Size = new Size(305, 30);
            editPasswordTextBox.TabIndex = 11;
            // 
            // editUserTextBox
            // 
            editUserTextBox.Location = new Point(148, 181);
            editUserTextBox.Name = "editUserTextBox";
            editUserTextBox.Size = new Size(303, 30);
            editUserTextBox.TabIndex = 10;
            // 
            // editLastNamesTextBox
            // 
            editLastNamesTextBox.Location = new Point(146, 133);
            editLastNamesTextBox.Name = "editLastNamesTextBox";
            editLastNamesTextBox.Size = new Size(305, 30);
            editLastNamesTextBox.TabIndex = 9;
            // 
            // editNameTextBox
            // 
            editNameTextBox.Location = new Point(146, 85);
            editNameTextBox.Name = "editNameTextBox";
            editNameTextBox.Size = new Size(305, 30);
            editNameTextBox.TabIndex = 8;
            // 
            // editEmailLabel
            // 
            editEmailLabel.AutoSize = true;
            editEmailLabel.Location = new Point(29, 295);
            editEmailLabel.Name = "editEmailLabel";
            editEmailLabel.Size = new Size(50, 23);
            editEmailLabel.TabIndex = 7;
            editEmailLabel.Text = "mail:";
            // 
            // editPhoneLabel
            // 
            editPhoneLabel.AutoSize = true;
            editPhoneLabel.Location = new Point(28, 343);
            editPhoneLabel.Name = "editPhoneLabel";
            editPhoneLabel.Size = new Size(87, 23);
            editPhoneLabel.TabIndex = 4;
            editPhoneLabel.Text = "telefono :";
            // 
            // editUserLabel
            // 
            editUserLabel.AutoSize = true;
            editUserLabel.Location = new Point(29, 188);
            editUserLabel.Name = "editUserLabel";
            editUserLabel.Size = new Size(78, 23);
            editUserLabel.TabIndex = 3;
            editUserLabel.Text = "usuario :";
            // 
            // editRollabel
            // 
            editRollabel.AutoSize = true;
            editRollabel.Location = new Point(29, 44);
            editRollabel.Name = "editRollabel";
            editRollabel.Size = new Size(42, 23);
            editRollabel.TabIndex = 6;
            editRollabel.Text = "rol :";
            // 
            // editPasswordLabel
            // 
            editPasswordLabel.AutoSize = true;
            editPasswordLabel.Location = new Point(29, 240);
            editPasswordLabel.Name = "editPasswordLabel";
            editPasswordLabel.Size = new Size(106, 23);
            editPasswordLabel.TabIndex = 2;
            editPasswordLabel.Text = "contraseña :";
            // 
            // editLastNamesLabel
            // 
            editLastNamesLabel.AutoSize = true;
            editLastNamesLabel.Location = new Point(29, 133);
            editLastNamesLabel.Name = "editLastNamesLabel";
            editLastNamesLabel.Size = new Size(92, 23);
            editLastNamesLabel.TabIndex = 1;
            editLastNamesLabel.Text = "apellidos :";
            // 
            // editNameLabel
            // 
            editNameLabel.AutoSize = true;
            editNameLabel.Location = new Point(25, 85);
            editNameLabel.Name = "editNameLabel";
            editNameLabel.Size = new Size(90, 23);
            editNameLabel.TabIndex = 0;
            editNameLabel.Text = "nombres :";
            // 
            // addMemberButton
            // 
            addMemberButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addMemberButton.IconColor = Color.Black;
            addMemberButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addMemberButton.Location = new Point(475, 158);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(146, 51);
            addMemberButton.TabIndex = 9;
            addMemberButton.Text = "agregar";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // showAdminButton
            // 
            showAdminButton.Font = new Font("Segoe UI", 12F);
            showAdminButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showAdminButton.IconColor = Color.Black;
            showAdminButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAdminButton.Location = new Point(773, 100);
            showAdminButton.Name = "showAdminButton";
            showAdminButton.Size = new Size(220, 45);
            showAdminButton.TabIndex = 16;
            showAdminButton.Text = "ver administradores";
            showAdminButton.UseVisualStyleBackColor = true;
            showAdminButton.Click += showAdminButton_Click;
            // 
            // showAllButton
            // 
            showAllButton.Font = new Font("Segoe UI", 12F);
            showAllButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showAllButton.IconColor = Color.Black;
            showAllButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAllButton.Location = new Point(1050, 100);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(220, 45);
            showAllButton.TabIndex = 17;
            showAllButton.Text = "ver todo";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // addMemberGroupBox
            // 
            addMemberGroupBox.Controls.Add(addRolComboBox);
            addMemberGroupBox.Controls.Add(addPhoneTextBox);
            addMemberGroupBox.Controls.Add(addMemberButton);
            addMemberGroupBox.Controls.Add(addEmailTextBox);
            addMemberGroupBox.Controls.Add(addPasswordTextBox);
            addMemberGroupBox.Controls.Add(addUserTextBox);
            addMemberGroupBox.Controls.Add(addLastNameTextBox);
            addMemberGroupBox.Controls.Add(addNameTextBox);
            addMemberGroupBox.Controls.Add(addMailLabel);
            addMemberGroupBox.Controls.Add(addRolLabel);
            addMemberGroupBox.Controls.Add(addPhoneLabel);
            addMemberGroupBox.Controls.Add(addUserlabel);
            addMemberGroupBox.Controls.Add(addPasswordLabel);
            addMemberGroupBox.Controls.Add(AddLastNameLabel);
            addMemberGroupBox.Controls.Add(addNameLabel);
            addMemberGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addMemberGroupBox.Location = new Point(74, 525);
            addMemberGroupBox.Name = "addMemberGroupBox";
            addMemberGroupBox.Size = new Size(688, 414);
            addMemberGroupBox.TabIndex = 18;
            addMemberGroupBox.TabStop = false;
            addMemberGroupBox.Text = "nuevo usuario";
            // 
            // addRolComboBox
            // 
            addRolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addRolComboBox.FormattingEnabled = true;
            addRolComboBox.Location = new Point(148, 49);
            addRolComboBox.Name = "addRolComboBox";
            addRolComboBox.Size = new Size(153, 31);
            addRolComboBox.TabIndex = 14;
            // 
            // addPhoneTextBox
            // 
            addPhoneTextBox.Location = new Point(147, 342);
            addPhoneTextBox.Name = "addPhoneTextBox";
            addPhoneTextBox.Size = new Size(251, 30);
            addPhoneTextBox.TabIndex = 13;
            // 
            // addEmailTextBox
            // 
            addEmailTextBox.Location = new Point(146, 296);
            addEmailTextBox.Name = "addEmailTextBox";
            addEmailTextBox.Size = new Size(249, 30);
            addEmailTextBox.TabIndex = 12;
            // 
            // addPasswordTextBox
            // 
            addPasswordTextBox.Location = new Point(148, 248);
            addPasswordTextBox.Name = "addPasswordTextBox";
            addPasswordTextBox.Size = new Size(251, 30);
            addPasswordTextBox.TabIndex = 11;
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(148, 194);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(249, 30);
            addUserTextBox.TabIndex = 10;
            // 
            // addLastNameTextBox
            // 
            addLastNameTextBox.Location = new Point(142, 146);
            addLastNameTextBox.Name = "addLastNameTextBox";
            addLastNameTextBox.Size = new Size(257, 30);
            addLastNameTextBox.TabIndex = 9;
            // 
            // addNameTextBox
            // 
            addNameTextBox.Location = new Point(146, 96);
            addNameTextBox.Name = "addNameTextBox";
            addNameTextBox.Size = new Size(251, 30);
            addNameTextBox.TabIndex = 8;
            // 
            // addMailLabel
            // 
            addMailLabel.AutoSize = true;
            addMailLabel.Location = new Point(28, 296);
            addMailLabel.Name = "addMailLabel";
            addMailLabel.Size = new Size(50, 23);
            addMailLabel.TabIndex = 7;
            addMailLabel.Text = "mail:";
            // 
            // addRolLabel
            // 
            addRolLabel.AutoSize = true;
            addRolLabel.Location = new Point(36, 52);
            addRolLabel.Name = "addRolLabel";
            addRolLabel.Size = new Size(42, 23);
            addRolLabel.TabIndex = 6;
            addRolLabel.Text = "rol :";
            // 
            // addPhoneLabel
            // 
            addPhoneLabel.AutoSize = true;
            addPhoneLabel.Location = new Point(25, 348);
            addPhoneLabel.Name = "addPhoneLabel";
            addPhoneLabel.Size = new Size(87, 23);
            addPhoneLabel.TabIndex = 4;
            addPhoneLabel.Text = "telefono :";
            // 
            // addUserlabel
            // 
            addUserlabel.AutoSize = true;
            addUserlabel.Location = new Point(25, 201);
            addUserlabel.Name = "addUserlabel";
            addUserlabel.Size = new Size(78, 23);
            addUserlabel.TabIndex = 3;
            addUserlabel.Text = "usuario :";
            // 
            // addPasswordLabel
            // 
            addPasswordLabel.AutoSize = true;
            addPasswordLabel.Location = new Point(25, 251);
            addPasswordLabel.Name = "addPasswordLabel";
            addPasswordLabel.Size = new Size(106, 23);
            addPasswordLabel.TabIndex = 2;
            addPasswordLabel.Text = "contraseña :";
            // 
            // AddLastNameLabel
            // 
            AddLastNameLabel.AutoSize = true;
            AddLastNameLabel.Location = new Point(25, 146);
            AddLastNameLabel.Name = "AddLastNameLabel";
            AddLastNameLabel.Size = new Size(92, 23);
            AddLastNameLabel.TabIndex = 1;
            AddLastNameLabel.Text = "apellidos :";
            // 
            // addNameLabel
            // 
            addNameLabel.AutoSize = true;
            addNameLabel.Location = new Point(25, 96);
            addNameLabel.Name = "addNameLabel";
            addNameLabel.Size = new Size(90, 23);
            addNameLabel.TabIndex = 0;
            addNameLabel.Text = "nombres :";
            // 
            // membersErrorProvider
            // 
            membersErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            membersErrorProvider.ContainerControl = this;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 1055);
            Controls.Add(addMemberGroupBox);
            Controls.Add(showAllButton);
            Controls.Add(showAdminButton);
            Controls.Add(membersDatagroupBox);
            Controls.Add(membersDataGridView);
            Controls.Add(searchGroupBox);
            Controls.Add(TitleMemberLabel);
            Controls.Add(showTeacherButton);
            Controls.Add(showStudentsButton);
            Name = "MembersForm";
            Text = "AddMemberForm";
            WindowState = FormWindowState.Maximized;
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)membersDataGridView).EndInit();
            membersDatagroupBox.ResumeLayout(false);
            membersDatagroupBox.PerformLayout();
            addMemberGroupBox.ResumeLayout(false);
            addMemberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)membersErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton showStudentsButton;
        private FontAwesome.Sharp.IconButton showTeacherButton;
        private FontAwesome.Sharp.IconButton searchButton;
        private Label TitleMemberLabel;
        private Label searchLabel;
        private TextBox searchTextBox;
        private GroupBox searchGroupBox;
        private DataGridView membersDataGridView;
        private GroupBox membersDatagroupBox;
        private Label editNameLabel;
        private TextBox editEmailTextBox;
        private TextBox editPasswordTextBox;
        private TextBox editUserTextBox;
        private TextBox editLastNamesTextBox;
        private TextBox editNameTextBox;
        private Label editEmailLabel;
        private Label editRollabel;
        private Label editPhoneLabel;
        private Label editUserLabel;
        private Label editPasswordLabel;
        private Label editLastNamesLabel;
        private TextBox editPhoneTextBox;
        private FontAwesome.Sharp.IconButton addMemberButton;
        private FontAwesome.Sharp.IconButton deleteMemberButton;
        private FontAwesome.Sharp.IconButton editMemberButton;
        private ComboBox editRolComboBox;
        private FontAwesome.Sharp.IconButton showAdminButton;
        private FontAwesome.Sharp.IconButton showAllButton;
        private GroupBox addMemberGroupBox;
        private ComboBox addRolComboBox;
        private TextBox addPhoneTextBox;
        private TextBox addEmailTextBox;
        private TextBox addPasswordTextBox;
        private TextBox addUserTextBox;
        private TextBox addLastNameTextBox;
        private TextBox addNameTextBox;
        private Label addMailLabel;
        private Label addRolLabel;
        private Label addPhoneLabel;
        private Label addUserlabel;
        private Label addPasswordLabel;
        private Label AddLastNameLabel;
        private Label addNameLabel;
        private ErrorProvider membersErrorProvider;
    }
}