
namespace AdoNet8_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvToys = new System.Windows.Forms.DataGridView();
            this.colManufacturerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturerShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToysId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToysName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToysCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToysCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToysManufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnAddToys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edToyName = new System.Windows.Forms.TextBox();
            this.edToyCost = new System.Windows.Forms.NumericUpDown();
            this.edToyCount = new System.Windows.Forms.NumericUpDown();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edToyCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edToyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvManufacturers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manufacturers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colManufacturerId,
            this.colManufacturerShortName,
            this.colManufacturerPhone});
            this.dgvManufacturers.Location = new System.Drawing.Point(6, 6);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.ReadOnly = true;
            this.dgvManufacturers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManufacturers.Size = new System.Drawing.Size(607, 295);
            this.dgvManufacturers.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbManufacturer);
            this.tabPage2.Controls.Add(this.edToyCount);
            this.tabPage2.Controls.Add(this.edToyCost);
            this.tabPage2.Controls.Add(this.edToyName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnAddToys);
            this.tabPage2.Controls.Add(this.dgvToys);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvToys
            // 
            this.dgvToys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colToysId,
            this.colToysName,
            this.colToysCost,
            this.colToysCount,
            this.colToysManufacturer});
            this.dgvToys.Location = new System.Drawing.Point(6, 6);
            this.dgvToys.Name = "dgvToys";
            this.dgvToys.Size = new System.Drawing.Size(607, 295);
            this.dgvToys.TabIndex = 2;
            // 
            // colManufacturerId
            // 
            this.colManufacturerId.DataPropertyName = "Id";
            this.colManufacturerId.HeaderText = "Id";
            this.colManufacturerId.Name = "colManufacturerId";
            this.colManufacturerId.ReadOnly = true;
            this.colManufacturerId.Width = 60;
            // 
            // colManufacturerShortName
            // 
            this.colManufacturerShortName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colManufacturerShortName.DataPropertyName = "ShortName";
            this.colManufacturerShortName.HeaderText = "Name";
            this.colManufacturerShortName.Name = "colManufacturerShortName";
            this.colManufacturerShortName.ReadOnly = true;
            // 
            // colManufacturerPhone
            // 
            this.colManufacturerPhone.DataPropertyName = "Phone";
            this.colManufacturerPhone.HeaderText = "Phone";
            this.colManufacturerPhone.Name = "colManufacturerPhone";
            this.colManufacturerPhone.ReadOnly = true;
            // 
            // colToysId
            // 
            this.colToysId.DataPropertyName = "Id";
            this.colToysId.HeaderText = "Id";
            this.colToysId.Name = "colToysId";
            this.colToysId.ReadOnly = true;
            this.colToysId.Width = 60;
            // 
            // colToysName
            // 
            this.colToysName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colToysName.DataPropertyName = "Name";
            this.colToysName.HeaderText = "Name";
            this.colToysName.Name = "colToysName";
            // 
            // colToysCost
            // 
            this.colToysCost.DataPropertyName = "Cost";
            this.colToysCost.HeaderText = "Cost";
            this.colToysCost.Name = "colToysCost";
            this.colToysCost.Width = 80;
            // 
            // colToysCount
            // 
            this.colToysCount.DataPropertyName = "Count";
            this.colToysCount.HeaderText = "Count";
            this.colToysCount.Name = "colToysCount";
            this.colToysCount.Width = 50;
            // 
            // colToysManufacturer
            // 
            this.colToysManufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colToysManufacturer.DataPropertyName = "ManufacturerId";
            this.colToysManufacturer.HeaderText = "Manufacturer";
            this.colToysManufacturer.Name = "colToysManufacturer";
            // 
            // btnAddToys
            // 
            this.btnAddToys.Location = new System.Drawing.Point(534, 321);
            this.btnAddToys.Name = "btnAddToys";
            this.btnAddToys.Size = new System.Drawing.Size(75, 23);
            this.btnAddToys.TabIndex = 3;
            this.btnAddToys.Text = "Add";
            this.btnAddToys.UseVisualStyleBackColor = true;
            this.btnAddToys.Click += new System.EventHandler(this.btnAddToys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufacturer";
            // 
            // edToyName
            // 
            this.edToyName.Location = new System.Drawing.Point(7, 324);
            this.edToyName.Name = "edToyName";
            this.edToyName.Size = new System.Drawing.Size(162, 20);
            this.edToyName.TabIndex = 8;
            // 
            // edToyCost
            // 
            this.edToyCost.Location = new System.Drawing.Point(175, 324);
            this.edToyCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edToyCost.Name = "edToyCost";
            this.edToyCost.Size = new System.Drawing.Size(87, 20);
            this.edToyCost.TabIndex = 9;
            // 
            // edToyCount
            // 
            this.edToyCount.Location = new System.Drawing.Point(268, 324);
            this.edToyCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edToyCount.Name = "edToyCount";
            this.edToyCount.Size = new System.Drawing.Size(71, 20);
            this.edToyCount.TabIndex = 10;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(345, 323);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(183, 21);
            this.cmbManufacturer.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdoNet - ModelFirst";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edToyCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edToyCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvToys;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturerShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToysId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToysName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToysCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToysCount;
        private System.Windows.Forms.DataGridViewComboBoxColumn colToysManufacturer;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.NumericUpDown edToyCount;
        private System.Windows.Forms.NumericUpDown edToyCost;
        private System.Windows.Forms.TextBox edToyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToys;
    }
}

