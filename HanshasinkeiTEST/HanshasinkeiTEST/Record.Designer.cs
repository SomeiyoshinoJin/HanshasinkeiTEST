﻿namespace HanshasinkeiTEST
{
    partial class Record
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordDataSet = new HanshasinkeiTEST.RecordDataSet();
            this.EndButton = new System.Windows.Forms.Button();
            this.名前DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.記録DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名前DataGridViewTextBoxColumn,
            this.記録DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(221, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // recordDataTableBindingSource
            // 
            this.recordDataTableBindingSource.DataMember = "recordDataTable";
            this.recordDataTableBindingSource.DataSource = this.recordDataSet;
            // 
            // recordDataSet
            // 
            this.recordDataSet.DataSetName = "RecordDataSet";
            this.recordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(67, 342);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(104, 35);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // 名前DataGridViewTextBoxColumn
            // 
            this.名前DataGridViewTextBoxColumn.DataPropertyName = "名前";
            this.名前DataGridViewTextBoxColumn.HeaderText = "名前";
            this.名前DataGridViewTextBoxColumn.Name = "名前DataGridViewTextBoxColumn";
            this.名前DataGridViewTextBoxColumn.ReadOnly = true;
            this.名前DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.名前DataGridViewTextBoxColumn.Width = 167;
            // 
            // 記録DataGridViewTextBoxColumn
            // 
            this.記録DataGridViewTextBoxColumn.DataPropertyName = "記録";
            this.記録DataGridViewTextBoxColumn.HeaderText = "記録";
            this.記録DataGridViewTextBoxColumn.Name = "記録DataGridViewTextBoxColumn";
            this.記録DataGridViewTextBoxColumn.ReadOnly = true;
            this.記録DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.記録DataGridViewTextBoxColumn.Width = 52;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 386);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.BindingSource recordDataTableBindingSource;
        private RecordDataSet recordDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 記録DataGridViewTextBoxColumn;
    }
}