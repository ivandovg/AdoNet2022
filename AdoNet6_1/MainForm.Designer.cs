
namespace AdoNet6_1
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
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edFirstname = new System.Windows.Forms.TextBox();
            this.edLastname = new System.Windows.Forms.TextBox();
            this.edBirth = new System.Windows.Forms.DateTimePicker();
            this.colActorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActorFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActorLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActorBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActorCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActorOscar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edCountry = new System.Windows.Forms.TextBox();
            this.edOscar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActors
            // 
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActorId,
            this.colActorFirstname,
            this.colActorLastname,
            this.colActorBirth,
            this.colActorCountry,
            this.colActorOscar});
            this.dgvActors.Location = new System.Drawing.Point(12, 12);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(556, 312);
            this.dgvActors.TabIndex = 0;
            this.dgvActors.SelectionChanged += new System.EventHandler(this.dgvActors_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(133, 392);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Save changes";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(256, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth";
            // 
            // edFirstname
            // 
            this.edFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edFirstname.Location = new System.Drawing.Point(69, 339);
            this.edFirstname.Name = "edFirstname";
            this.edFirstname.Size = new System.Drawing.Size(100, 20);
            this.edFirstname.TabIndex = 7;
            // 
            // edLastname
            // 
            this.edLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edLastname.Location = new System.Drawing.Point(243, 339);
            this.edLastname.Name = "edLastname";
            this.edLastname.Size = new System.Drawing.Size(100, 20);
            this.edLastname.TabIndex = 8;
            // 
            // edBirth
            // 
            this.edBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edBirth.Location = new System.Drawing.Point(392, 339);
            this.edBirth.Name = "edBirth";
            this.edBirth.Size = new System.Drawing.Size(125, 20);
            this.edBirth.TabIndex = 9;
            // 
            // colActorId
            // 
            this.colActorId.DataPropertyName = "Id";
            this.colActorId.HeaderText = "#";
            this.colActorId.Name = "colActorId";
            this.colActorId.ReadOnly = true;
            this.colActorId.Width = 60;
            // 
            // colActorFirstname
            // 
            this.colActorFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActorFirstname.DataPropertyName = "FirstName";
            this.colActorFirstname.HeaderText = "Firstname";
            this.colActorFirstname.Name = "colActorFirstname";
            // 
            // colActorLastname
            // 
            this.colActorLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActorLastname.DataPropertyName = "LastName";
            this.colActorLastname.HeaderText = "Lastname";
            this.colActorLastname.Name = "colActorLastname";
            // 
            // colActorBirth
            // 
            this.colActorBirth.DataPropertyName = "Birth";
            this.colActorBirth.HeaderText = "Birth";
            this.colActorBirth.Name = "colActorBirth";
            // 
            // colActorCountry
            // 
            this.colActorCountry.DataPropertyName = "Country";
            this.colActorCountry.HeaderText = "Country";
            this.colActorCountry.Name = "colActorCountry";
            // 
            // colActorOscar
            // 
            this.colActorOscar.DataPropertyName = "Oscar";
            this.colActorOscar.HeaderText = "Oscar";
            this.colActorOscar.Name = "colActorOscar";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oscar";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // edCountry
            // 
            this.edCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edCountry.Location = new System.Drawing.Point(69, 365);
            this.edCountry.Name = "edCountry";
            this.edCountry.Size = new System.Drawing.Size(100, 20);
            this.edCountry.TabIndex = 12;
            // 
            // edOscar
            // 
            this.edOscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edOscar.Location = new System.Drawing.Point(243, 365);
            this.edOscar.Name = "edOscar";
            this.edOscar.Size = new System.Drawing.Size(100, 20);
            this.edOscar.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 426);
            this.Controls.Add(this.edOscar);
            this.Controls.Add(this.edCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edBirth);
            this.Controls.Add(this.edLastname);
            this.Controls.Add(this.edFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvActors);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdoNet - EF";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edFirstname;
        private System.Windows.Forms.TextBox edLastname;
        private System.Windows.Forms.DateTimePicker edBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActorFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActorLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActorBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActorCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActorOscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edCountry;
        private System.Windows.Forms.NumericUpDown edOscar;
    }
}

