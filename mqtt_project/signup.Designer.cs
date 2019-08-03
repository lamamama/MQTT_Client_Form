namespace mqtt_project
{
    partial class signup
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
            this.Type_Label = new System.Windows.Forms.Label();
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.User_Label = new System.Windows.Forms.Label();
            this.Sex_Label = new System.Windows.Forms.Label();
            this.Account_TextBox = new System.Windows.Forms.TextBox();
            this.Account_Label = new System.Windows.Forms.Label();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.PWD_TextBox = new System.Windows.Forms.TextBox();
            this.PWD_Label = new System.Windows.Forms.Label();
            this.Sex_CcomboBox = new System.Windows.Forms.ComboBox();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Type_Label, 2);
            this.Type_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Type_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type_Label.Location = new System.Drawing.Point(54, 43);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(96, 43);
            this.Type_Label.TabIndex = 0;
            this.Type_Label.Text = "账户类型：";
            this.Type_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // User_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.User_TextBox, 4);
            this.User_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_TextBox.Location = new System.Drawing.Point(156, 89);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(198, 21);
            this.User_TextBox.TabIndex = 3;
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.User_Label, 2);
            this.User_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_Label.Location = new System.Drawing.Point(54, 86);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(96, 43);
            this.User_Label.TabIndex = 2;
            this.User_Label.Text = "姓名：";
            this.User_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Sex_Label
            // 
            this.Sex_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Sex_Label, 2);
            this.Sex_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sex_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sex_Label.Location = new System.Drawing.Point(54, 129);
            this.Sex_Label.Name = "Sex_Label";
            this.Sex_Label.Size = new System.Drawing.Size(96, 43);
            this.Sex_Label.TabIndex = 4;
            this.Sex_Label.Text = "性别：";
            this.Sex_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Account_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Account_TextBox, 4);
            this.Account_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_TextBox.Location = new System.Drawing.Point(156, 175);
            this.Account_TextBox.Name = "Account_TextBox";
            this.Account_TextBox.Size = new System.Drawing.Size(198, 21);
            this.Account_TextBox.TabIndex = 7;
            // 
            // Account_Label
            // 
            this.Account_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Account_Label, 2);
            this.Account_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account_Label.Location = new System.Drawing.Point(54, 172);
            this.Account_Label.Name = "Account_Label";
            this.Account_Label.Size = new System.Drawing.Size(96, 43);
            this.Account_Label.TabIndex = 6;
            this.Account_Label.Text = "身份证号：";
            this.Account_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Phone_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Phone_TextBox, 4);
            this.Phone_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone_TextBox.Location = new System.Drawing.Point(156, 218);
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(198, 21);
            this.Phone_TextBox.TabIndex = 9;
            this.Phone_TextBox.TextChanged += new System.EventHandler(this.Phone_TextBox_TextChanged);
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Phone_Label, 2);
            this.Phone_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Phone_Label.Location = new System.Drawing.Point(54, 215);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(96, 43);
            this.Phone_Label.TabIndex = 8;
            this.Phone_Label.Text = "手机号码：";
            this.Phone_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PWD_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PWD_TextBox, 4);
            this.PWD_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWD_TextBox.Location = new System.Drawing.Point(156, 261);
            this.PWD_TextBox.Name = "PWD_TextBox";
            this.PWD_TextBox.Size = new System.Drawing.Size(198, 21);
            this.PWD_TextBox.TabIndex = 11;
            this.PWD_TextBox.UseSystemPasswordChar = true;
            // 
            // PWD_Label
            // 
            this.PWD_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.PWD_Label, 2);
            this.PWD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWD_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWD_Label.Location = new System.Drawing.Point(54, 258);
            this.PWD_Label.Name = "PWD_Label";
            this.PWD_Label.Size = new System.Drawing.Size(96, 43);
            this.PWD_Label.TabIndex = 10;
            this.PWD_Label.Text = "密码：";
            this.PWD_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Sex_CcomboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Sex_CcomboBox, 4);
            this.Sex_CcomboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sex_CcomboBox.FormattingEnabled = true;
            this.Sex_CcomboBox.Location = new System.Drawing.Point(156, 132);
            this.Sex_CcomboBox.Name = "Sex_CcomboBox";
            this.Sex_CcomboBox.Size = new System.Drawing.Size(198, 20);
            this.Sex_CcomboBox.TabIndex = 12;
            // 
            // Submit_BTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Submit_BTN, 2);
            this.Submit_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Submit_BTN.Location = new System.Drawing.Point(105, 347);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(96, 37);
            this.Submit_BTN.TabIndex = 13;
            this.Submit_BTN.Text = "确认";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Cancel_BTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Cancel_BTN, 2);
            this.Cancel_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_BTN.Location = new System.Drawing.Point(309, 347);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(96, 37);
            this.Cancel_BTN.TabIndex = 14;
            this.Cancel_BTN.Text = "取消";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            this.Cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.Type_ComboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_BTN, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.Type_Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Submit_BTN, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.PWD_TextBox, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.Sex_CcomboBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.PWD_Label, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.User_Label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Phone_TextBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.User_TextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Phone_Label, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Sex_Label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Account_TextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Account_Label, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 435);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // Type_ComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Type_ComboBox, 4);
            this.Type_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(156, 46);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(198, 20);
            this.Type_ComboBox.TabIndex = 15;
            this.Type_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Type_ComboBox_SelectedIndexChanged);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "signup";
            this.Text = "注册界面";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.TextBox User_TextBox;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.Label Sex_Label;
        private System.Windows.Forms.TextBox Account_TextBox;
        private System.Windows.Forms.Label Account_Label;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.TextBox PWD_TextBox;
        private System.Windows.Forms.Label PWD_Label;
        private System.Windows.Forms.ComboBox Sex_CcomboBox;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox Type_ComboBox;
    }
}