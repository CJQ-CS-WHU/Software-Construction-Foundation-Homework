namespace HW9_CrawlWinform
{
    partial class Win
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
            this.btn_start = new System.Windows.Forms.Button();
            this.startUrlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(678, 52);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(93, 45);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // startUrlText
            // 
            this.startUrlText.Location = new System.Drawing.Point(69, 62);
            this.startUrlText.Name = "startUrlText";
            this.startUrlText.Size = new System.Drawing.Size(562, 35);
            this.startUrlText.TabIndex = 1;
            this.startUrlText.Text = "http://www.cnblogs.com/dstang2000/";
            this.startUrlText.TextChanged += new System.EventHandler(this.startUrlText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "调试了非常长时间，数据绑定没有成功。在控制台输出了爬取结果";
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startUrlText);
            this.Controls.Add(this.btn_start);
            this.Name = "Win";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox startUrlText;
        private System.Windows.Forms.Label label1;
    }
}

