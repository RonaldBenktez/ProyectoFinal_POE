namespace PresentationLayer.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            optionsPanel = new Panel();
            optionsLayoutPanel = new FlowLayoutPanel();
            showMembersButton = new FontAwesome.Sharp.IconButton();
            gradesAndSectionsButton = new FontAwesome.Sharp.IconButton();
            addSubjectsButton = new FontAwesome.Sharp.IconButton();
            enrollStudentsButton = new FontAwesome.Sharp.IconButton();
            addNotesButton = new FontAwesome.Sharp.IconButton();
            showSubjectsAndStudentsButton = new FontAwesome.Sharp.IconButton();
            showStudentsSubjectButton = new FontAwesome.Sharp.IconButton();
            showStudentClassButton = new FontAwesome.Sharp.IconButton();
            logoPictureBox = new PictureBox();
            tittleOptionsLabel = new Label();
            contentPanel = new Panel();
            optionsPanel.SuspendLayout();
            optionsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // optionsPanel
            // 
            optionsPanel.BackColor = SystemColors.AppWorkspace;
            optionsPanel.Controls.Add(optionsLayoutPanel);
            optionsPanel.Controls.Add(logoPictureBox);
            optionsPanel.Controls.Add(tittleOptionsLabel);
            optionsPanel.Dock = DockStyle.Left;
            optionsPanel.Location = new Point(0, 0);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(250, 992);
            optionsPanel.TabIndex = 0;
            // 
            // optionsLayoutPanel
            // 
            optionsLayoutPanel.Controls.Add(showMembersButton);
            optionsLayoutPanel.Controls.Add(gradesAndSectionsButton);
            optionsLayoutPanel.Controls.Add(addSubjectsButton);
            optionsLayoutPanel.Controls.Add(enrollStudentsButton);
            optionsLayoutPanel.Controls.Add(addNotesButton);
            optionsLayoutPanel.Controls.Add(showSubjectsAndStudentsButton);
            optionsLayoutPanel.Controls.Add(showStudentsSubjectButton);
            optionsLayoutPanel.Controls.Add(showStudentClassButton);
            optionsLayoutPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            optionsLayoutPanel.Location = new Point(3, 298);
            optionsLayoutPanel.Name = "optionsLayoutPanel";
            optionsLayoutPanel.Size = new Size(238, 601);
            optionsLayoutPanel.TabIndex = 24;
            // 
            // showMembersButton
            // 
            showMembersButton.BackColor = SystemColors.GradientActiveCaption;
            showMembersButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showMembersButton.IconColor = Color.Black;
            showMembersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showMembersButton.Location = new Point(5, 10);
            showMembersButton.Margin = new Padding(5, 10, 5, 10);
            showMembersButton.Name = "showMembersButton";
            showMembersButton.Size = new Size(222, 36);
            showMembersButton.TabIndex = 24;
            showMembersButton.Text = "agregar miembros";
            showMembersButton.UseVisualStyleBackColor = false;
            showMembersButton.Click += showMembersButton_Click;
            // 
            // gradesAndSectionsButton
            // 
            gradesAndSectionsButton.BackColor = SystemColors.GradientActiveCaption;
            gradesAndSectionsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            gradesAndSectionsButton.IconColor = Color.Black;
            gradesAndSectionsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            gradesAndSectionsButton.Location = new Point(5, 66);
            gradesAndSectionsButton.Margin = new Padding(5, 10, 5, 10);
            gradesAndSectionsButton.Name = "gradesAndSectionsButton";
            gradesAndSectionsButton.Size = new Size(222, 36);
            gradesAndSectionsButton.TabIndex = 26;
            gradesAndSectionsButton.Text = "ver secciones";
            gradesAndSectionsButton.UseVisualStyleBackColor = false;
            gradesAndSectionsButton.Click += gradesAndSectionsButton_Click;
            // 
            // addSubjectsButton
            // 
            addSubjectsButton.BackColor = SystemColors.GradientActiveCaption;
            addSubjectsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addSubjectsButton.IconColor = Color.Black;
            addSubjectsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addSubjectsButton.Location = new Point(5, 122);
            addSubjectsButton.Margin = new Padding(5, 10, 5, 10);
            addSubjectsButton.Name = "addSubjectsButton";
            addSubjectsButton.Size = new Size(222, 36);
            addSubjectsButton.TabIndex = 25;
            addSubjectsButton.Text = "Agregar Materias";
            addSubjectsButton.UseVisualStyleBackColor = false;
            addSubjectsButton.Click += addSubjectsButton_Click_1;
            // 
            // enrollStudentsButton
            // 
            enrollStudentsButton.BackColor = SystemColors.GradientActiveCaption;
            enrollStudentsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            enrollStudentsButton.IconColor = Color.Black;
            enrollStudentsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            enrollStudentsButton.Location = new Point(5, 178);
            enrollStudentsButton.Margin = new Padding(5, 10, 5, 10);
            enrollStudentsButton.Name = "enrollStudentsButton";
            enrollStudentsButton.Size = new Size(222, 36);
            enrollStudentsButton.TabIndex = 35;
            enrollStudentsButton.Text = "añadir materia a estudiante";
            enrollStudentsButton.UseVisualStyleBackColor = false;
            enrollStudentsButton.Click += enrollStudentsButton_Click;
            // 
            // addNotesButton
            // 
            addNotesButton.BackColor = SystemColors.GradientActiveCaption;
            addNotesButton.IconChar = FontAwesome.Sharp.IconChar.None;
            addNotesButton.IconColor = Color.Black;
            addNotesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addNotesButton.Location = new Point(5, 234);
            addNotesButton.Margin = new Padding(5, 10, 5, 10);
            addNotesButton.Name = "addNotesButton";
            addNotesButton.Size = new Size(222, 36);
            addNotesButton.TabIndex = 28;
            addNotesButton.Text = "agregar notas";
            addNotesButton.UseVisualStyleBackColor = false;
            addNotesButton.Click += addNotesButton_Click;
            // 
            // showSubjectsAndStudentsButton
            // 
            showSubjectsAndStudentsButton.BackColor = SystemColors.GradientActiveCaption;
            showSubjectsAndStudentsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showSubjectsAndStudentsButton.IconColor = Color.Black;
            showSubjectsAndStudentsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showSubjectsAndStudentsButton.Location = new Point(5, 290);
            showSubjectsAndStudentsButton.Margin = new Padding(5, 10, 5, 10);
            showSubjectsAndStudentsButton.Name = "showSubjectsAndStudentsButton";
            showSubjectsAndStudentsButton.Size = new Size(222, 36);
            showSubjectsAndStudentsButton.TabIndex = 30;
            showSubjectsAndStudentsButton.Text = "ver mis clases y alumnos";
            showSubjectsAndStudentsButton.UseVisualStyleBackColor = false;
            showSubjectsAndStudentsButton.Click += showSubjectsAndStudentsButton_Click;
            // 
            // showStudentsSubjectButton
            // 
            showStudentsSubjectButton.BackColor = SystemColors.GradientActiveCaption;
            showStudentsSubjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showStudentsSubjectButton.IconColor = Color.Black;
            showStudentsSubjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showStudentsSubjectButton.Location = new Point(5, 346);
            showStudentsSubjectButton.Margin = new Padding(5, 10, 5, 10);
            showStudentsSubjectButton.Name = "showStudentsSubjectButton";
            showStudentsSubjectButton.Size = new Size(222, 36);
            showStudentsSubjectButton.TabIndex = 32;
            showStudentsSubjectButton.Text = "ver mis materias y notas";
            showStudentsSubjectButton.UseVisualStyleBackColor = false;
            showStudentsSubjectButton.Click += showStudentsSubjectButton_Click;
            // 
            // showStudentClassButton
            // 
            showStudentClassButton.BackColor = SystemColors.GradientActiveCaption;
            showStudentClassButton.IconChar = FontAwesome.Sharp.IconChar.None;
            showStudentClassButton.IconColor = Color.Black;
            showStudentClassButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showStudentClassButton.Location = new Point(5, 402);
            showStudentClassButton.Margin = new Padding(5, 10, 5, 10);
            showStudentClassButton.Name = "showStudentClassButton";
            showStudentClassButton.Size = new Size(222, 36);
            showStudentClassButton.TabIndex = 33;
            showStudentClassButton.Text = "ver mis clases";
            showStudentClassButton.UseVisualStyleBackColor = false;
            showStudentClassButton.Click += showStudentClassButton_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.DimGray;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(12, 12);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(229, 213);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 22;
            logoPictureBox.TabStop = false;
            // 
            // tittleOptionsLabel
            // 
            tittleOptionsLabel.BorderStyle = BorderStyle.FixedSingle;
            tittleOptionsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tittleOptionsLabel.ForeColor = SystemColors.ActiveCaptionText;
            tittleOptionsLabel.Location = new Point(12, 228);
            tittleOptionsLabel.Name = "tittleOptionsLabel";
            tittleOptionsLabel.Size = new Size(222, 45);
            tittleOptionsLabel.TabIndex = 23;
            tittleOptionsLabel.Text = "Opciones";
            tittleOptionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = SystemColors.ActiveCaption;
            contentPanel.Location = new Point(256, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1668, 992);
            contentPanel.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1924, 992);
            Controls.Add(contentPanel);
            Controls.Add(optionsPanel);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = FormWindowState.Maximized;
            optionsPanel.ResumeLayout(false);
            optionsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton showStudentClassButton;
        private FontAwesome.Sharp.IconButton ShowStudentsButton;
        private Panel optionsPanel;
        private PictureBox logoPictureBox;
        private Label tittleOptionsLabel;
        private FontAwesome.Sharp.IconButton addSubjectsButton;
        private FontAwesome.Sharp.IconButton showSubjectsAndStudentsButton;
        private FontAwesome.Sharp.IconButton gradesAndSectionsButton;
        private FontAwesome.Sharp.IconButton addNotesButton;
        private FontAwesome.Sharp.IconButton showMembersButton;
        private Panel contentPanel;
        private FlowLayoutPanel optionsLayoutPanel;
        private FontAwesome.Sharp.IconButton showStudentsSubjectButton;
        private FontAwesome.Sharp.IconButton enrollStudentsButton;
    }
}