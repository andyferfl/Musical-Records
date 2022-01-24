
namespace music
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.registerLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.passwordTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.signInButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.usernameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // registerLabel
            // 
            this.registerLabel.Location = new System.Drawing.Point(79, 199);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(56, 21);
            this.registerLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.registerLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.registerLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.TabIndex = 7;
            this.registerLabel.Values.Text = "Register";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AlwaysActive = false;
            this.passwordTextBox.Location = new System.Drawing.Point(16, 101);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(196, 31);
            this.passwordTextBox.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.passwordTextBox.StateActive.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordTextBox.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.passwordTextBox.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.passwordTextBox.StateCommon.Border.ColorAngle = 45F;
            this.passwordTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordTextBox.StateCommon.Border.Rounding = 10;
            this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.passwordTextBox.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.passwordTextBox.StateDisabled.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInButton.Location = new System.Drawing.Point(16, 158);
            this.signInButton.Name = "signInButton";
            this.signInButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.OverrideDefault.Back.ColorAngle = 45F;
            this.signInButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.OverrideDefault.Border.ColorAngle = 45F;
            this.signInButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signInButton.OverrideDefault.Border.Rounding = 15;
            this.signInButton.Size = new System.Drawing.Size(196, 35);
            this.signInButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.StateCommon.Back.ColorAngle = 45F;
            this.signInButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.signInButton.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.signInButton.StateCommon.Border.ColorAngle = 45F;
            this.signInButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signInButton.StateCommon.Border.Rounding = 15;
            this.signInButton.StateCommon.Border.Width = 2;
            this.signInButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.signInButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.signInButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.signInButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.signInButton.StateTracking.Border.ColorAngle = 45F;
            this.signInButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.StateTracking.Border.Rounding = 15;
            this.signInButton.StateTracking.Border.Width = 2;
            this.signInButton.TabIndex = 4;
            this.signInButton.Values.Text = "Sign in";
            this.signInButton.Click += new System.EventHandler(this.sign_in_login_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AlwaysActive = false;
            this.usernameTextBox.Location = new System.Drawing.Point(16, 33);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(196, 31);
            this.usernameTextBox.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.usernameTextBox.StateActive.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.usernameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.usernameTextBox.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.usernameTextBox.StateCommon.Border.ColorAngle = 45F;
            this.usernameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.usernameTextBox.StateCommon.Border.Rounding = 10;
            this.usernameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usernameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.Tag = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 74);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(64, 21);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "Password";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(16, 6);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(67, 21);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(224, 225);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.signInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel registerLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signInButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}

