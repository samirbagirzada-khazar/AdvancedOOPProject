
namespace AdvancedOOPProject
{
    partial class MainWindow
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.IdFilterTBox = new System.Windows.Forms.TextBox();
            this.NameFilterTBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PDateDBox = new System.Windows.Forms.DateTimePicker();
            this.ExpDateDBox = new System.Windows.Forms.DateTimePicker();
            this.IdFilterCBox = new System.Windows.Forms.CheckBox();
            this.NameFilterCBox = new System.Windows.Forms.CheckBox();
            this.PriceFilterCBox = new System.Windows.Forms.CheckBox();
            this.ExpDateFilterCBox = new System.Windows.Forms.CheckBox();
            this.UnitFilterCBox = new System.Windows.Forms.CheckBox();
            this.PDateFilterCBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ClearFiltersBtn = new System.Windows.Forms.Button();
            this.TypeFilterCBox = new System.Windows.Forms.CheckBox();
            this.ShopDataGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.DeleteRowsBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(739, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by: ";
            // 
            // IdFilterTBox
            // 
            this.IdFilterTBox.Location = new System.Drawing.Point(61, 57);
            this.IdFilterTBox.Name = "IdFilterTBox";
            this.IdFilterTBox.Size = new System.Drawing.Size(38, 20);
            this.IdFilterTBox.TabIndex = 2;
            // 
            // NameFilterTBox
            // 
            this.NameFilterTBox.Location = new System.Drawing.Point(140, 58);
            this.NameFilterTBox.Name = "NameFilterTBox";
            this.NameFilterTBox.Size = new System.Drawing.Size(100, 20);
            this.NameFilterTBox.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(328, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 20);
            this.textBox4.TabIndex = 8;
            // 
            // PDateDBox
            // 
            this.PDateDBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PDateDBox.Location = new System.Drawing.Point(514, 58);
            this.PDateDBox.Name = "PDateDBox";
            this.PDateDBox.Size = new System.Drawing.Size(89, 20);
            this.PDateDBox.TabIndex = 10;
            // 
            // ExpDateDBox
            // 
            this.ExpDateDBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpDateDBox.Location = new System.Drawing.Point(643, 58);
            this.ExpDateDBox.Name = "ExpDateDBox";
            this.ExpDateDBox.Size = new System.Drawing.Size(89, 20);
            this.ExpDateDBox.TabIndex = 11;
            // 
            // IdFilterCBox
            // 
            this.IdFilterCBox.AutoSize = true;
            this.IdFilterCBox.Location = new System.Drawing.Point(63, 40);
            this.IdFilterCBox.Name = "IdFilterCBox";
            this.IdFilterCBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IdFilterCBox.Size = new System.Drawing.Size(37, 17);
            this.IdFilterCBox.TabIndex = 14;
            this.IdFilterCBox.Text = "ID";
            this.IdFilterCBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IdFilterCBox.UseVisualStyleBackColor = true;
            // 
            // NameFilterCBox
            // 
            this.NameFilterCBox.AutoSize = true;
            this.NameFilterCBox.Location = new System.Drawing.Point(140, 40);
            this.NameFilterCBox.Name = "NameFilterCBox";
            this.NameFilterCBox.Size = new System.Drawing.Size(54, 17);
            this.NameFilterCBox.TabIndex = 15;
            this.NameFilterCBox.Text = "Name";
            this.NameFilterCBox.UseVisualStyleBackColor = true;
            // 
            // PriceFilterCBox
            // 
            this.PriceFilterCBox.AutoSize = true;
            this.PriceFilterCBox.Location = new System.Drawing.Point(261, 40);
            this.PriceFilterCBox.Name = "PriceFilterCBox";
            this.PriceFilterCBox.Size = new System.Drawing.Size(50, 17);
            this.PriceFilterCBox.TabIndex = 16;
            this.PriceFilterCBox.Text = "Price";
            this.PriceFilterCBox.UseVisualStyleBackColor = true;
            // 
            // ExpDateFilterCBox
            // 
            this.ExpDateFilterCBox.AutoSize = true;
            this.ExpDateFilterCBox.Location = new System.Drawing.Point(643, 40);
            this.ExpDateFilterCBox.Name = "ExpDateFilterCBox";
            this.ExpDateFilterCBox.Size = new System.Drawing.Size(96, 17);
            this.ExpDateFilterCBox.TabIndex = 17;
            this.ExpDateFilterCBox.Text = "Expiration date";
            this.ExpDateFilterCBox.UseVisualStyleBackColor = true;
            // 
            // UnitFilterCBox
            // 
            this.UnitFilterCBox.AutoSize = true;
            this.UnitFilterCBox.Location = new System.Drawing.Point(327, 41);
            this.UnitFilterCBox.Name = "UnitFilterCBox";
            this.UnitFilterCBox.Size = new System.Drawing.Size(45, 17);
            this.UnitFilterCBox.TabIndex = 18;
            this.UnitFilterCBox.Text = "Unit";
            this.UnitFilterCBox.UseVisualStyleBackColor = true;
            // 
            // PDateFilterCBox
            // 
            this.PDateFilterCBox.AutoSize = true;
            this.PDateFilterCBox.Location = new System.Drawing.Point(514, 41);
            this.PDateFilterCBox.Name = "PDateFilterCBox";
            this.PDateFilterCBox.Size = new System.Drawing.Size(101, 17);
            this.PDateFilterCBox.TabIndex = 19;
            this.PDateFilterCBox.Text = "Production date";
            this.PDateFilterCBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // ClearFiltersBtn
            // 
            this.ClearFiltersBtn.Location = new System.Drawing.Point(4, 86);
            this.ClearFiltersBtn.Name = "ClearFiltersBtn";
            this.ClearFiltersBtn.Size = new System.Drawing.Size(52, 23);
            this.ClearFiltersBtn.TabIndex = 21;
            this.ClearFiltersBtn.Text = "Clear";
            this.ClearFiltersBtn.UseVisualStyleBackColor = true;

            // 
            // TypeFilterCBox
            // 
            this.TypeFilterCBox.AutoSize = true;
            this.TypeFilterCBox.Location = new System.Drawing.Point(384, 41);
            this.TypeFilterCBox.Name = "TypeFilterCBox";
            this.TypeFilterCBox.Size = new System.Drawing.Size(50, 17);
            this.TypeFilterCBox.TabIndex = 22;
            this.TypeFilterCBox.Text = "Type";
            this.TypeFilterCBox.UseVisualStyleBackColor = true;
            // 
            // ShopDataGrid
            // 
            this.ShopDataGrid.AllowUserToAddRows = false;
            this.ShopDataGrid.AllowUserToDeleteRows = false;
            this.ShopDataGrid.AllowUserToOrderColumns = true;
            this.ShopDataGrid.AllowUserToResizeRows = false;
            this.ShopDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.PriceColumn,
            this.UnitColumn,
            this.TypeColumn,
            this.ProductionDateColumn,
            this.ExpirationDateColumn});
            this.ShopDataGrid.Location = new System.Drawing.Point(0, 115);
            this.ShopDataGrid.Name = "ShopDataGrid";
            this.ShopDataGrid.ReadOnly = true;
            this.ShopDataGrid.Size = new System.Drawing.Size(739, 266);
            this.ShopDataGrid.TabIndex = 23;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // UnitColumn
            // 
            this.UnitColumn.HeaderText = "Unit";
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // ProductionDateColumn
            // 
            this.ProductionDateColumn.HeaderText = "Production date";
            this.ProductionDateColumn.Name = "ProductionDateColumn";
            this.ProductionDateColumn.ReadOnly = true;
            // 
            // ExpirationDateColumn
            // 
            this.ExpirationDateColumn.HeaderText = "Expiration date";
            this.ExpirationDateColumn.Name = "ExpirationDateColumn";
            this.ExpirationDateColumn.ReadOnly = true;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(63, 86);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 23);
            this.FilterBtn.TabIndex = 24;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;

            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Location = new System.Drawing.Point(13, 418);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(75, 23);
            this.AddRowBtn.TabIndex = 25;
            this.AddRowBtn.Text = "Add new";
            this.AddRowBtn.UseVisualStyleBackColor = true;

            // 
            // DeleteRowsBtn
            // 
            this.DeleteRowsBtn.Location = new System.Drawing.Point(112, 418);
            this.DeleteRowsBtn.Name = "DeleteRowsBtn";
            this.DeleteRowsBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteRowsBtn.TabIndex = 26;
            this.DeleteRowsBtn.Text = "Delete";
            this.DeleteRowsBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DeleteRowsBtn);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.ShopDataGrid);
            this.Controls.Add(this.TypeFilterCBox);
            this.Controls.Add(this.ClearFiltersBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PDateFilterCBox);
            this.Controls.Add(this.UnitFilterCBox);
            this.Controls.Add(this.ExpDateFilterCBox);
            this.Controls.Add(this.PriceFilterCBox);
            this.Controls.Add(this.NameFilterCBox);
            this.Controls.Add(this.IdFilterCBox);
            this.Controls.Add(this.ExpDateDBox);
            this.Controls.Add(this.PDateDBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.NameFilterTBox);
            this.Controls.Add(this.IdFilterTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdFilterTBox;
        private System.Windows.Forms.TextBox NameFilterTBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker PDateDBox;
        private System.Windows.Forms.DateTimePicker ExpDateDBox;
        private System.Windows.Forms.CheckBox IdFilterCBox;
        private System.Windows.Forms.CheckBox NameFilterCBox;
        private System.Windows.Forms.CheckBox PriceFilterCBox;
        private System.Windows.Forms.CheckBox ExpDateFilterCBox;
        private System.Windows.Forms.CheckBox UnitFilterCBox;
        private System.Windows.Forms.CheckBox PDateFilterCBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ClearFiltersBtn;
        private System.Windows.Forms.CheckBox TypeFilterCBox;
        private System.Windows.Forms.DataGridView ShopDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDateColumn;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button DeleteRowsBtn;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

