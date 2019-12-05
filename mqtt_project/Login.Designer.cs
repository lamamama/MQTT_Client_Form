namespace mqtt_project
{
    partial class Login
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
            this.PWD_Label = new System.Windows.Forms.Label();
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.PWD_TextBox = new System.Windows.Forms.TextBox();
            this.Login_BTN = new System.Windows.Forms.Button();
            this.SignUp_BTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.User_Label = new System.Windows.Forms.Label();
            this.UserType_ComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PWD_Label
            // 
            this.PWD_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.PWD_Label, 2);
            this.PWD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWD_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWD_Label.Location = new System.Drawing.Point(78, 174);
            this.PWD_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PWD_Label.Name = "PWD_Label";
            this.PWD_Label.Size = new System.Drawing.Size(140, 87);
            this.PWD_Label.TabIndex = 1;
            this.PWD_Label.Text = "密码：";
            this.PWD_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // User_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.User_TextBox, 4);
            this.User_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_TextBox.Location = new System.Drawing.Point(226, 91);
            this.User_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(288, 25);
            this.User_TextBox.TabIndex = 2;
            // 
            // PWD_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PWD_TextBox, 4);
            this.PWD_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWD_TextBox.Location = new System.Drawing.Point(226, 178);
            this.PWD_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PWD_TextBox.Name = "PWD_TextBox";
            this.PWD_TextBox.Size = new System.Drawing.Size(288, 25);
            this.PWD_TextBox.TabIndex = 3;
            this.PWD_TextBox.UseSystemPasswordChar = true;
            // 
            // Login_BTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Login_BTN, 2);
            this.Login_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_BTN.Location = new System.Drawing.Point(374, 265);
            this.Login_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Size = new System.Drawing.Size(140, 79);
            this.Login_BTN.TabIndex = 4;
            this.Login_BTN.Text = "登陆";
            this.Login_BTN.UseVisualStyleBackColor = true;
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
            // 
            // SignUp_BTN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SignUp_BTN, 2);
            this.SignUp_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUp_BTN.Location = new System.Drawing.Point(152, 265);
            this.SignUp_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp_BTN.Name = "SignUp_BTN";
            this.SignUp_BTN.Size = new System.Drawing.Size(140, 79);
            this.SignUp_BTN.TabIndex = 5;
            this.SignUp_BTN.Text = "注册";
            this.SignUp_BTN.UseVisualStyleBackColor = true;
            this.SignUp_BTN.Click += new System.EventHandler(this.SignUp_BTN_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.Login_BTN, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.SignUp_BTN, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.User_Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.User_TextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PWD_TextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.PWD_Label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserType_ComboBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 438);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.User_Label, 2);
            this.User_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_Label.Location = new System.Drawing.Point(78, 87);
            this.User_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(140, 87);
            this.User_Label.TabIndex = 1;
            this.User_Label.Text = "用户名：";
            this.User_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserType_ComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.UserType_ComboBox, 3);
            this.UserType_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserType_ComboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserType_ComboBox.FormattingEnabled = true;
            this.UserType_ComboBox.Location = new System.Drawing.Point(4, 4);
            this.UserType_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserType_ComboBox.Name = "UserType_ComboBox";
            this.UserType_ComboBox.Size = new System.Drawing.Size(214, 25);
            this.UserType_ComboBox.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "登陆界面";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PWD_Label;
        private System.Windows.Forms.TextBox User_TextBox;
        private System.Windows.Forms.TextBox PWD_TextBox;
        private System.Windows.Forms.Button Login_BTN;
        private System.Windows.Forms.Button SignUp_BTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.ComboBox UserType_ComboBox;
    }
}