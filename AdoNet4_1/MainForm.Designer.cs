
namespace AdoNet4_1
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
            this.btnGetFactory = new System.Windows.Forms.Button();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.edSQL = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetFactory
            // 
            this.btnGetFactory.Location = new System.Drawing.Point(12, 12);
            this.btnGetFactory.Name = "btnGetFactory";
            this.btnGetFactory.Size = new System.Drawing.Size(75, 23);
            this.btnGetFactory.TabIndex = 0;
            this.btnGetFactory.Text = "Get Factory";
            this.btnGetFactory.UseVisualStyleBackColor = true;
            this.btnGetFactory.Click += new System.EventHandler(this.btnGetFactory_Click);
            // 
            // cmbProvider
            // 
            this.cmbProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(93, 14);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(459, 21);
            this.cmbProvider.TabIndex = 1;
            this.cmbProvider.SelectedIndexChanged += new System.EventHandler(this.cmbProvider_SelectedIndexChanged);
            // 
            // dgvContent
            // 
            this.dgvContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Location = new System.Drawing.Point(12, 78);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(540, 299);
            this.dgvContent.TabIndex = 2;
            // 
            // edSQL
            // 
            this.edSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSQL.Location = new System.Drawing.Point(12, 52);
            this.edSQL.Name = "edSQL";
            this.edSQL.Size = new System.Drawing.Size(459, 20);
            this.edSQL.TabIndex = 3;
            this.edSQL.Text = "select * from";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(477, 50);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 389);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.edSQL);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.btnGetFactory);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdoNet - DbFactory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetFactory;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.TextBox edSQL;
        private System.Windows.Forms.Button btnExecute;
    }
}

