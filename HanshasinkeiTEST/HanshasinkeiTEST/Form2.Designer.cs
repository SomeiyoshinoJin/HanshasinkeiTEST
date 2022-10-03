namespace HanshasinkeiTEST
{
    partial class Form2
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
            this.RecordNameLabel = new System.Windows.Forms.Label();
            this.recordName = new System.Windows.Forms.TextBox();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.recordDataSet = new HanshasinkeiTEST.RecordDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordNameLabel
            // 
            this.RecordNameLabel.AutoSize = true;
            this.RecordNameLabel.Location = new System.Drawing.Point(18, 21);
            this.RecordNameLabel.Name = "RecordNameLabel";
            this.RecordNameLabel.Size = new System.Drawing.Size(29, 12);
            this.RecordNameLabel.TabIndex = 1;
            this.RecordNameLabel.Text = "名前";
            // 
            // recordName
            // 
            this.recordName.Location = new System.Drawing.Point(20, 45);
            this.recordName.Name = "recordName";
            this.recordName.Size = new System.Drawing.Size(116, 19);
            this.recordName.TabIndex = 3;
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Location = new System.Drawing.Point(17, 79);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(29, 12);
            this.RecordLabel.TabIndex = 4;
            this.RecordLabel.Text = "記録";
            // 
            // record
            // 
            this.record.Enabled = false;
            this.record.Location = new System.Drawing.Point(20, 103);
            this.record.Mask = "0.000";
            this.record.Name = "record";
            this.record.ReadOnly = true;
            this.record.Size = new System.Drawing.Size(116, 19);
            this.record.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(163, 57);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 51);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "登録";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // recordDataSet
            // 
            this.recordDataSet.DataSetName = "RecordDataSet";
            this.recordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 154);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.record);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.recordName);
            this.Controls.Add(this.RecordNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecordNameLabel;
        private System.Windows.Forms.TextBox recordName;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.MaskedTextBox record;
        private System.Windows.Forms.Button AddButton;
        private RecordDataSet recordDataSet;
    }
}