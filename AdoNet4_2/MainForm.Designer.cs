
namespace AdoNet4_2
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbAsyncEnabled = new System.Windows.Forms.CheckBox();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.btnSyncQuery = new System.Windows.Forms.Button();
            this.btnAsyncQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbAsyncEnabled
            // 
            this.cbAsyncEnabled.AutoSize = true;
            this.cbAsyncEnabled.Location = new System.Drawing.Point(93, 16);
            this.cbAsyncEnabled.Name = "cbAsyncEnabled";
            this.cbAsyncEnabled.Size = new System.Drawing.Size(97, 17);
            this.cbAsyncEnabled.TabIndex = 1;
            this.cbAsyncEnabled.Text = "Async Enabled";
            this.cbAsyncEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(93, 51);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(173, 21);
            this.cmbTables.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select table";
            // 
            // dgvContent
            // 
            this.dgvContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Location = new System.Drawing.Point(12, 78);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(484, 323);
            this.dgvContent.TabIndex = 4;
            // 
            // btnSyncQuery
            // 
            this.btnSyncQuery.Location = new System.Drawing.Point(272, 49);
            this.btnSyncQuery.Name = "btnSyncQuery";
            this.btnSyncQuery.Size = new System.Drawing.Size(75, 23);
            this.btnSyncQuery.TabIndex = 5;
            this.btnSyncQuery.Text = "Sync";
            this.btnSyncQuery.UseVisualStyleBackColor = true;
            this.btnSyncQuery.Click += new System.EventHandler(this.btnSyncQuery_Click);
            // 
            // btnAsyncQuery
            // 
            this.btnAsyncQuery.Location = new System.Drawing.Point(353, 49);
            this.btnAsyncQuery.Name = "btnAsyncQuery";
            this.btnAsyncQuery.Size = new System.Drawing.Size(75, 23);
            this.btnAsyncQuery.TabIndex = 6;
            this.btnAsyncQuery.Text = "Async";
            this.btnAsyncQuery.UseVisualStyleBackColor = true;
            this.btnAsyncQuery.Click += new System.EventHandler(this.btnAsyncQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 413);
            this.Controls.Add(this.btnAsyncQuery);
            this.Controls.Add(this.btnSyncQuery);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.cbAsyncEnabled);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "AdoNet 4 - AsyncDb";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox cbAsyncEnabled;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.Button btnSyncQuery;
        private System.Windows.Forms.Button btnAsyncQuery;
    }
}

