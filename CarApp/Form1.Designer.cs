namespace CarApp
{
    partial class Form1
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
            System.Windows.Forms.GroupBox groupBox1;
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxForSale = new System.Windows.Forms.CheckBox();
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.lsvCars = new System.Windows.Forms.ListView();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forsale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.btnSearch);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(this.btnAdd);
            groupBox1.Controls.Add(this.cbxForSale);
            groupBox1.Controls.Add(this.tbxRegNr);
            groupBox1.Controls.Add(this.tbxMake);
            groupBox1.Controls.Add(this.tbxYear);
            groupBox1.Controls.Add(this.tbxModel);
            groupBox1.Location = new System.Drawing.Point(27, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(751, 148);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "År";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Märke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reg Nr";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxForSale
            // 
            this.cbxForSale.AutoSize = true;
            this.cbxForSale.Location = new System.Drawing.Point(579, 25);
            this.cbxForSale.Name = "cbxForSale";
            this.cbxForSale.Size = new System.Drawing.Size(89, 24);
            this.cbxForSale.TabIndex = 4;
            this.cbxForSale.Text = "Till Salu";
            this.cbxForSale.UseVisualStyleBackColor = true;
            this.cbxForSale.CheckedChanged += new System.EventHandler(this.cbxForSale_CheckedChanged);
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(135, 25);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(100, 26);
            this.tbxRegNr.TabIndex = 3;
            this.tbxRegNr.TextChanged += new System.EventHandler(this.tbxRegNr_TextChanged);
            // 
            // tbxMake
            // 
            this.tbxMake.Location = new System.Drawing.Point(135, 68);
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(100, 26);
            this.tbxMake.TabIndex = 0;
            this.tbxMake.TextChanged += new System.EventHandler(this.tbxMake_TextChanged);
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(432, 68);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 26);
            this.tbxYear.TabIndex = 1;
            this.tbxYear.TextChanged += new System.EventHandler(this.tbxYear_TextChanged);
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(432, 25);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 26);
            this.tbxModel.TabIndex = 2;
            this.tbxModel.TextChanged += new System.EventHandler(this.tbxModel_TextChanged);
            // 
            // lsvCars
            // 
            this.lsvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.make,
            this.forsale});
            this.lsvCars.Location = new System.Drawing.Point(12, 168);
            this.lsvCars.Name = "lsvCars";
            this.lsvCars.Size = new System.Drawing.Size(776, 266);
            this.lsvCars.TabIndex = 4;
            this.lsvCars.UseCompatibleStateImageBehavior = false;
            this.lsvCars.View = System.Windows.Forms.View.Details;
            this.lsvCars.SelectedIndexChanged += new System.EventHandler(this.lsvCars_SelectedIndexChanged);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg Nr";
            this.regnr.Width = 66;
            // 
            // make
            // 
            this.make.Text = "Märke";
            // 
            // forsale
            // 
            this.forsale.Text = "Till Salu";
            this.forsale.Width = 68;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(12, 443);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(153, 34);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Rensa bort all data";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(606, 443);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(182, 34);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Ta bort markerad";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(579, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Sök i Biluppgifter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.lsvCars);
            this.Name = "Form1";
            this.Text = "Bilar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMake;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxRegNr;
        private System.Windows.Forms.ListView lsvCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbxForSale;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ColumnHeader make;
        private System.Windows.Forms.ColumnHeader forsale;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}

