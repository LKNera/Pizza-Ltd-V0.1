namespace Pizza_Ltd_V0._1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNoOfPpl = new System.Windows.Forms.Label();
            this.txtNoOfPpl = new System.Windows.Forms.NumericUpDown();
            this.labelPieces = new System.Windows.Forms.Label();
            this.txtPieces = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Inches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfPpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPieces);
            this.panel1.Controls.Add(this.labelPieces);
            this.panel1.Controls.Add(this.txtNoOfPpl);
            this.panel1.Controls.Add(this.labelNoOfPpl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelNoOfPpl
            // 
            this.labelNoOfPpl.AutoSize = true;
            this.labelNoOfPpl.Location = new System.Drawing.Point(12, 9);
            this.labelNoOfPpl.Name = "labelNoOfPpl";
            this.labelNoOfPpl.Size = new System.Drawing.Size(92, 13);
            this.labelNoOfPpl.TabIndex = 0;
            this.labelNoOfPpl.Text = "Number of People";
            // 
            // txtNoOfPpl
            // 
            this.txtNoOfPpl.Location = new System.Drawing.Point(110, 3);
            this.txtNoOfPpl.Name = "txtNoOfPpl";
            this.txtNoOfPpl.Size = new System.Drawing.Size(120, 20);
            this.txtNoOfPpl.TabIndex = 1;
            // 
            // labelPieces
            // 
            this.labelPieces.AutoSize = true;
            this.labelPieces.Location = new System.Drawing.Point(12, 42);
            this.labelPieces.Name = "labelPieces";
            this.labelPieces.Size = new System.Drawing.Size(92, 13);
            this.labelPieces.TabIndex = 2;
            this.labelPieces.Text = "Pieces per person";
            // 
            // txtPieces
            // 
            this.txtPieces.Location = new System.Drawing.Point(110, 35);
            this.txtPieces.Name = "txtPieces";
            this.txtPieces.Size = new System.Drawing.Size(120, 20);
            this.txtPieces.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inches,
            this.Cost,
            this.Pieces});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 350);
            this.dataGridView.TabIndex = 1;
            // 
            // Inches
            // 
            this.Inches.HeaderText = "Inches";
            this.Inches.Name = "Inches";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // Pieces
            // 
            this.Pieces.HeaderText = "Pieces";
            this.Pieces.Name = "Pieces";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Pizza Ltd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfPpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtPieces;
        private System.Windows.Forms.Label labelPieces;
        private System.Windows.Forms.NumericUpDown txtNoOfPpl;
        private System.Windows.Forms.Label labelNoOfPpl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pieces;
    }
}

