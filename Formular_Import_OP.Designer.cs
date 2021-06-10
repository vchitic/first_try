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
            this.btnSaveToDB_OP = new System.Windows.Forms.Button();
            this.lblNumeFisier = new System.Windows.Forms.Label();
            this.lblSheet = new System.Windows.Forms.Label();
            this.txtNumeFisier = new System.Windows.Forms.TextBox();
            this.cmbSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOP
            // 
            this.dataGridViewOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOP.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOP.Name = "dataGridViewOP";
            this.dataGridViewOP.Size = new System.Drawing.Size(605, 248);
            this.dataGridViewOP.TabIndex = 1;
            // 
            // btnSaveToDB_OP
            // 
            this.btnSaveToDB_OP.Location = new System.Drawing.Point(483, 361);
            this.btnSaveToDB_OP.Name = "btnSaveToDB_OP";
            this.btnSaveToDB_OP.Size = new System.Drawing.Size(134, 31);
            this.btnSaveToDB_OP.TabIndex = 3;
            this.btnSaveToDB_OP.Text = "Salvare/Spre formular";
            this.btnSaveToDB_OP.UseVisualStyleBackColor = true;
            this.btnSaveToDB_OP.Click += new System.EventHandler(this.btnSaveToDB_OP_Click);
            // 
            // lblNumeFisier
            // 
            this.lblNumeFisier.AutoSize = true;
            this.lblNumeFisier.Location = new System.Drawing.Point(9, 283);
            this.lblNumeFisier.Name = "lblNumeFisier";
            this.lblNumeFisier.Size = new System.Drawing.Size(59, 13);
            this.lblNumeFisier.TabIndex = 4;
            this.lblNumeFisier.Text = "Nume fișier";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Location = new System.Drawing.Point(12, 310);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(35, 13);
            this.lblSheet.TabIndex = 5;
            this.lblSheet.Text = "Sheet";
            // 
            // txtNumeFisier
            // 
            this.txtNumeFisier.Location = new System.Drawing.Point(77, 280);
            this.txtNumeFisier.Name = "txtNumeFisier";
            this.txtNumeFisier.ReadOnly = true;
            this.txtNumeFisier.Size = new System.Drawing.Size(500, 20);
            this.txtNumeFisier.TabIndex = 6;
            // 
            // cmbSheet
            // 
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.Location = new System.Drawing.Point(77, 307);
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(121, 21);
            this.cmbSheet.TabIndex = 7;
            this.cmbSheet.SelectedIndexChanged += new System.EventHandler(this.cmbSheet_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(583, 280);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 20);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Formular_Import_OP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 404);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbSheet);
            this.Controls.Add(this.txtNumeFisier);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.lblNumeFisier);
            this.Controls.Add(this.btnSaveToDB_OP);
            this.Controls.Add(this.dataGridViewOP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formular_Import_OP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importare Excel pentru Ordinul de Plată";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOP;
        private System.Windows.Forms.Button btnSaveToDB_OP;
        private System.Windows.Forms.Label lblNumeFisier;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.TextBox txtNumeFisier;
        private System.Windows.Forms.ComboBox cmbSheet;
        private System.Windows.Forms.Button btnBrowse;
    }
}