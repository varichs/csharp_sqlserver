namespace SQLserver2016
{
    partial class Mainfrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.btnData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(43, 46);
            this.DGridView.Name = "DGridView";
            this.DGridView.RowTemplate.Height = 30;
            this.DGridView.Size = new System.Drawing.Size(659, 250);
            this.DGridView.TabIndex = 0;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(43, 406);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(659, 62);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "获取数据";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 498);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.DGridView);
            this.Name = "Mainfrm";
            this.Text = "SQlserver数据库测试";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.Button btnData;
    }
}

