namespace HW7_CayleyTree
{
    partial class CayTree
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
            System.Windows.Forms.TrackBar trackBar5;
            this.butDrawTree = new System.Windows.Forms.Button();
            this.lblTh2 = new System.Windows.Forms.Label();
            this.lblPen = new System.Windows.Forms.Label();
            this.lblTh1 = new System.Windows.Forms.Label();
            this.trbLeng = new System.Windows.Forms.TrackBar();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.trbPer1 = new System.Windows.Forms.TrackBar();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.trbPer2 = new System.Windows.Forms.TrackBar();
            this.lblLeng = new System.Windows.Forms.Label();
            this.trbth1 = new System.Windows.Forms.TrackBar();
            this.labChangeDeep = new System.Windows.Forms.Label();
            this.cbxPen = new System.Windows.Forms.ComboBox();
            this.trbN = new System.Windows.Forms.TrackBar();
            this.btnDraw = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            trackBar5 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbN)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar5
            // 
            trackBar5.LargeChange = 1;
            trackBar5.Location = new System.Drawing.Point(139, 4);
            trackBar5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            trackBar5.Maximum = 314;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new System.Drawing.Size(159, 90);
            trackBar5.TabIndex = 14;
            trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // butDrawTree
            // 
            this.butDrawTree.Location = new System.Drawing.Point(0, 0);
            this.butDrawTree.Name = "butDrawTree";
            this.butDrawTree.Size = new System.Drawing.Size(75, 23);
            this.butDrawTree.TabIndex = 0;
            // 
            // lblTh2
            // 
            this.lblTh2.AutoSize = true;
            this.lblTh2.Location = new System.Drawing.Point(3, 0);
            this.lblTh2.Name = "lblTh2";
            this.lblTh2.Size = new System.Drawing.Size(130, 24);
            this.lblTh2.TabIndex = 7;
            this.lblTh2.Text = "右分支角度";
            // 
            // lblPen
            // 
            this.lblPen.AutoSize = true;
            this.lblPen.Location = new System.Drawing.Point(3, 0);
            this.lblPen.Name = "lblPen";
            this.lblPen.Size = new System.Drawing.Size(106, 24);
            this.lblPen.TabIndex = 8;
            this.lblPen.Text = "画笔颜色";
            // 
            // lblTh1
            // 
            this.lblTh1.AutoSize = true;
            this.lblTh1.Location = new System.Drawing.Point(3, 0);
            this.lblTh1.Name = "lblTh1";
            this.lblTh1.Size = new System.Drawing.Size(130, 24);
            this.lblTh1.TabIndex = 6;
            this.lblTh1.Text = "左分支角度";
            // 
            // trbLeng
            // 
            this.trbLeng.LargeChange = 10;
            this.trbLeng.Location = new System.Drawing.Point(115, 4);
            this.trbLeng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbLeng.Maximum = 200;
            this.trbLeng.Name = "trbLeng";
            this.trbLeng.Size = new System.Drawing.Size(183, 90);
            this.trbLeng.TabIndex = 9;
            this.trbLeng.Scroll += new System.EventHandler(this.trbLeng_Scroll);
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Location = new System.Drawing.Point(3, 0);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(154, 24);
            this.lblPer2.TabIndex = 5;
            this.lblPer2.Text = "左分支长度比";
            // 
            // trbPer1
            // 
            this.trbPer1.LargeChange = 1;
            this.trbPer1.Location = new System.Drawing.Point(163, 4);
            this.trbPer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbPer1.Name = "trbPer1";
            this.trbPer1.Size = new System.Drawing.Size(135, 90);
            this.trbPer1.TabIndex = 10;
            this.trbPer1.Scroll += new System.EventHandler(this.trbPer1_Scroll);
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Location = new System.Drawing.Point(3, 0);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(154, 24);
            this.lblPer1.TabIndex = 4;
            this.lblPer1.Text = "右分支长度比";
            // 
            // trbPer2
            // 
            this.trbPer2.LargeChange = 1;
            this.trbPer2.Location = new System.Drawing.Point(163, 4);
            this.trbPer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbPer2.Name = "trbPer2";
            this.trbPer2.Size = new System.Drawing.Size(135, 90);
            this.trbPer2.TabIndex = 11;
            this.trbPer2.Scroll += new System.EventHandler(this.trbPer2_Scroll);
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(3, 0);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(106, 24);
            this.lblLeng.TabIndex = 3;
            this.lblLeng.Text = "主干长度";
            // 
            // trbth1
            // 
            this.trbth1.LargeChange = 1;
            this.trbth1.Location = new System.Drawing.Point(139, 4);
            this.trbth1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbth1.Maximum = 314;
            this.trbth1.Name = "trbth1";
            this.trbth1.Size = new System.Drawing.Size(159, 90);
            this.trbth1.TabIndex = 12;
            this.trbth1.Scroll += new System.EventHandler(this.trbth1_Scroll);
            // 
            // labChangeDeep
            // 
            this.labChangeDeep.AutoSize = true;
            this.labChangeDeep.Location = new System.Drawing.Point(3, 0);
            this.labChangeDeep.Name = "labChangeDeep";
            this.labChangeDeep.Size = new System.Drawing.Size(58, 24);
            this.labChangeDeep.TabIndex = 2;
            this.labChangeDeep.Text = "深度";
            // 
            // cbxPen
            // 
            this.cbxPen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPen.FormattingEnabled = true;
            this.cbxPen.Items.AddRange(new object[] {
            "红色",
            "黄色",
            "蓝色",
            "绿色",
            "紫色"});
            this.cbxPen.Location = new System.Drawing.Point(115, 4);
            this.cbxPen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPen.Name = "cbxPen";
            this.cbxPen.Size = new System.Drawing.Size(183, 32);
            this.cbxPen.TabIndex = 13;
            this.cbxPen.SelectedIndexChanged += new System.EventHandler(this.cbxPen_SelectedIndexChanged);
            // 
            // trbN
            // 
            this.trbN.BackColor = System.Drawing.SystemColors.Control;
            this.trbN.LargeChange = 1;
            this.trbN.Location = new System.Drawing.Point(67, 4);
            this.trbN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbN.Maximum = 100;
            this.trbN.Name = "trbN";
            this.trbN.Size = new System.Drawing.Size(231, 90);
            this.trbN.TabIndex = 1;
            this.trbN.Scroll += new System.EventHandler(this.trbN_Scroll);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(3, 5);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(301, 124);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.labChangeDeep);
            this.flowLayoutPanel1.Controls.Add(this.trbN);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 133);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 98);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lblLeng);
            this.flowLayoutPanel2.Controls.Add(this.trbLeng);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 256);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(301, 98);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.lblPer1);
            this.flowLayoutPanel3.Controls.Add(this.trbPer1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 497);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(301, 98);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.lblPer2);
            this.flowLayoutPanel4.Controls.Add(this.trbPer2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 374);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(301, 98);
            this.flowLayoutPanel4.TabIndex = 19;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.lblTh1);
            this.flowLayoutPanel5.Controls.Add(this.trbth1);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 619);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(301, 98);
            this.flowLayoutPanel5.TabIndex = 20;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.lblTh2);
            this.flowLayoutPanel6.Controls.Add(trackBar5);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 738);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(301, 98);
            this.flowLayoutPanel6.TabIndex = 21;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.lblPen);
            this.flowLayoutPanel7.Controls.Add(this.cbxPen);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 857);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(301, 40);
            this.flowLayoutPanel7.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(886, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.92308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 353);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel7);
            this.panel1.Controls.Add(this.flowLayoutPanel5);
            this.panel1.Controls.Add(this.flowLayoutPanel6);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(867, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 1399);
            this.panel1.TabIndex = 24;
            // 
            // CayTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 1399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CayTree";
            this.Text = "CayTree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbN)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDrawTree;
        private System.Windows.Forms.Label lblTh2;
        private System.Windows.Forms.Label lblPen;
        private System.Windows.Forms.Label lblTh1;
        private System.Windows.Forms.TrackBar trbLeng;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.TrackBar trbPer1;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.TrackBar trbPer2;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.TrackBar trbth1;
        private System.Windows.Forms.Label labChangeDeep;
        private System.Windows.Forms.ComboBox cbxPen;
        private System.Windows.Forms.TrackBar trbN;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

