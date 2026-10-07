namespace TamrinAttribute
{
    partial class frmAdd
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
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(72, 53);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(159, 22);
            this.txtfirstname.TabIndex = 0;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(72, 115);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(159, 22);
            this.txtlastname.TabIndex = 0;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(72, 178);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(159, 22);
            this.txtphonenumber.TabIndex = 0;
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(102, 237);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(117, 53);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = " اضافه کردن";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonenumber.Location = new System.Drawing.Point(264, 168);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(127, 32);
            this.lblphonenumber.TabIndex = 2;
            this.lblphonenumber.Text = "شماره تماس";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(260, 105);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(131, 32);
            this.lbllastname.TabIndex = 2;
            this.lbllastname.Text = "نام خانوادگی";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(295, 43);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(38, 32);
            this.lblfirstname.TabIndex = 2;
            this.lblfirstname.Text = "نام";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 312);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Name = "frmAdd";
            this.Text = "فرم افزودن";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}