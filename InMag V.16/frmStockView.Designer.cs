﻿namespace InMag_V._16
{
    partial class frmStockView
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbReorderLevel = new System.Windows.Forms.RadioButton();
            this.rbNegative = new System.Windows.Forms.RadioButton();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(320, 46);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 28);
            this.btnPrint.TabIndex = 92;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(16, 11);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(134, 27);
            this.lblArea.TabIndex = 90;
            this.lblArea.Text = "Stock View";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Filter";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.ForeColor = System.Drawing.Color.White;
            this.rbAll.Location = new System.Drawing.Point(72, 46);
            this.rbAll.Margin = new System.Windows.Forms.Padding(2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 94;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbReorderLevel
            // 
            this.rbReorderLevel.AutoSize = true;
            this.rbReorderLevel.ForeColor = System.Drawing.Color.White;
            this.rbReorderLevel.Location = new System.Drawing.Point(129, 46);
            this.rbReorderLevel.Margin = new System.Windows.Forms.Padding(2);
            this.rbReorderLevel.Name = "rbReorderLevel";
            this.rbReorderLevel.Size = new System.Drawing.Size(97, 17);
            this.rbReorderLevel.TabIndex = 95;
            this.rbReorderLevel.Text = "Re-Order Level";
            this.rbReorderLevel.UseVisualStyleBackColor = true;
            this.rbReorderLevel.CheckedChanged += new System.EventHandler(this.rbReorderLevel_CheckedChanged);
            // 
            // rbNegative
            // 
            this.rbNegative.AutoSize = true;
            this.rbNegative.ForeColor = System.Drawing.Color.White;
            this.rbNegative.Location = new System.Drawing.Point(239, 46);
            this.rbNegative.Margin = new System.Windows.Forms.Padding(2);
            this.rbNegative.Name = "rbNegative";
            this.rbNegative.Size = new System.Drawing.Size(68, 17);
            this.rbNegative.TabIndex = 96;
            this.rbNegative.Text = "Negative";
            this.rbNegative.UseVisualStyleBackColor = true;
            this.rbNegative.CheckedChanged += new System.EventHandler(this.rbNegative_CheckedChanged);
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.AllowUserToResizeColumns = false;
            this.ItemGrid.AllowUserToResizeRows = false;
            this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ItemGrid.Location = new System.Drawing.Point(20, 78);
            this.ItemGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ItemGrid.MultiSelect = false;
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.ReadOnly = true;
            this.ItemGrid.RowHeadersVisible = false;
            this.ItemGrid.RowTemplate.Height = 24;
            this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGrid.Size = new System.Drawing.Size(422, 349);
            this.ItemGrid.TabIndex = 97;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(383, 46);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(59, 28);
            this.btnExport.TabIndex = 98;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(460, 453);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.ItemGrid);
            this.Controls.Add(this.rbNegative);
            this.Controls.Add(this.rbReorderLevel);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmStockView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock View";
            this.Load += new System.EventHandler(this.frmStockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbReorderLevel;
        private System.Windows.Forms.RadioButton rbNegative;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.Button btnExport;
    }
}