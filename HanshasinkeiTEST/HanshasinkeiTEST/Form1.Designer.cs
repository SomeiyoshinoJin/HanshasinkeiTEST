namespace HanshasinkeiTEST
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuElement = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTrainingElement = new System.Windows.Forms.ToolStripMenuItem();
            this.StopTrainingElement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitElement = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2Element = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordElement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PinkElement = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenElement = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.AreaBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuElement,
            this.Menu2Element});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuElement
            // 
            this.MenuElement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartTrainingElement,
            this.StopTrainingElement,
            this.toolStripSeparator1,
            this.ExitElement});
            this.MenuElement.Name = "MenuElement";
            this.MenuElement.Size = new System.Drawing.Size(52, 20);
            this.MenuElement.Text = "メニュー";
            // 
            // StartTrainingElement
            // 
            this.StartTrainingElement.Name = "StartTrainingElement";
            this.StartTrainingElement.Size = new System.Drawing.Size(108, 22);
            this.StartTrainingElement.Text = "スタート";
            this.StartTrainingElement.Click += new System.EventHandler(this.StartTrainingElement_Click);
            // 
            // StopTrainingElement
            // 
            this.StopTrainingElement.Enabled = false;
            this.StopTrainingElement.Name = "StopTrainingElement";
            this.StopTrainingElement.Size = new System.Drawing.Size(108, 22);
            this.StopTrainingElement.Text = "停止";
            this.StopTrainingElement.Click += new System.EventHandler(this.StopTrainigElement_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // ExitElement
            // 
            this.ExitElement.Name = "ExitElement";
            this.ExitElement.Size = new System.Drawing.Size(108, 22);
            this.ExitElement.Text = "終了";
            this.ExitElement.Click += new System.EventHandler(this.ExitElement_Click);
            // 
            // Menu2Element
            // 
            this.Menu2Element.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordElement,
            this.toolStripSeparator2,
            this.PinkElement,
            this.GreenElement});
            this.Menu2Element.Name = "Menu2Element";
            this.Menu2Element.Size = new System.Drawing.Size(58, 20);
            this.Menu2Element.Text = "メニュー2";
            // 
            // RecordElement
            // 
            this.RecordElement.Name = "RecordElement";
            this.RecordElement.Size = new System.Drawing.Size(113, 22);
            this.RecordElement.Text = "記録";
            this.RecordElement.Click += new System.EventHandler(this.RecordElement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(110, 6);
            // 
            // PinkElement
            // 
            this.PinkElement.Name = "PinkElement";
            this.PinkElement.Size = new System.Drawing.Size(113, 22);
            this.PinkElement.Text = "ピンク色";
            this.PinkElement.Click += new System.EventHandler(this.PinkElement_Click);
            // 
            // GreenElement
            // 
            this.GreenElement.Name = "GreenElement";
            this.GreenElement.Size = new System.Drawing.Size(113, 22);
            this.GreenElement.Text = "緑色";
            this.GreenElement.Click += new System.EventHandler(this.GreenElement_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusLabel.Location = new System.Drawing.Point(3, 12);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(161, 55);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "反射神経テスト";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Location = new System.Drawing.Point(321, 182);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(167, 76);
            this.StatusPanel.TabIndex = 2;
            this.StatusPanel.Click += new System.EventHandler(this.StatusPanel_Click);
            // 
            // AreaBox
            // 
            this.AreaBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AreaBox.Location = new System.Drawing.Point(12, 27);
            this.AreaBox.Name = "AreaBox";
            this.AreaBox.Size = new System.Drawing.Size(776, 380);
            this.AreaBox.TabIndex = 3;
            this.AreaBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AreaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "反射神経テスト";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuElement;
        private System.Windows.Forms.ToolStripMenuItem StartTrainingElement;
        private System.Windows.Forms.ToolStripMenuItem StopTrainingElement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitElement;
        private System.Windows.Forms.ToolStripMenuItem Menu2Element;
        private System.Windows.Forms.ToolStripMenuItem RecordElement;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.PictureBox AreaBox;
        private System.Windows.Forms.ToolStripMenuItem GreenElement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PinkElement;
    }
}

