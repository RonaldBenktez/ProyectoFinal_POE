namespace PresentationLayer.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginErrorProvider = new ErrorProvider(components);
            loginPanel = new Panel();
            pictureBox2 = new PictureBox();
            userIconPictureBox = new PictureBox();
            LoginButton = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lineLabel = new Label();
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            passwordLabel = new Label();
            userLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginErrorProvider
            // 
            loginErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            loginErrorProvider.ContainerControl = this;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.None;
            loginPanel.BackColor = Color.Transparent;
            loginPanel.Controls.Add(pictureBox2);
            loginPanel.Controls.Add(userIconPictureBox);
            loginPanel.Controls.Add(LoginButton);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(lineLabel);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(userTextBox);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(userLabel);
            loginPanel.Location = new Point(349, 204);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(660, 320);
            loginPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(117, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // userIconPictureBox
            // 
            userIconPictureBox.Image = (Image)resources.GetObject("userIconPictureBox.Image");
            userIconPictureBox.Location = new Point(117, 32);
            userIconPictureBox.Name = "userIconPictureBox";
            userIconPictureBox.Size = new Size(45, 44);
            userIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userIconPictureBox.TabIndex = 7;
            userIconPictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = Color.DimGray;
            LoginButton.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ButtonFace;
            LoginButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            LoginButton.IconColor = SystemColors.ActiveCaptionText;
            LoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LoginButton.ImageAlign = ContentAlignment.MiddleRight;
            LoginButton.Location = new Point(227, 232);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(223, 68);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "acceder";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(3, 211);
            label1.Name = "label1";
            label1.Size = new Size(650, 1);
            label1.TabIndex = 5;
            // 
            // lineLabel
            // 
            lineLabel.BackColor = Color.Transparent;
            lineLabel.BorderStyle = BorderStyle.FixedSingle;
            lineLabel.Location = new Point(3, 90);
            lineLabel.Name = "lineLabel";
            lineLabel.Size = new Size(650, 1);
            lineLabel.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(187, 151);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(356, 24);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userTextBox
            // 
            userTextBox.BackColor = Color.WhiteSmoke;
            userTextBox.BorderStyle = BorderStyle.FixedSingle;
            userTextBox.Location = new Point(187, 44);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(356, 24);
            userTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(250, 101);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(162, 47);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "contraseña";
            // 
            // userLabel
            // 
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.Black;
            userLabel.Location = new Point(273, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(115, 32);
            userLabel.TabIndex = 0;
            userLabel.Text = "usuario";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 738);
            Controls.Add(loginPanel);
            DoubleBuffered = true;
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider loginErrorProvider;
        private Panel loginPanel;
        private TextBox userTextBox;
        private Label passwordLabel;
        private Label userLabel;
        private TextBox passwordTextBox;
        private FontAwesome.Sharp.IconButton LoginButton;
        private Label label1;
        private Label lineLabel;
        private PictureBox pictureBox2;
        private PictureBox userIconPictureBox;
    }
}