
namespace music
{
    partial class MakeOrder
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
            this.orderRecordsDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.addToOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.interpreterTextBox = new System.Windows.Forms.TextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.restart_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menu_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.orderButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.priceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            typeLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            interpreterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderRecordsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(803, 72);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(38, 17);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "type:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(222, 72);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(46, 17);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "genre:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(424, 72);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(37, 17);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "year:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(35, 72);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(34, 17);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "title:";
            // 
            // interpreterLabel
            // 
            interpreterLabel.AutoSize = true;
            interpreterLabel.Location = new System.Drawing.Point(573, 72);
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
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // orderRecordsDataGrid
            // 
            this.orderRecordsDataGrid.AllowUserToAddRows = false;
            this.orderRecordsDataGrid.AllowUserToDeleteRows = false;
            this.orderRecordsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderRecordsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderRecordsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderRecordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderRecordsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addToOrder});
            this.orderRecordsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.orderRecordsDataGrid.Location = new System.Drawing.Point(20, 111);
            this.orderRecordsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.orderRecordsDataGrid.Name = "orderRecordsDataGrid";
            this.orderRecordsDataGrid.Palette = this.kryptonPalette1;
            this.orderRecordsDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.orderRecordsDataGrid.ReadOnly = true;
            this.orderRecordsDataGrid.RowHeadersVisible = false;
            this.orderRecordsDataGrid.Size = new System.Drawing.Size(1066, 378);
            this.orderRecordsDataGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.orderRecordsDataGrid.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.orderRecordsDataGrid.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.orderRecordsDataGrid.StateCommon.DataCell.Border.ColorAngle = 45F;
            this.orderRecordsDataGrid.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Border.Width = 1;
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.orderRecordsDataGrid.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Back.ColorAngle = 45F;
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Border.ColorAngle = 45F;
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Border.Rounding = 2;
            this.orderRecordsDataGrid.StateCommon.HeaderRow.Border.Width = 1;
            this.orderRecordsDataGrid.TabIndex = 0;
            this.orderRecordsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordsDataGrid_CellContentClick);
            // 
            // addToOrder
            // 
            this.addToOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.addToOrder.FalseValue = "false";
            this.addToOrder.HeaderText = "add to order";
            this.addToOrder.Name = "addToOrder";
            this.addToOrder.ReadOnly = true;
            this.addToOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addToOrder.TrueValue = "true";
            this.addToOrder.Width = 95;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DisplayMember = "type";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(849, 69);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(110, 25);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.ValueMember = "type";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DisplayMember = "genre";
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(274, 69);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(144, 25);
            this.genreComboBox.TabIndex = 4;
            this.genreComboBox.ValueMember = "genre";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(467, 69);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 25);
            this.yearTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(75, 69);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(141, 25);
            this.titleTextBox.TabIndex = 8;
            // 
            // interpreterTextBox
            // 
            this.interpreterTextBox.Location = new System.Drawing.Point(655, 69);
            this.interpreterTextBox.Name = "interpreterTextBox";
            this.interpreterTextBox.Size = new System.Drawing.Size(141, 25);
            this.interpreterTextBox.TabIndex = 10;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(982, 66);
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
            this.restart_button.Location = new System.Drawing.Point(981, 12);
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
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.Location = new System.Drawing.Point(967, 499);
            this.orderButton.Name = "orderButton";
            this.orderButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.OverrideDefault.Back.ColorAngle = 45F;
            this.orderButton.Size = new System.Drawing.Size(90, 38);
            this.orderButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.StateCommon.Back.ColorAngle = 45F;
            this.orderButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.StateCommon.Border.ColorAngle = 45F;
            this.orderButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.orderButton.StateCommon.Border.Rounding = 15;
            this.orderButton.StateCommon.Border.Width = 1;
            this.orderButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.orderButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.orderButton.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.orderButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.orderButton.StatePressed.Back.ColorAngle = 45F;
            this.orderButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.orderButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.orderButton.StateTracking.Border.ColorAngle = 45F;
            this.orderButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.orderButton.StateTracking.Border.Rounding = 15;
            this.orderButton.StateTracking.Border.Width = 2;
            this.orderButton.TabIndex = 14;
            this.orderButton.Values.Text = "order";
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Location = new System.Drawing.Point(467, 507);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(128, 30);
            this.priceLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.priceLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.priceLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Values.Text = "Total price: 0";
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1099, 549);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.orderButton);
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
            this.Controls.Add(this.orderRecordsDataGrid);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MakeOrder";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.on_form_closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderRecordsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView orderRecordsDataGrid;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox interpreterTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton restart_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton orderButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel priceLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToOrder;
    }
}