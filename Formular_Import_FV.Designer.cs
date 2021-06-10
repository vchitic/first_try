namespace first_try
{
    partial class Formular_Import_FV
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
            this.dataGridViewFV = new System.Windows.Forms.DataGridView();
            this.btnImportExcelFV = new System.Windows.Forms.Button();
            this.btnSaveToDB_FV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFV
            // 
            this.dataGridViewFV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFV.Location = new System.Drawing.Point(64, 164);
            this.dataGridViewFV.Name = "dataGridViewFV";
            this.dataGridViewFV.Size = new System.Drawing.Size(661, 248);
            this.dataGridViewFV.TabIndex = 0;
            // 
            // btnImportExcelFV
            // 
            this.btnImportExcelFV.Location = new System.Drawing.Point(226, 75);
            this.btnImportExcelFV.Name = "btnImportExcelFV";
            this.btnImportExcelFV.Size = new System.Drawing.Size(107, 31);
            this.btnImportExcelFV.TabIndex = 1;
            this.btnImportExcelFV.Text = "Importare Excel";
            this.btnImportExcelFV.UseVisualStyleBackColor = true;
            this.btnImportExcelFV.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnSaveToDB_FV
            // 
            this.btnSaveToDB_FV.Location = new System.Drawing.Point(415, 75);
            this.btnSaveToDB_FV.Name = "btnSaveToDB_FV";
            this.btnSaveToDB_FV.Size = new System.Drawing.Size(134, 31);
            this.btnSaveToDB_FV.TabIndex = 2;
            this.btnSaveToDB_FV.Text = "Salvare/Spre formular";
            this.btnSaveToDB_FV.UseVisualStyleBackColor = true;
            this.btnSaveToDB_FV.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // Formular_Import_FV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveToDB_FV);
            this.Controls.Add(this.btnImportExcelFV);
            this.Controls.Add(this.dataGridViewFV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formular_Import_FV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importare Excel pentru Foaia de Vărsământ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFV;
        private System.Windows.Forms.Button btnImportExcelFV;
        private System.Windows.Forms.Button btnSaveToDB_FV;
    }
}