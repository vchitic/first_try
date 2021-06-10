namespace first_try
{
    partial class Formular_Import_OP
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
            this.dataGridViewOP = new System.Windows.Forms.DataGridView();
            this.btnImportExcelOP = new System.Windows.Forms.Button();
            this.btnSaveToDB_OP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOP
            // 
            this.dataGridViewOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOP.Location = new System.Drawing.Point(64, 164);
            this.dataGridViewOP.Name = "dataGridViewOP";
            this.dataGridViewOP.Size = new System.Drawing.Size(661, 248);
            this.dataGridViewOP.TabIndex = 1;
            // 
            // btnImportExcelOP
            // 
            this.btnImportExcelOP.Location = new System.Drawing.Point(226, 75);
            this.btnImportExcelOP.Name = "btnImportExcelOP";
            this.btnImportExcelOP.Size = new System.Drawing.Size(107, 31);
            this.btnImportExcelOP.TabIndex = 2;
            this.btnImportExcelOP.Text = "Importare Excel";
            this.btnImportExcelOP.UseVisualStyleBackColor = true;
            this.btnImportExcelOP.Click += new System.EventHandler(this.btnImportExcelOP_Click);
            // 
            // btnSaveToDB_OP
            // 
            this.btnSaveToDB_OP.Location = new System.Drawing.Point(415, 75);
            this.btnSaveToDB_OP.Name = "btnSaveToDB_OP";
            this.btnSaveToDB_OP.Size = new System.Drawing.Size(134, 31);
            this.btnSaveToDB_OP.TabIndex = 3;
            this.btnSaveToDB_OP.Text = "Salvare/Spre formular";
            this.btnSaveToDB_OP.UseVisualStyleBackColor = true;
            this.btnSaveToDB_OP.Click += new System.EventHandler(this.btnSaveToDB_OP_Click);
            // 
            // Formular_Import_OP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveToDB_OP);
            this.Controls.Add(this.btnImportExcelOP);
            this.Controls.Add(this.dataGridViewOP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formular_Import_OP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importare Excel pentru Ordinul de Plată";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOP;
        private System.Windows.Forms.Button btnImportExcelOP;
        private System.Windows.Forms.Button btnSaveToDB_OP;
    }
}