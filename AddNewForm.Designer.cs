
namespace AdvancedOOPProject
{
    partial class AddNewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewTypeCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewNameTBox = new System.Windows.Forms.TextBox();
            this.NewPriceTBox = new System.Windows.Forms.TextBox();
            this.NewQuantityTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NewPDateDBox = new System.Windows.Forms.DateTimePicker();
            this.NewExpDateDBox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.CancelNewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // NewTypeCBox
            // 
            this.NewTypeCBox.FormattingEnabled = true;
            this.NewTypeCBox.Location = new System.Drawing.Point(93, 34);
            this.NewTypeCBox.Name = "NewTypeCBox";
            this.NewTypeCBox.Size = new System.Drawing.Size(121, 21);
            this.NewTypeCBox.TabIndex = 4;
            this.NewTypeCBox.SelectedIndexChanged += new System.EventHandler(this.NewTypeCBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // NewNameTBox
            // 
            this.NewNameTBox.Location = new System.Drawing.Point(93, 80);
            this.NewNameTBox.Name = "NewNameTBox";
            this.NewNameTBox.Size = new System.Drawing.Size(100, 20);
            this.NewNameTBox.TabIndex = 6;
            // 
            // NewPriceTBox
            // 
            this.NewPriceTBox.Location = new System.Drawing.Point(93, 124);
            this.NewPriceTBox.Name = "NewPriceTBox";
            this.NewPriceTBox.Size = new System.Drawing.Size(100, 20);
            this.NewPriceTBox.TabIndex = 7;
            // 
            // NewQuantityTBox
            // 
            this.NewQuantityTBox.Location = new System.Drawing.Point(93, 177);
            this.NewQuantityTBox.Name = "NewQuantityTBox";
            this.NewQuantityTBox.Size = new System.Drawing.Size(100, 20);
            this.NewQuantityTBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Production date";
            // 
            // NewPDateDBox
            // 
            this.NewPDateDBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewPDateDBox.Location = new System.Drawing.Point(99, 237);
            this.NewPDateDBox.Name = "NewPDateDBox";
            this.NewPDateDBox.Size = new System.Drawing.Size(89, 20);
            this.NewPDateDBox.TabIndex = 12;
            // 
            // NewExpDateDBox
            // 
            this.NewExpDateDBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewExpDateDBox.Location = new System.Drawing.Point(99, 263);
            this.NewExpDateDBox.Name = "NewExpDateDBox";
            this.NewExpDateDBox.Size = new System.Drawing.Size(89, 20);
            this.NewExpDateDBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expiration date";
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Location = new System.Drawing.Point(248, 83);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNewBtn.TabIndex = 16;
            this.AddNewBtn.Text = "Add";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // CancelNewBtn
            // 
            this.CancelNewBtn.Location = new System.Drawing.Point(248, 121);
            this.CancelNewBtn.Name = "CancelNewBtn";
            this.CancelNewBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelNewBtn.TabIndex = 17;
            this.CancelNewBtn.Text = "Cancel";
            this.CancelNewBtn.UseVisualStyleBackColor = true;
            this.CancelNewBtn.Click += new System.EventHandler(this.CancelNewBtn_Click);
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 298);
            this.Controls.Add(this.CancelNewBtn);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NewExpDateDBox);
            this.Controls.Add(this.NewPDateDBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewQuantityTBox);
            this.Controls.Add(this.NewPriceTBox);
            this.Controls.Add(this.NewNameTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewTypeCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewForm";
            this.Text = "Add new";
            this.Load += new System.EventHandler(this.AddNewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NewTypeCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewNameTBox;
        private System.Windows.Forms.TextBox NewPriceTBox;
        private System.Windows.Forms.TextBox NewQuantityTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NewPDateDBox;
        private System.Windows.Forms.DateTimePicker NewExpDateDBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button CancelNewBtn;
    }
}