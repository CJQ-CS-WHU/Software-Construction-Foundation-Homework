namespace WindowsFormsApp5
{
    partial class Calculate
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
            this.button1 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(70, 134);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(113, 38);
            this.num1.TabIndex = 3;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(344, 131);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(110, 38);
            this.num2.TabIndex = 4;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // op
            // 
            this.op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op.FormattingEnabled = true;
            this.op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.op.Location = new System.Drawing.Point(211, 134);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(91, 35);
            this.op.TabIndex = 5;
            this.op.SelectedIndexChanged += new System.EventHandler(this.op_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(621, 140);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(26, 27);
            this.result.TabIndex = 6;
            this.result.Text = "0";
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Location = new System.Drawing.Point(65, 294);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(236, 27);
            this.messageBox.TabIndex = 7;
            this.messageBox.Text = "Result is right!";
            this.messageBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 364);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.op);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button1);
            this.Name = "Calculate";
            this.Text = "Calculate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.ComboBox op;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label messageBox;
    }
}

