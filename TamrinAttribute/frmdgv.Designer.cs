namespace TamrinAttribute
{
    partial class frmdgv
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
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.PhoneNumber});
            this.dgvDoctor.Location = new System.Drawing.Point(145, 25);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.RowHeadersWidth = 51;
            this.dgvDoctor.RowTemplate.Height = 24;
            this.dgvDoctor.Size = new System.Drawing.Size(621, 318);
            this.dgvDoctor.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 141);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 82);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "افزودن";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "اسم";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "شماره تماس";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // frmdgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 352);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvDoctor);
            this.Name = "frmdgv";
            this.Text = "فرم نمایش ";
            this.Load += new System.EventHandler(this.frmdgv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}

