
namespace music
{
    partial class Records
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
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label interpreterLabel;
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.interpreterTextBox = new System.Windows.Forms.TextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.restart_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menu_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addRecordButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            typeLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            interpreterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(416, 83);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(38, 17);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "type:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(410, 41);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(46, 17);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "genre:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(629, 41);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(37, 17);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "year:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(214, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(34, 17);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "title:";
            // 
            // interpreterLabel
            // 
            interpreterLabel.AutoSize = true;
            interpreterLabel.Location = new System.Drawing.Point(172, 83);
            interpreterLabel.Name = "interpreterLabel";
            interpreterLabel.Size = new System.Drawing.Size(76, 17);
            interpreterLabel.TabIndex = 9;
            interpreterLabel.Text = "interpreter:";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // recordsDataGrid
            // 
            this.recordsDataGrid.AllowUserToAddRows = false;
            this.recordsDataGrid.AllowUserToDeleteRows = false;
            this.recordsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.recordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsDataGrid.Location = new System.Drawing.Point(20, 140);
            this.recordsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.recordsDataGrid.Name = "recordsDataGrid";
            this.recordsDataGrid.Palette = this.kryptonPalette1;
            this.recordsDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.recordsDataGrid.ReadOnly = true;
            this.recordsDataGrid.RowHeadersVisible = false;
            this.recordsDataGrid.Size = new System.Drawing.Size(1066, 396);
            this.recordsDataGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.recordsDataGrid.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.recordsDataGrid.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.recordsDataGrid.StateCommon.DataCell.Border.ColorAngle = 45F;
            this.recordsDataGrid.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.recordsDataGrid.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.recordsDataGrid.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.recordsDataGrid.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.recordsDataGrid.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.recordsDataGrid.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.recordsDataGrid.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.recordsDataGrid.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.recordsDataGrid.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.recordsDataGrid.StateCommon.HeaderColumn.Border.Width = 1;
            this.recordsDataGrid.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.recordsDataGrid.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.recordsDataGrid.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsDataGrid.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.recordsDataGrid.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.recordsDataGrid.StateCommon.HeaderRow.Back.ColorAngle = 45F;
            this.recordsDataGrid.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.recordsDataGrid.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.recordsDataGrid.StateCommon.HeaderRow.Border.ColorAngle = 45F;
            this.recordsDataGrid.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.recordsDataGrid.StateCommon.HeaderRow.Border.Rounding = 2;
            this.recordsDataGrid.StateCommon.HeaderRow.Border.Width = 1;
            this.recordsDataGrid.TabIndex = 0;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DisplayMember = "type";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(462, 80);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(144, 25);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.ValueMember = "type";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DisplayMember = "genre";
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(462, 38);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(144, 25);
            this.genreComboBox.TabIndex = 4;
            this.genreComboBox.ValueMember = "genre";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(672, 38);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 25);
            this.yearTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(254, 38);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(141, 25);
            this.titleTextBox.TabIndex = 8;
            // 
            // interpreterTextBox
            // 
            this.interpreterTextBox.Location = new System.Drawing.Point(254, 80);
            this.interpreterTextBox.Name = "interpreterTextBox";
            this.interpreterTextBox.Size = new System.Drawing.Size(141, 25);
            this.interpreterTextBox.TabIndex = 10;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(632, 80);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.Size = new System.Drawing.Size(89, 38);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.kryptonButton1.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 15;
            this.kryptonButton1.StateTracking.Border.Width = 2;
            this.kryptonButton1.TabIndex = 11;
            this.kryptonButton1.Values.Text = "filter";
            this.kryptonButton1.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // restart_button
            // 
            this.restart_button.Location = new System.Drawing.Point(747, 80);
            this.restart_button.Name = "restart_button";
            this.restart_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.restart_button.OverrideDefault.Back.ColorAngle = 45F;
            this.restart_button.Size = new System.Drawing.Size(90, 38);
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
            this.restart_button.TabIndex = 12;
            this.restart_button.Values.Text = "restart";
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // menu_button
            // 
            this.menu_button.Location = new System.Drawing.Point(12, 1);
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
            this.menu_button.TabIndex = 13;
            this.menu_button.Values.Text = "menu";
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // addRecordButton
            // 
            this.addRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecordButton.Location = new System.Drawing.Point(936, 12);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.OverrideDefault.Back.ColorAngle = 45F;
            this.addRecordButton.Size = new System.Drawing.Size(141, 38);
            this.addRecordButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.StateCommon.Back.ColorAngle = 45F;
            this.addRecordButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.StateCommon.Border.ColorAngle = 45F;
            this.addRecordButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecordButton.StateCommon.Border.Rounding = 15;
            this.addRecordButton.StateCommon.Border.Width = 1;
            this.addRecordButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.addRecordButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.addRecordButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.addRecordButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecordButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.addRecordButton.StatePressed.Back.ColorAngle = 45F;
            this.addRecordButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.addRecordButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.addRecordButton.StateTracking.Border.ColorAngle = 45F;
            this.addRecordButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecordButton.StateTracking.Border.Rounding = 15;
            this.addRecordButton.StateTracking.Border.Width = 2;
            this.addRecordButton.TabIndex = 14;
            this.addRecordButton.Values.Text = "Add Record";
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1099, 549);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(interpreterLabel);
            this.Controls.Add(this.interpreterTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.recordsDataGrid);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Records";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.on_form_closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView recordsDataGrid;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox interpreterTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton restart_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addRecordButton;
    }
}