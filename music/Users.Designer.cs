
namespace music
{
    partial class Users
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label roleLabel;
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.menu_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.restart_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.filterButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.usersDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(543, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(45, 17);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "name:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastnameLabel.ForeColor = System.Drawing.Color.White;
            lastnameLabel.Location = new System.Drawing.Point(780, 59);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(70, 17);
            lastnameLabel.TabIndex = 21;
            lastnameLabel.Text = "last name:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            roleLabel.ForeColor = System.Drawing.Color.White;
            roleLabel.Location = new System.Drawing.Point(284, 60);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(34, 17);
            roleLabel.TabIndex = 17;
            roleLabel.Text = "role:";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormMax.AllowInheritText = false;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Window;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ColorAngle = 45F;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPalette1.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelAlternate.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelAlternate.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelAlternate.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelAlternate.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelAlternate.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            // 
            // menu_button
            // 
            this.menu_button.Location = new System.Drawing.Point(20, 0);
            this.menu_button.Name = "menu_button";
            this.menu_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.OverrideDefault.Back.ColorAngle = 45F;
            this.menu_button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.OverrideDefault.Border.ColorAngle = 45F;
            this.menu_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_button.OverrideDefault.Border.Rounding = 10;
            this.menu_button.OverrideDefault.Border.Width = 1;
            this.menu_button.Size = new System.Drawing.Size(78, 29);
            this.menu_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.StateCommon.Back.ColorAngle = 45F;
            this.menu_button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.StateCommon.Border.ColorAngle = 45F;
            this.menu_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_button.StateCommon.Border.Rounding = 10;
            this.menu_button.StateCommon.Border.Width = 1;
            this.menu_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.menu_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.menu_button.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.menu_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.menu_button.StateTracking.Back.ColorAngle = 45F;
            this.menu_button.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.menu_button.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.menu_button.StateTracking.Border.ColorAngle = 45F;
            this.menu_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_button.StateTracking.Border.Rounding = 10;
            this.menu_button.StateTracking.Border.Width = 2;
            this.menu_button.TabIndex = 27;
            this.menu_button.Values.Text = "menu";
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // restart_button
            // 
            this.restart_button.Location = new System.Drawing.Point(980, 0);
            this.restart_button.Name = "restart_button";
            this.restart_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.OverrideDefault.Back.ColorAngle = 45F;
            this.restart_button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.Size = new System.Drawing.Size(90, 40);
            this.restart_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.StateCommon.Back.ColorAngle = 45F;
            this.restart_button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.StateCommon.Border.ColorAngle = 45F;
            this.restart_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.restart_button.StateCommon.Border.Rounding = 15;
            this.restart_button.StateCommon.Border.Width = 1;
            this.restart_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.restart_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.StatePressed.Back.ColorAngle = 45F;
            this.restart_button.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.restart_button.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.restart_button.StateTracking.Border.ColorAngle = 45F;
            this.restart_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.restart_button.StateTracking.Border.Rounding = 15;
            this.restart_button.StateTracking.Border.Width = 2;
            this.restart_button.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.restart_button.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.restart_button.TabIndex = 26;
            this.restart_button.Values.Text = "restart";
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(874, 0);
            this.filterButton.Name = "filterButton";
            this.filterButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.filterButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.filterButton.OverrideDefault.Back.ColorAngle = 45F;
            this.filterButton.Size = new System.Drawing.Size(89, 40);
            this.filterButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.filterButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.filterButton.StateCommon.Back.ColorAngle = 45F;
            this.filterButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.filterButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.filterButton.StateCommon.Border.ColorAngle = 45F;
            this.filterButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.filterButton.StateCommon.Border.Rounding = 15;
            this.filterButton.StateCommon.Border.Width = 1;
            this.filterButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.filterButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.filterButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.filterButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.filterButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.filterButton.StateTracking.Border.ColorAngle = 45F;
            this.filterButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.filterButton.StateTracking.Border.Rounding = 15;
            this.filterButton.StateTracking.Border.Width = 2;
            this.filterButton.StateTracking.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.filterButton.StateTracking.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.filterButton.StateTracking.Content.LongText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.filterButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.filterButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.filterButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.filterButton.TabIndex = 25;
            this.filterButton.Values.Text = "filter";
            this.filterButton.Click += new System.EventHandler(this.filter_Click);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(865, 59);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(141, 20);
            this.lastnameTextBox.TabIndex = 24;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(594, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 22;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DisplayMember = "role";
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(336, 59);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(144, 21);
            this.roleComboBox.TabIndex = 18;
            this.roleComboBox.ValueMember = "genre";
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToAddRows = false;
            this.usersDataGrid.AllowUserToDeleteRows = false;
            this.usersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersDataGrid.Location = new System.Drawing.Point(20, 108);
            this.usersDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.Palette = this.kryptonPalette1;
            this.usersDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowHeadersVisible = false;
            this.usersDataGrid.Size = new System.Drawing.Size(1066, 428);
            this.usersDataGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.usersDataGrid.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usersDataGrid.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usersDataGrid.StateCommon.DataCell.Border.ColorAngle = 45F;
            this.usersDataGrid.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usersDataGrid.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.usersDataGrid.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.usersDataGrid.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.usersDataGrid.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usersDataGrid.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usersDataGrid.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.usersDataGrid.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usersDataGrid.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.usersDataGrid.StateCommon.HeaderColumn.Border.Width = 1;
            this.usersDataGrid.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.usersDataGrid.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.usersDataGrid.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersDataGrid.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.usersDataGrid.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.usersDataGrid.StateCommon.HeaderRow.Back.ColorAngle = 45F;
            this.usersDataGrid.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usersDataGrid.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.usersDataGrid.StateCommon.HeaderRow.Border.ColorAngle = 45F;
            this.usersDataGrid.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usersDataGrid.StateCommon.HeaderRow.Border.Rounding = 2;
            this.usersDataGrid.StateCommon.HeaderRow.Border.Width = 1;
            this.usersDataGrid.TabIndex = 14;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(57, 63);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 17);
            this.loginLabel.TabIndex = 39;
            this.loginLabel.Text = "login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(104, 60);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(136, 20);
            this.loginTextBox.TabIndex = 37;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1099, 549);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.usersDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Users";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.on_form_closed);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton restart_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton filterButton;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView usersDataGrid;
        private System.Windows.Forms.TextBox loginTextBox;
        internal System.Windows.Forms.Label loginLabel;
    }
}