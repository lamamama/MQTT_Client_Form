namespace mqtt_project
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pub_BTN = new System.Windows.Forms.Button();
            this.SUB_BTN = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.History_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 21);
            this.textBox1.TabIndex = 0;
            // 
            // Pub_BTN
            // 
            this.Pub_BTN.Location = new System.Drawing.Point(263, 254);
            this.Pub_BTN.Name = "Pub_BTN";
            this.Pub_BTN.Size = new System.Drawing.Size(75, 23);
            this.Pub_BTN.TabIndex = 1;
            this.Pub_BTN.Text = "发布";
            this.Pub_BTN.UseVisualStyleBackColor = true;
            this.Pub_BTN.Click += new System.EventHandler(this.Pub_BTN_Click);
            // 
            // SUB_BTN
            // 
            this.SUB_BTN.Location = new System.Drawing.Point(456, 254);
            this.SUB_BTN.Name = "SUB_BTN";
            this.SUB_BTN.Size = new System.Drawing.Size(75, 23);
            this.SUB_BTN.TabIndex = 2;
            this.SUB_BTN.Text = "订阅";
            this.SUB_BTN.UseVisualStyleBackColor = true;
            this.SUB_BTN.Click += new System.EventHandler(this.SUB_BTN_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 21);
            this.textBox2.TabIndex = 3;
            // 
            // History_BTN
            // 
            this.History_BTN.Location = new System.Drawing.Point(481, 326);
            this.History_BTN.Name = "History_BTN";
            this.History_BTN.Size = new System.Drawing.Size(75, 23);
            this.History_BTN.TabIndex = 4;
            this.History_BTN.Text = "历史记录";
            this.History_BTN.UseVisualStyleBackColor = true;
            this.History_BTN.Click += new System.EventHandler(this.History_BTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "登陆界面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.History_BTN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SUB_BTN);
            this.Controls.Add(this.Pub_BTN);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Pub_BTN;
        private System.Windows.Forms.Button SUB_BTN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button History_BTN;
        private System.Windows.Forms.Button button1;
    }
}

