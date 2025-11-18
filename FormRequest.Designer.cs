namespace Hospital
{
    partial class FormRequest
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
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.dgvRequestDetails = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRequests
            // 
            this.lstRequests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.ItemHeight = 19;
            this.lstRequests.Location = new System.Drawing.Point(12, 44);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(181, 80);
            this.lstRequests.TabIndex = 0;
            // 
            // dgvRequestDetails
            // 
            this.dgvRequestDetails.AllowUserToAddRows = false;
            this.dgvRequestDetails.AllowUserToDeleteRows = false;
            this.dgvRequestDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestDetails.Location = new System.Drawing.Point(227, 44);
            this.dgvRequestDetails.Name = "dgvRequestDetails";
            this.dgvRequestDetails.ReadOnly = true;
            this.dgvRequestDetails.Size = new System.Drawing.Size(177, 178);
            this.dgvRequestDetails.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(126, 253);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(53, 21);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label1";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 305);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvRequestDetails);
            this.Controls.Add(this.lstRequests);
            this.Name = "FormRequest";
            this.Text = "FormRequest";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRequests;
        private System.Windows.Forms.DataGridView dgvRequestDetails;
        private System.Windows.Forms.Label lblInfo;
    }
}