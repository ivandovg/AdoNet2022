
namespace AdoNet2_2
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
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.colAuthorsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorsFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorsLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorsBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorsCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.edFirstname = new System.Windows.Forms.TextBox();
            this.edLastname = new System.Windows.Forms.TextBox();
            this.edBirthdate = new System.Windows.Forms.TextBox();
            this.edCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuthorsId,
            this.colAuthorsFirstname,
            this.colAuthorsLastname,
            this.colAuthorsBirthdate,
            this.colAuthorsCountry});
            this.dgvAuthors.Location = new System.Drawing.Point(12, 12);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.Size = new System.Drawing.Size(447, 271);
            this.dgvAuthors.TabIndex = 0;
            this.dgvAuthors.SelectionChanged += new System.EventHandler(this.dgvAuthors_SelectionChanged);
            // 
            // colAuthorsId
            // 
            this.colAuthorsId.DataPropertyName = "Id";
            this.colAuthorsId.HeaderText = "#";
            this.colAuthorsId.Name = "colAuthorsId";
            this.colAuthorsId.ReadOnly = true;
            this.colAuthorsId.Width = 50;
            // 
            // colAuthorsFirstname
            // 
            this.colAuthorsFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuthorsFirstname.DataPropertyName = "Firstname";
            this.colAuthorsFirstname.HeaderText = "Firstname";
            this.colAuthorsFirstname.Name = "colAuthorsFirstname";
            // 
            // colAuthorsLastname
            // 
            this.colAuthorsLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuthorsLastname.DataPropertyName = "Lastname";
            this.colAuthorsLastname.HeaderText = "Lastname";
            this.colAuthorsLastname.Name = "colAuthorsLastname";
            // 
            // colAuthorsBirthdate
            // 
            this.colAuthorsBirthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuthorsBirthdate.DataPropertyName = "Birthdate";
            this.colAuthorsBirthdate.HeaderText = "Birthdate";
            this.colAuthorsBirthdate.Name = "colAuthorsBirthdate";
            // 
            // colAuthorsCountry
            // 
            this.colAuthorsCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuthorsCountry.DataPropertyName = "Country";
            this.colAuthorsCountry.HeaderText = "Country";
            this.colAuthorsCountry.Name = "colAuthorsCountry";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // edFirstname
            // 
            this.edFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edFirstname.Location = new System.Drawing.Point(188, 289);
            this.edFirstname.Name = "edFirstname";
            this.edFirstname.Size = new System.Drawing.Size(100, 20);
            this.edFirstname.TabIndex = 2;
            // 
            // edLastname
            // 
            this.edLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edLastname.Location = new System.Drawing.Point(188, 319);
            this.edLastname.Name = "edLastname";
            this.edLastname.Size = new System.Drawing.Size(100, 20);
            this.edLastname.TabIndex = 3;
            // 
            // edBirthdate
            // 
            this.edBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edBirthdate.Location = new System.Drawing.Point(359, 289);
            this.edBirthdate.Name = "edBirthdate";
            this.edBirthdate.Size = new System.Drawing.Size(100, 20);
            this.edBirthdate.TabIndex = 4;
            // 
            // edCountry
            // 
            this.edCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edCountry.Location = new System.Drawing.Point(359, 318);
            this.edCountry.Name = "edCountry";
            this.edCountry.Size = new System.Drawing.Size(100, 20);
            this.edCountry.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edCountry);
            this.Controls.Add(this.edBirthdate);
            this.Controls.Add(this.edLastname);
            this.Controls.Add(this.edFirstname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAuthors);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdoNet - UI Test";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorsFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorsLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorsBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorsCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox edFirstname;
        private System.Windows.Forms.TextBox edLastname;
        private System.Windows.Forms.TextBox edBirthdate;
        private System.Windows.Forms.TextBox edCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

